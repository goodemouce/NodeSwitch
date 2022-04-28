
namespace NodeSwitch
{
    partial class MainWnd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.Label_CurrentVersion = new System.Windows.Forms.Label();
            this.ListView_InstallList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Label_VersionList = new System.Windows.Forms.Label();
            this.Button_Install = new System.Windows.Forms.Button();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.Label_Output = new System.Windows.Forms.Label();
            this.Label_NvmVersion = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonClearOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_CurrentVersion
            // 
            this.Label_CurrentVersion.AutoSize = true;
            this.Label_CurrentVersion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_CurrentVersion.Location = new System.Drawing.Point(12, 36);
            this.Label_CurrentVersion.Name = "Label_CurrentVersion";
            this.Label_CurrentVersion.Size = new System.Drawing.Size(90, 21);
            this.Label_CurrentVersion.TabIndex = 0;
            this.Label_CurrentVersion.Text = "当前版本：";
            // 
            // ListView_InstallList
            // 
            this.ListView_InstallList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListView_InstallList.HideSelection = false;
            this.ListView_InstallList.Location = new System.Drawing.Point(12, 84);
            this.ListView_InstallList.MultiSelect = false;
            this.ListView_InstallList.Name = "ListView_InstallList";
            this.ListView_InstallList.Size = new System.Drawing.Size(512, 172);
            this.ListView_InstallList.TabIndex = 1;
            this.ListView_InstallList.UseCompatibleStateImageBehavior = false;
            this.ListView_InstallList.SelectedIndexChanged += new System.EventHandler(this.ListView_InstallList_SelectedIndexChanged);
            this.ListView_InstallList.DoubleClick += new System.EventHandler(this.ListView_InstallList_DoubleClick);
            this.ListView_InstallList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_InstallList_MouseDoubleClick);
            // 
            // Label_VersionList
            // 
            this.Label_VersionList.AutoSize = true;
            this.Label_VersionList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_VersionList.Location = new System.Drawing.Point(12, 57);
            this.Label_VersionList.Name = "Label_VersionList";
            this.Label_VersionList.Size = new System.Drawing.Size(90, 21);
            this.Label_VersionList.TabIndex = 2;
            this.Label_VersionList.Text = "可用版本：";
            // 
            // Button_Install
            // 
            this.Button_Install.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Install.Location = new System.Drawing.Point(431, 20);
            this.Button_Install.Name = "Button_Install";
            this.Button_Install.Size = new System.Drawing.Size(93, 58);
            this.Button_Install.TabIndex = 3;
            this.Button_Install.Text = "安装...";
            this.Button_Install.UseVisualStyleBackColor = true;
            this.Button_Install.Click += new System.EventHandler(this.Button_Install_Click);
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Location = new System.Drawing.Point(12, 299);
            this.TextBox_Output.Multiline = true;
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Output.Size = new System.Drawing.Size(512, 174);
            this.TextBox_Output.TabIndex = 4;
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Output.Location = new System.Drawing.Point(12, 275);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(90, 21);
            this.Label_Output.TabIndex = 5;
            this.Label_Output.Text = "输出信息：";
            // 
            // Label_NvmVersion
            // 
            this.Label_NvmVersion.AutoSize = true;
            this.Label_NvmVersion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_NvmVersion.Location = new System.Drawing.Point(12, 15);
            this.Label_NvmVersion.Name = "Label_NvmVersion";
            this.Label_NvmVersion.Size = new System.Drawing.Size(98, 21);
            this.Label_NvmVersion.TabIndex = 6;
            this.Label_NvmVersion.Text = "NVM版本：";
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ButtonClearOut
            // 
            this.ButtonClearOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClearOut.Location = new System.Drawing.Point(431, 262);
            this.ButtonClearOut.Name = "ButtonClearOut";
            this.ButtonClearOut.Size = new System.Drawing.Size(93, 31);
            this.ButtonClearOut.TabIndex = 7;
            this.ButtonClearOut.Text = "清空";
            this.ButtonClearOut.UseVisualStyleBackColor = true;
            this.ButtonClearOut.Click += new System.EventHandler(this.ButtonClearOut_Click);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 485);
            this.Controls.Add(this.ButtonClearOut);
            this.Controls.Add(this.Label_NvmVersion);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.TextBox_Output);
            this.Controls.Add(this.Button_Install);
            this.Controls.Add(this.Label_VersionList);
            this.Controls.Add(this.ListView_InstallList);
            this.Controls.Add(this.Label_CurrentVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Node Switcher";
            this.Load += new System.EventHandler(this.MainWnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_CurrentVersion;
        private System.Windows.Forms.ListView ListView_InstallList;
        private System.Windows.Forms.Label Label_VersionList;
        private System.Windows.Forms.Button Button_Install;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.Label Label_NvmVersion;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button ButtonClearOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

