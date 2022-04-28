using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeSwitch
{
    public partial class MainWnd : Form
    {
        /// <summary>
        /// nvm版本
        /// </summary>
        private String mNvmVersion;
        /// <summary>
        /// 当前使用的Node版本
        /// </summary>
        private String mNodeVersion;

        /// <summary>
        /// 图标列表
        /// </summary>
        private ImageList mImageList;

        /// <summary>
        /// 已安装版本列表
        /// </summary>
        private List<String> mInstalls;
        /// <summary>
        /// 当前版本列表
        /// </summary>
        private List<String> mCurrents;

        /// <summary>
        /// LTS版本列表
        /// </summary>
        private List<String> mLongTimes;

        public MainWnd()
        {
            InitializeComponent();
        }

        private void MainWnd_Load(object sender, EventArgs e)
        {
            mImageList = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit,
                ImageSize = new Size(64, 64)
            };
            mImageList.Images.Add(Resource.NodeImageDray);
            mImageList.Images.Add(Resource.NodeImage);
            ListView_InstallList.LargeImageList = mImageList;

            ///
            Init();
        }

        private async void Init()
        {
            await RunCmd("nvm version", OnGetVersion);
            await UpdateNodeVersion();
            await UpdateList();
        }

        private void OnGetVersion(List<String> vs)
        {
            if (vs.Count > 0)
            {
                mNvmVersion = vs[0];
                Label_NvmVersion.Text = "NVM版本：" + vs[0];
            }
        }

        private void OnGetNodeVersion(List<String> vs)
        {
            if (vs.Count > 0)
            {
                mNodeVersion = vs[0];
                if (mNodeVersion.StartsWith('v'))
                    mNodeVersion = mNodeVersion[1..];
                Label_CurrentVersion.Text = "当前版本：" + vs[0];
            }
        }

        private Task UpdateNodeVersion()
        {
            return RunCmd("nvm current", OnGetNodeVersion);
        }

        private Task UpdateList()
        {
            ListView_InstallList.Items.Clear();
            return RunCmd("nvm list", OnGetInstallList);
        }

        private readonly Regex RegexVersion = new(@"\d+\.\d+\.\d+");
        private void OnGetInstallList(List<String> vs)
        {
            mInstalls = new();
            var items = ListView_InstallList.Items;
            foreach (String it in vs)
            {
                if (String.IsNullOrWhiteSpace(it)) continue;

                ///
                var match = RegexVersion.Match(it);
                if (match.Success)
                {
                    var version = match.Groups[0].Value;
                    items.Add(version, version == mNodeVersion ? 1 : 0);
                    mInstalls.Add(version);
                }
            }
        }

        private async Task RunCmd(String cmd, Action<List<String>> act)
        {
            Waitfor(true);
            LogMessage("-----------------------------------");
            LogMessage("Cmd:{0}", cmd);
            var lines = await RunCmdAsync(cmd);
            if (act != null)
                this.Invoke(act, lines);

            foreach (var line in lines)
            {
                LogMessage(line);
            }

            ///
            Waitfor(false);
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="cmd"></param>
        private Task<List<String>> RunCmdAsync(String cmd)
        {
            return Task<List<String>>.Run(() => {
                
                try
                {
                    return RunCmdProc(cmd);
                }
                catch (Exception ex)
                {
                    LogMessage("错误:{0}", ex.Message);
                }

                return null;
            });
        }

        class RunParam
        {
            public String Cmd;
            public Action<List<String>> ResultAct;

            public RunParam(String cmd, Action<List<String>> act)
            {
                Cmd = cmd;
                ResultAct = act;
            }
        }

        public static List<String> RunCmdProc(String cmd)
        {
            ProcessStartInfo psi = new ()
            {
                FileName = "cmd.exe",
                Arguments = "/c " + cmd,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            

            using var process = Process.Start(psi);
            var stdout = process.StandardOutput;

            String line; List<String> lines = new(); 
            while ((line = stdout.ReadLine()) != null)
            {
                lines.Add(line);
            }

            process.WaitForExit();

            ///
            return lines;
        }

        private readonly Queue<String> mMsgQueue = new();

        private void LogMessage(String format, params object[] args)
        {
            lock (mMsgQueue)
            {
                mMsgQueue.Enqueue(String.Format(format, args));
            }

            MainTimer.Enabled = true;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            lock (mMsgQueue)
            {
                while (mMsgQueue.Count > 0)
                {
                    TextBox_Output.AppendText(mMsgQueue.Dequeue() + "\r\n");
                }

                ///
                var textBox = TextBox_Output;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.ScrollToCaret();
            }

            MainTimer.Enabled = false;
        }

        private void Waitfor(bool wait)
        {
            Enabled = !wait;
        }

        private void ButtonClearOut_Click(object sender, EventArgs e)
        {
            TextBox_Output.Clear();
        }

        private void ListView_InstallList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = ListView_InstallList.HitTest(e.Location);
            if (hit.Item == null) return;

            String version = hit.Item.Text;
            if (version == mNodeVersion)
            {
                MessageBox.Show("选择的版本已在使用中");
                return;
            }

            ///
            var result = MessageBox.Show(String.Format("是否切换到版本：<{0}>？", version), "提示", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            ///
            SwitchVersion(version);
        }

        /// <summary>
        /// 切换版本
        /// </summary>
        /// <param name="version"></param>
        private async void SwitchVersion(String version)
        {
            await RunCmd(String.Format("nvm use {0}", version), null);
            await UpdateNodeVersion();
            await UpdateList();
        }

        private void ListView_InstallList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ListView_InstallList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击安装按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Install_Click(object sender, EventArgs e)
        {
            //更新版本列表
            await UpdateVersionList();

            //选择版本对话框
            SelectVersion sv = new()
            {
                Currents = mCurrents,
                LongTimes = mLongTimes
            };

            if (sv.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var version = sv.SelectedVersion;
            if (mInstalls.Contains(version))
            {
                MessageBox.Show("选择的版本已安装");
                return;
            }

            // 安装并使用
            await RunCmd("nvm install " + version, null);
            SwitchVersion(version);
        }

        /// <summary>
        /// 更新版本列表
        /// </summary>
        /// <returns></returns>
        private async Task UpdateVersionList()
        {
            if (mCurrents != null) return;

            mCurrents = new();
            mLongTimes = new();
            await RunCmd("nvm list available", OnGetVersionList);
        }

        private readonly Regex RegexVersions = new(@"\|\s*(\d+\.\d+\.\d+)\s*\|\s*(\d+\.\d+\.\d+)\s*\|");

        /// <summary>
        /// 解析版本列表
        /// </summary>
        /// <param name="vs"></param>
        private void OnGetVersionList(List<String> vs)
        {
            foreach (String item in vs)
            {
                var match = RegexVersions.Match(item);
                if (match.Success)
                {
                    var curVersion = match.Groups[1].Value;
                    var ltsVersion = match.Groups[2].Value;
                    mCurrents.Add(curVersion);
                    mLongTimes.Add(ltsVersion);
                }
            }
        }
    }
}
