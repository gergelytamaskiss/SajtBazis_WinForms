namespace SajtBazis_WinForms
{
    partial class Form1
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_News = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lsb_News = new System.Windows.Forms.ListBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(270, 185);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(368, 185);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_News
            // 
            this.lbl_News.AutoSize = true;
            this.lbl_News.Location = new System.Drawing.Point(12, 24);
            this.lbl_News.Name = "lbl_News";
            this.lbl_News.Size = new System.Drawing.Size(37, 13);
            this.lbl_News.TabIndex = 2;
            this.lbl_News.Text = "News:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(267, 91);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(267, 122);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password:";
            // 
            // lsb_News
            // 
            this.lsb_News.FormattingEnabled = true;
            this.lsb_News.Location = new System.Drawing.Point(12, 40);
            this.lsb_News.Name = "lsb_News";
            this.lsb_News.Size = new System.Drawing.Size(232, 186);
            this.lsb_News.TabIndex = 5;
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(343, 84);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(100, 20);
            this.txb_Username.TabIndex = 6;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(343, 122);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(100, 20);
            this.txb_Password.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.lsb_News);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_News);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Name = "Form1";
            this.Text = "Login - SajtBázis";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_News;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ListBox lsb_News;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

