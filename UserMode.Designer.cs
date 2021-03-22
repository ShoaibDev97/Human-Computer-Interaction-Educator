namespace HCI_Educator
{
    partial class UserMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMode));
            this.btnAdminInfo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUserInfo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdmin = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminInfo
            // 
            this.btnAdminInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAdminInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminInfo.Image")));
            this.btnAdminInfo.ImageActive = null;
            this.btnAdminInfo.Location = new System.Drawing.Point(155, 82);
            this.btnAdminInfo.Name = "btnAdminInfo";
            this.btnAdminInfo.Size = new System.Drawing.Size(176, 130);
            this.btnAdminInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdminInfo.TabIndex = 2;
            this.btnAdminInfo.TabStop = false;
            this.btnAdminInfo.Zoom = 10;
            this.btnAdminInfo.MouseLeave += new System.EventHandler(this.BtnAdminInfo_MouseLeave);
            this.btnAdminInfo.MouseHover += new System.EventHandler(this.BtnAdminInfo_MouseHover);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.ImageActive = null;
            this.btnUserInfo.Location = new System.Drawing.Point(155, 367);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(176, 130);
            this.btnUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUserInfo.TabIndex = 4;
            this.btnUserInfo.TabStop = false;
            this.btnUserInfo.Zoom = 10;
            this.btnUserInfo.MouseLeave += new System.EventHandler(this.BtnUserInfo_MouseLeave);
            this.btnUserInfo.MouseHover += new System.EventHandler(this.BtnUserInfo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "A system administrator, or sysadmin, is a person who is responsible for\r\nthe upke" +
    "ep, configuration, and reliable operation of computer \r\nsystems; especially mult" +
    "i-user computers, such as servers.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(27, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 76);
            this.label2.TabIndex = 9;
            this.label2.Text = "A user is a person who utilizes a computer or network service.\r\nUsers of computer" +
    "systems and software products generally lack\r\nthe technical expertise required t" +
    "o fully understand how they \r\nwork.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdmin.Location = new System.Drawing.Point(155, 218);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(176, 40);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseSelectable = true;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUser.Location = new System.Drawing.Point(155, 503);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(176, 40);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "User";
            this.btnUser.UseSelectable = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // UserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 696);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnAdminInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "UserMode";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "User Mode";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMode_FormClosing);
            this.Load += new System.EventHandler(this.UserMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnAdminInfo;
        private Bunifu.Framework.UI.BunifuImageButton btnUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnAdmin;
        private MetroFramework.Controls.MetroButton btnUser;
    }
}