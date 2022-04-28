using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeSwitch
{
    public partial class SelectVersion : Form
    {
        public SelectVersion()
        {
            InitializeComponent();
        }

        public List<String> Currents { get; set; }

        public List<String> LongTimes { get; set; }

        public String SelectedVersion 
        { 
            get 
            {
                return TextBox_Version.Text;
            }  
        }

        private void SelectVersion_Load(object sender, EventArgs e)
        {
            foreach (var item in Currents)
                ListBox_Currents.Items.Add(item);
            foreach (var item in LongTimes)
                ListBox_LTS.Items.Add(item);
        }

        private void ListBox_Currents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Currents.SelectedItem != null)
                TextBox_Version.Text = ListBox_Currents.SelectedItem.ToString();
            ListBox_LTS.ClearSelected();
        }

        private void ListBox_LTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_LTS.SelectedItem != null)
                TextBox_Version.Text = ListBox_LTS.SelectedItem.ToString();
            ListBox_Currents.ClearSelected();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SelectedVersion))
            {
                MessageBox.Show("请指定版本");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
