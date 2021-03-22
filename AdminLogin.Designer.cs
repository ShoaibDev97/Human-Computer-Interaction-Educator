namespace HCI_Educator
{
    partial class AdminLogin
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.picShowpaswd = new System.Windows.Forms.PictureBox();
            this.picHidepswd = new System.Windows.Forms.PictureBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblForgotPswd = new MetroFramework.Controls.MetroLink();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblBacktoUserMode = new MetroFramework.Controls.MetroLink();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.picBack = new HCI_Educator.CircularPictureBox();
            this.circularPictureBox1 = new HCI_Educator.CircularPictureBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtUsername, BunifuAnimatorNS.DecorationType.None);
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(61, 308);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "User Name";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.ShowClearButton = true;
            this.txtUsername.Size = new System.Drawing.Size(372, 34);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "User Name";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsername_KeyDown);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsername_KeyPress);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtPassword, BunifuAnimatorNS.DecorationType.None);
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(61, 367);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(372, 34);
            this.txtPassword.TabIndex = 32;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // picShowpaswd
            // 
            this.animator1.SetDecoration(this.picShowpaswd, BunifuAnimatorNS.DecorationType.None);
            this.picShowpaswd.Image = ((System.Drawing.Image)(resources.GetObject("picShowpaswd.Image")));
            this.picShowpaswd.Location = new System.Drawing.Point(397, 369);
            this.picShowpaswd.Name = "picShowpaswd";
            this.picShowpaswd.Size = new System.Drawing.Size(30, 30);
            this.picShowpaswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowpaswd.TabIndex = 35;
            this.picShowpaswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picShowpaswd, "Show Password!");
            this.picShowpaswd.Click += new System.EventHandler(this.PicShowpaswd_Click);
            // 
            // picHidepswd
            // 
            this.animator1.SetDecoration(this.picHidepswd, BunifuAnimatorNS.DecorationType.None);
            this.picHidepswd.Image = ((System.Drawing.Image)(resources.GetObject("picHidepswd.Image")));
            this.picHidepswd.Location = new System.Drawing.Point(397, 369);
            this.picHidepswd.Name = "picHidepswd";
            this.picHidepswd.Size = new System.Drawing.Size(30, 30);
            this.picHidepswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidepswd.TabIndex = 34;
            this.picHidepswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picHidepswd, "Hide Password!");
            this.picHidepswd.Visible = false;
            this.picHidepswd.Click += new System.EventHandler(this.PicHidepswd_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnLogin, BunifuAnimatorNS.DecorationType.None);
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.Location = new System.Drawing.Point(155, 453);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 48);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblForgotPswd
            // 
            this.lblForgotPswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblForgotPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblForgotPswd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblForgotPswd.Location = new System.Drawing.Point(296, 405);
            this.lblForgotPswd.Name = "lblForgotPswd";
            this.lblForgotPswd.Size = new System.Drawing.Size(137, 26);
            this.lblForgotPswd.TabIndex = 37;
            this.lblForgotPswd.Text = "Forgot Password?";
            this.lblForgotPswd.UseSelectable = true;
            this.lblForgotPswd.Click += new System.EventHandler(this.LblForgotPswd_Click);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPswd.Location = new System.Drawing.Point(66, 353);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(61, 15);
            this.lblPswd.TabIndex = 33;
            this.lblPswd.Text = "Password";
            this.lblPswd.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblUserName, BunifuAnimatorNS.DecorationType.None);
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUserName.Location = new System.Drawing.Point(66, 294);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 15);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Visible = false;
            // 
            // lblBacktoUserMode
            // 
            this.lblBacktoUserMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblBacktoUserMode, BunifuAnimatorNS.DecorationType.None);
            this.lblBacktoUserMode.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblBacktoUserMode.Location = new System.Drawing.Point(123, 663);
            this.lblBacktoUserMode.Name = "lblBacktoUserMode";
            this.lblBacktoUserMode.Size = new System.Drawing.Size(272, 23);
            this.lblBacktoUserMode.TabIndex = 39;
            this.lblBacktoUserMode.Text = "Back to User Mode form... Click here";
            this.lblBacktoUserMode.UseSelectable = true;
            this.lblBacktoUserMode.Click += new System.EventHandler(this.LblBacktoUserMode_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 642);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(454, 15);
            this.bunifuSeparator1.TabIndex = 40;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picBack, BunifuAnimatorNS.DecorationType.None);
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(100, 659);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 59;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.animator1.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(138, 91);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(217, 186);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 38;
            this.circularPictureBox1.TabStop = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 696);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblBacktoUserMode);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.lblForgotPswd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picShowpaswd);
            this.Controls.Add(this.picHidepswd);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUsername);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AdminLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Admin Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.PictureBox picShowpaswd;
        private System.Windows.Forms.PictureBox picHidepswd;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lblForgotPswd;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblUserName;
        private CircularPictureBox circularPictureBox1;
        private MetroFramework.Controls.MetroLink lblBacktoUserMode;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CircularPictureBox picBack;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private BunifuAnimatorNS.BunifuTransition animator1;
    }
}