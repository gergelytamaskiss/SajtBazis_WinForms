namespace SajtBazis_WinForms.Forms
{
    partial class UserNew
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.cmb_Permission = new System.Windows.Forms.ComboBox();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Permission = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsl_ManageUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(17, 27);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 15;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(241, 27);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "Password:";
            // 
            // tbx_Username
            // 
            this.tbx_Username.Location = new System.Drawing.Point(81, 24);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(135, 20);
            this.tbx_Username.TabIndex = 17;
            // 
            // cmb_Permission
            // 
            this.cmb_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Permission.FormattingEnabled = true;
            this.cmb_Permission.Location = new System.Drawing.Point(83, 76);
            this.cmb_Permission.Name = "cmb_Permission";
            this.cmb_Permission.Size = new System.Drawing.Size(135, 21);
            this.cmb_Permission.TabIndex = 22;
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(303, 24);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(135, 20);
            this.tbx_Password.TabIndex = 18;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(303, 50);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(135, 20);
            this.tbx_Email.TabIndex = 19;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(241, 56);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 21;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Permission
            // 
            this.lbl_Permission.AutoSize = true;
            this.lbl_Permission.Location = new System.Drawing.Point(17, 79);
            this.lbl_Permission.Name = "lbl_Permission";
            this.lbl_Permission.Size = new System.Drawing.Size(60, 13);
            this.lbl_Permission.TabIndex = 20;
            this.lbl_Permission.Text = "Permission:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(279, 104);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 23;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(363, 104);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_ManageUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 148);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsl_ManageUser
            // 
            this.tsl_ManageUser.Name = "tsl_ManageUser";
            this.tsl_ManageUser.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(17, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 26;
            this.lbl_Name.Text = "Name:";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(81, 50);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(135, 20);
            this.tbx_Name.TabIndex = 27;
            // 
            // UserNew
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(463, 170);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.cmb_Permission);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Permission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage user";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.ComboBox cmb_Permission;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Permission;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_ManageUser;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tbx_Name;
    }
}