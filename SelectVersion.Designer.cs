
namespace NodeSwitch
{
    partial class SelectVersion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SelectedVersion = new System.Windows.Forms.Label();
            this.TextBox_Version = new System.Windows.Forms.TextBox();
            this.ListBox_Currents = new System.Windows.Forms.ListBox();
            this.ListBox_LTS = new System.Windows.Forms.ListBox();
            this.Label_Currents = new System.Windows.Forms.Label();
            this.Label_LTS = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SelectedVersion
            // 
            this.Label_SelectedVersion.AutoSize = true;
            this.Label_SelectedVersion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_SelectedVersion.Location = new System.Drawing.Point(27, 43);
            this.Label_SelectedVersion.Name = "Label_SelectedVersion";
            this.Label_SelectedVersion.Size = new System.Drawing.Size(90, 21);
            this.Label_SelectedVersion.TabIndex = 0;
            this.Label_SelectedVersion.Text = "选择版本：";
            // 
            // TextBox_Version
            // 
            this.TextBox_Version.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Version.Location = new System.Drawing.Point(123, 40);
            this.TextBox_Version.Name = "TextBox_Version";
            this.TextBox_Version.Size = new System.Drawing.Size(144, 28);
            this.TextBox_Version.TabIndex = 1;
            // 
            // ListBox_Currents
            // 
            this.ListBox_Currents.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBox_Currents.FormattingEnabled = true;
            this.ListBox_Currents.ItemHeight = 21;
            this.ListBox_Currents.Location = new System.Drawing.Point(27, 147);
            this.ListBox_Currents.Name = "ListBox_Currents";
            this.ListBox_Currents.Size = new System.Drawing.Size(142, 235);
            this.ListBox_Currents.TabIndex = 2;
            this.ListBox_Currents.SelectedIndexChanged += new System.EventHandler(this.ListBox_Currents_SelectedIndexChanged);
            // 
            // ListBox_LTS
            // 
            this.ListBox_LTS.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBox_LTS.FormattingEnabled = true;
            this.ListBox_LTS.ItemHeight = 21;
            this.ListBox_LTS.Location = new System.Drawing.Point(204, 147);
            this.ListBox_LTS.Name = "ListBox_LTS";
            this.ListBox_LTS.Size = new System.Drawing.Size(153, 235);
            this.ListBox_LTS.TabIndex = 3;
            this.ListBox_LTS.SelectedIndexChanged += new System.EventHandler(this.ListBox_LTS_SelectedIndexChanged);
            // 
            // Label_Currents
            // 
            this.Label_Currents.AutoSize = true;
            this.Label_Currents.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Currents.Location = new System.Drawing.Point(25, 123);
            this.Label_Currents.Name = "Label_Currents";
            this.Label_Currents.Size = new System.Drawing.Size(122, 21);
            this.Label_Currents.TabIndex = 4;
            this.Label_Currents.Text = "当前版本列表：";
            // 
            // Label_LTS
            // 
            this.Label_LTS.AutoSize = true;
            this.Label_LTS.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_LTS.Location = new System.Drawing.Point(204, 123);
            this.Label_LTS.Name = "Label_LTS";
            this.Label_LTS.Size = new System.Drawing.Size(116, 21);
            this.Label_LTS.TabIndex = 5;
            this.Label_LTS.Text = "LTS版本列表：";
            // 
            // Button_OK
            // 
            this.Button_OK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_OK.Location = new System.Drawing.Point(282, 39);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 29);
            this.Button_OK.TabIndex = 6;
            this.Button_OK.Text = "安装";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // SelectVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 409);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Label_LTS);
            this.Controls.Add(this.Label_Currents);
            this.Controls.Add(this.ListBox_LTS);
            this.Controls.Add(this.ListBox_Currents);
            this.Controls.Add(this.TextBox_Version);
            this.Controls.Add(this.Label_SelectedVersion);
            this.Name = "SelectVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectVersion";
            this.Load += new System.EventHandler(this.SelectVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SelectedVersion;
        private System.Windows.Forms.TextBox TextBox_Version;
        private System.Windows.Forms.ListBox ListBox_Currents;
        private System.Windows.Forms.ListBox ListBox_LTS;
        private System.Windows.Forms.Label Label_Currents;
        private System.Windows.Forms.Label Label_LTS;
        private System.Windows.Forms.Button Button_OK;
    }
}