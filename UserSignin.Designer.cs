namespace HCI_Educator
{
    partial class UserSignin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignin));
            this.lblForgotPswd = new MetroFramework.Controls.MetroLink();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.picShowpaswd = new System.Windows.Forms.PictureBox();
            this.picHidepswd = new System.Windows.Forms.PictureBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lblCreateAccount = new MetroFramework.Controls.MetroLink();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblBacktoUserMode = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGetQRpasscode = new MetroFramework.Controls.MetroLink();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime1 = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.lblWait = new MetroFramework.Controls.MetroLabel();
            this.lblDone = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.picQRcode = new HCI_Educator.CircularPictureBox();
            this.picBack = new HCI_Educator.CircularPictureBox();
            this.circularPictureBox1 = new HCI_Educator.CircularPictureBox();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPswd
            // 
            this.lblForgotPswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblForgotPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblForgotPswd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblForgotPswd.Location = new System.Drawing.Point(298, 390);
            this.lblForgotPswd.Name = "lblForgotPswd";
            this.lblForgotPswd.Size = new System.Drawing.Size(131, 26);
            this.lblForgotPswd.TabIndex = 46;
            this.lblForgotPswd.Text = "Forgot Password?";
            this.lblForgotPswd.UseSelectable = true;
            this.lblForgotPswd.Click += new System.EventHandler(this.LblForgotPswd_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnLogin, BunifuAnimatorNS.DecorationType.None);
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.Location = new System.Drawing.Point(155, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 48);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // picShowpaswd
            // 
            this.animator1.SetDecoration(this.picShowpaswd, BunifuAnimatorNS.DecorationType.None);
            this.picShowpaswd.Image = ((System.Drawing.Image)(resources.GetObject("picShowpaswd.Image")));
            this.picShowpaswd.Location = new System.Drawing.Point(391, 356);
            this.picShowpaswd.Name = "picShowpaswd";
            this.picShowpaswd.Size = new System.Drawing.Size(30, 30);
            this.picShowpaswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowpaswd.TabIndex = 44;
            this.picShowpaswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picShowpaswd, "Show password!");
            this.picShowpaswd.Click += new System.EventHandler(this.PicShowpaswd_Click);
            // 
            // picHidepswd
            // 
            this.animator1.SetDecoration(this.picHidepswd, BunifuAnimatorNS.DecorationType.None);
            this.picHidepswd.Image = ((System.Drawing.Image)(resources.GetObject("picHidepswd.Image")));
            this.picHidepswd.Location = new System.Drawing.Point(391, 356);
            this.picHidepswd.Name = "picHidepswd";
            this.picHidepswd.Size = new System.Drawing.Size(30, 30);
            this.picHidepswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidepswd.TabIndex = 43;
            this.picHidepswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picHidepswd, "Hide password!");
            this.picHidepswd.Visible = false;
            this.picHidepswd.Click += new System.EventHandler(this.PicHidepswd_Click);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPswd.Location = new System.Drawing.Point(81, 342);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(61, 15);
            this.lblPswd.TabIndex = 42;
            this.lblPswd.Text = "Password";
            this.lblPswd.Visible = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(316, 2);
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
            this.txtPassword.Location = new System.Drawing.Point(77, 354);
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
            this.txtPassword.Size = new System.Drawing.Size(348, 34);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblUserName, BunifuAnimatorNS.DecorationType.None);
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUserName.Location = new System.Drawing.Point(81, 282);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 15);
            this.lblUserName.TabIndex = 40;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(316, 2);
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
            this.txtUsername.Location = new System.Drawing.Point(77, 295);
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
            this.txtUsername.Size = new System.Drawing.Size(348, 34);
            this.txtUsername.TabIndex = 39;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "User Name";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsername_KeyDown);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblCreateAccount, BunifuAnimatorNS.DecorationType.None);
            this.lblCreateAccount.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblCreateAccount.Location = new System.Drawing.Point(264, 609);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(144, 23);
            this.lblCreateAccount.TabIndex = 49;
            this.lblCreateAccount.Text = "Create an Account!";
            this.lblCreateAccount.UseSelectable = true;
            this.lblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 639);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(454, 20);
            this.bunifuSeparator1.TabIndex = 50;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblBacktoUserMode
            // 
            this.lblBacktoUserMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblBacktoUserMode, BunifuAnimatorNS.DecorationType.None);
            this.lblBacktoUserMode.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblBacktoUserMode.Location = new System.Drawing.Point(124, 665);
            this.lblBacktoUserMode.Name = "lblBacktoUserMode";
            this.lblBacktoUserMode.Size = new System.Drawing.Size(272, 23);
            this.lblBacktoUserMode.TabIndex = 51;
            this.lblBacktoUserMode.Text = "Back to User Mode form... Click here";
            this.lblBacktoUserMode.UseSelectable = true;
            this.lblBacktoUserMode.Click += new System.EventHandler(this.LblBacktoUserMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Don\'t have an account?";
            // 
            // lblGetQRpasscode
            // 
            this.lblGetQRpasscode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblGetQRpasscode, BunifuAnimatorNS.DecorationType.None);
            this.lblGetQRpasscode.Location = new System.Drawing.Point(77, 390);
            this.lblGetQRpasscode.Name = "lblGetQRpasscode";
            this.lblGetQRpasscode.Size = new System.Drawing.Size(186, 21);
            this.lblGetQRpasscode.TabIndex = 60;
            this.lblGetQRpasscode.Text = "Get Password using QRpasscode";
            this.lblGetQRpasscode.UseSelectable = true;
            this.lblGetQRpasscode.Click += new System.EventHandler(this.LblGetQRpasscode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.animator1.SetDecoration(this.lblTime1, BunifuAnimatorNS.DecorationType.None);
            this.lblTime1.Location = new System.Drawing.Point(395, 131);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(13, 13);
            this.lblTime1.TabIndex = 62;
            this.lblTime1.Text = "?";
            this.lblTime1.Visible = false;
            // 
            // picWait
            // 
            this.picWait.BackColor = System.Drawing.Color.Transparent;
            this.picWait.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.picWait, BunifuAnimatorNS.DecorationType.None);
            this.picWait.Image = ((System.Drawing.Image)(resources.GetObject("picWait.Image")));
            this.picWait.Location = new System.Drawing.Point(173, 96);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(148, 127);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWait.TabIndex = 63;
            this.picWait.TabStop = false;
            this.picWait.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.animator1.SetDecoration(this.lblTimer2, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer2.Location = new System.Drawing.Point(395, 161);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(13, 13);
            this.lblTimer2.TabIndex = 64;
            this.lblTimer2.Text = "?";
            this.lblTimer2.Visible = false;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.animator1.SetDecoration(this.lblWait, BunifuAnimatorNS.DecorationType.None);
            this.lblWait.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWait.Location = new System.Drawing.Point(161, 226);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(175, 19);
            this.lblWait.TabIndex = 65;
            this.lblWait.Text = "Please wait for few seconds";
            this.lblWait.Visible = false;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.animator1.SetDecoration(this.lblDone, BunifuAnimatorNS.DecorationType.None);
            this.lblDone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDone.Location = new System.Drawing.Point(224, 226);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(46, 19);
            this.lblDone.TabIndex = 66;
            this.lblDone.Text = "Done!";
            this.lblDone.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(53, 492);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(399, 20);
            this.bunifuSeparator2.TabIndex = 67;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // metroLink1
            // 
            this.animator1.SetDecoration(this.metroLink1, BunifuAnimatorNS.DecorationType.None);
            this.metroLink1.Location = new System.Drawing.Point(231, 492);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(39, 23);
            this.metroLink1.TabIndex = 68;
            this.metroLink1.Text = "OR";
            this.metroLink1.UseSelectable = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(124, 546);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 69;
            this.bunifuImageButton1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.bunifuImageButton1, "Google");
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.ErrorImage = null;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.InitialImage = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(264, 546);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 70;
            this.bunifuImageButton2.TabStop = false;
            this.metroToolTip1.SetToolTip(this.bunifuImageButton2, "Linkedin");
            this.bunifuImageButton2.Visible = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.ErrorImage = null;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.InitialImage = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(193, 546);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 71;
            this.bunifuImageButton3.TabStop = false;
            this.metroToolTip1.SetToolTip(this.bunifuImageButton3, "Facebook");
            this.bunifuImageButton3.Visible = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.ErrorImage = null;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.InitialImage = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(333, 546);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 72;
            this.bunifuImageButton4.TabStop = false;
            this.metroToolTip1.SetToolTip(this.bunifuImageButton4, "Twitter");
            this.bunifuImageButton4.Visible = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // metroLink2
            // 
            this.animator1.SetDecoration(this.metroLink2, BunifuAnimatorNS.DecorationType.None);
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.Location = new System.Drawing.Point(179, 515);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(148, 25);
            this.metroLink2.TabIndex = 73;
            this.metroLink2.Text = "Login with...";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // picQRcode
            // 
            this.picQRcode.BackColor = System.Drawing.Color.Lavender;
            this.animator1.SetDecoration(this.picQRcode, BunifuAnimatorNS.DecorationType.None);
            this.picQRcode.Location = new System.Drawing.Point(138, 66);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(217, 193);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRcode.TabIndex = 61;
            this.picQRcode.TabStop = false;
            this.picQRcode.Visible = false;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picBack, BunifuAnimatorNS.DecorationType.None);
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(91, 661);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 59;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.animator1.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(138, 66);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(217, 193);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 47;
            this.circularPictureBox1.TabStop = false;
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
            // UserSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 696);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.picWait);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.picQRcode);
            this.Controls.Add(this.lblGetQRpasscode);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBacktoUserMode);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCreateAccount);
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
            this.Name = "UserSignin";
            this.Resizable = false;
            this.Text = "UserSignin";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSignin_FormClosing);
            this.Load += new System.EventHandler(this.UserSignin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lblForgotPswd;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.PictureBox picShowpaswd;
        private System.Windows.Forms.PictureBox picHidepswd;
        private System.Windows.Forms.Label lblPswd;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private CircularPictureBox circularPictureBox1;
        private MetroFramework.Controls.MetroLink lblCreateAccount;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLink lblBacktoUserMode;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox picBack;
        private MetroFramework.Controls.MetroLink lblGetQRpasscode;
        private CircularPictureBox picQRcode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimer2;
        private MetroFramework.Controls.MetroLabel lblWait;
        private MetroFramework.Controls.MetroLabel lblDone;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private BunifuAnimatorNS.BunifuTransition animator1;
    }
}