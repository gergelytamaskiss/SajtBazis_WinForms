namespace SajtBazis_WinForms.Forms
{
    partial class UserMaintenance
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
            this.btn_UserModify = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_UserDelete = new System.Windows.Forms.Button();
            this.btn_UserNew = new System.Windows.Forms.Button();
            this.grb_UserSearch = new System.Windows.Forms.GroupBox();
            this.btn_UserSearch = new System.Windows.Forms.Button();
            this.grb_UserManage = new System.Windows.Forms.GroupBox();
            this.grb_UserResult = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmb_Permission = new System.Windows.Forms.ComboBox();
            this.lbl_Permission = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.grb_UserSearch.SuspendLayout();
            this.grb_UserManage.SuspendLayout();
            this.grb_UserResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UserModify
            // 
            this.btn_UserModify.Location = new System.Drawing.Point(17, 55);
            this.btn_UserModify.Name = "btn_UserModify";
            this.btn_UserModify.Size = new System.Drawing.Size(75, 23);
            this.btn_UserModify.TabIndex = 1;
            this.btn_UserModify.Text = "Modify";
            this.btn_UserModify.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(17, 113);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(16, 26);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username:";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(84, 23);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(100, 20);
            this.tbx_UserName.TabIndex = 7;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(84, 76);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(100, 20);
            this.tbx_Email.TabIndex = 10;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(18, 79);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(342, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_UserDelete
            // 
            this.btn_UserDelete.Location = new System.Drawing.Point(17, 84);
            this.btn_UserDelete.Name = "btn_UserDelete";
            this.btn_UserDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_UserDelete.TabIndex = 16;
            this.btn_UserDelete.Text = "Delete";
            this.btn_UserDelete.UseVisualStyleBackColor = true;
            // 
            // btn_UserNew
            // 
            this.btn_UserNew.Location = new System.Drawing.Point(17, 26);
            this.btn_UserNew.Name = "btn_UserNew";
            this.btn_UserNew.Size = new System.Drawing.Size(75, 23);
            this.btn_UserNew.TabIndex = 17;
            this.btn_UserNew.Text = "New";
            this.btn_UserNew.UseVisualStyleBackColor = true;
            // 
            // grb_UserSearch
            // 
            this.grb_UserSearch.Controls.Add(this.lbl_Permission);
            this.grb_UserSearch.Controls.Add(this.cmb_Permission);
            this.grb_UserSearch.Controls.Add(this.btn_UserSearch);
            this.grb_UserSearch.Controls.Add(this.lbl_Username);
            this.grb_UserSearch.Controls.Add(this.tbx_UserName);
            this.grb_UserSearch.Controls.Add(this.tbx_Email);
            this.grb_UserSearch.Controls.Add(this.lbl_Email);
            this.grb_UserSearch.Location = new System.Drawing.Point(12, 12);
            this.grb_UserSearch.Name = "grb_UserSearch";
            this.grb_UserSearch.Size = new System.Drawing.Size(202, 151);
            this.grb_UserSearch.TabIndex = 18;
            this.grb_UserSearch.TabStop = false;
            this.grb_UserSearch.Text = "Search users";
            // 
            // btn_UserSearch
            // 
            this.btn_UserSearch.Location = new System.Drawing.Point(109, 113);
            this.btn_UserSearch.Name = "btn_UserSearch";
            this.btn_UserSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_UserSearch.TabIndex = 19;
            this.btn_UserSearch.Text = "Search";
            this.btn_UserSearch.UseVisualStyleBackColor = true;
            this.btn_UserSearch.Click += new System.EventHandler(this.btn_UserSearch_Click);
            // 
            // grb_UserManage
            // 
            this.grb_UserManage.Controls.Add(this.btn_Cancel);
            this.grb_UserManage.Controls.Add(this.btn_UserModify);
            this.grb_UserManage.Controls.Add(this.btn_UserNew);
            this.grb_UserManage.Controls.Add(this.btn_UserDelete);
            this.grb_UserManage.Location = new System.Drawing.Point(220, 12);
            this.grb_UserManage.Name = "grb_UserManage";
            this.grb_UserManage.Size = new System.Drawing.Size(107, 151);
            this.grb_UserManage.TabIndex = 19;
            this.grb_UserManage.TabStop = false;
            this.grb_UserManage.Text = "Manage";
            // 
            // grb_UserResult
            // 
            this.grb_UserResult.Controls.Add(this.listBox1);
            this.grb_UserResult.Location = new System.Drawing.Point(14, 169);
            this.grb_UserResult.Name = "grb_UserResult";
            this.grb_UserResult.Size = new System.Drawing.Size(313, 214);
            this.grb_UserResult.TabIndex = 20;
            this.grb_UserResult.TabStop = false;
            this.grb_UserResult.Text = "Results";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 186);
            this.listBox1.TabIndex = 0;
            // 
            // cmb_Permission
            // 
            this.cmb_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Permission.FormattingEnabled = true;
            this.cmb_Permission.Location = new System.Drawing.Point(84, 50);
            this.cmb_Permission.Name = "cmb_Permission";
            this.cmb_Permission.Size = new System.Drawing.Size(100, 21);
            this.cmb_Permission.TabIndex = 20;
            // 
            // lbl_Permission
            // 
            this.lbl_Permission.AutoSize = true;
            this.lbl_Permission.Location = new System.Drawing.Point(16, 53);
            this.lbl_Permission.Name = "lbl_Permission";
            this.lbl_Permission.Size = new System.Drawing.Size(60, 13);
            this.lbl_Permission.TabIndex = 21;
            this.lbl_Permission.Text = "Permission:";
            // 
            // UserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(342, 418);
            this.Controls.Add(this.grb_UserResult);
            this.Controls.Add(this.grb_UserManage);
            this.Controls.Add(this.grb_UserSearch);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage users";
            this.Load += new System.EventHandler(this.UserMaintenance_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grb_UserSearch.ResumeLayout(false);
            this.grb_UserSearch.PerformLayout();
            this.grb_UserManage.ResumeLayout(false);
            this.grb_UserResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_UserModify;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_UserDelete;
        private System.Windows.Forms.Button btn_UserNew;
        private System.Windows.Forms.GroupBox grb_UserSearch;
        private System.Windows.Forms.Button btn_UserSearch;
        private System.Windows.Forms.GroupBox grb_UserManage;
        private System.Windows.Forms.GroupBox grb_UserResult;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmb_Permission;
        private System.Windows.Forms.Label lbl_Permission;
    }
}