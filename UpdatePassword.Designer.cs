namespace HCI_Educator
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdatePassword = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPswd = new MetroFramework.Controls.MetroTextBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblConfirmPswd = new System.Windows.Forms.Label();
            this.chkQRpasscode = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProvider_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ConfirmPswd = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPasswordChar = new System.Windows.Forms.Label();
            this.picShowpaswd = new System.Windows.Forms.PictureBox();
            this.picHidepswd = new System.Windows.Forms.PictureBox();
            this.picTick = new HCI_Educator.CircularPictureBox();
            this.picCross = new HCI_Educator.CircularPictureBox();
            this.picMiniLoad = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnShowUserName = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturnMainMenu = new MetroFramework.Controls.MetroButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ConfirmPswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(167, 273);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(159, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Update Password";
            // 
            // btnUpdatePassword
            // 
            this.animator1.SetDecoration(this.btnUpdatePassword, BunifuAnimatorNS.DecorationType.None);
            this.btnUpdatePassword.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdatePassword.Location = new System.Drawing.Point(141, 572);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(228, 45);
            this.btnUpdatePassword.TabIndex = 4;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseSelectable = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.BtnUpdatePassword_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(341, 2);
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
            this.txtPassword.Location = new System.Drawing.Point(62, 422);
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
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(373, 34);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // txtConfirmPswd
            // 
            // 
            // 
            // 
            this.txtConfirmPswd.CustomButton.Image = null;
            this.txtConfirmPswd.CustomButton.Location = new System.Drawing.Point(341, 2);
            this.txtConfirmPswd.CustomButton.Name = "";
            this.txtConfirmPswd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtConfirmPswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPswd.CustomButton.TabIndex = 1;
            this.txtConfirmPswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPswd.CustomButton.UseSelectable = true;
            this.txtConfirmPswd.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtConfirmPswd, BunifuAnimatorNS.DecorationType.None);
            this.txtConfirmPswd.DisplayIcon = true;
            this.txtConfirmPswd.Enabled = false;
            this.txtConfirmPswd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtConfirmPswd.Icon = ((System.Drawing.Image)(resources.GetObject("txtConfirmPswd.Icon")));
            this.txtConfirmPswd.Lines = new string[0];
            this.txtConfirmPswd.Location = new System.Drawing.Point(62, 485);
            this.txtConfirmPswd.MaxLength = 32767;
            this.txtConfirmPswd.Multiline = true;
            this.txtConfirmPswd.Name = "txtConfirmPswd";
            this.txtConfirmPswd.PasswordChar = '*';
            this.txtConfirmPswd.PromptText = "Confirm Password";
            this.txtConfirmPswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPswd.SelectedText = "";
            this.txtConfirmPswd.SelectionLength = 0;
            this.txtConfirmPswd.SelectionStart = 0;
            this.txtConfirmPswd.ShortcutsEnabled = true;
            this.txtConfirmPswd.ShowClearButton = true;
            this.txtConfirmPswd.Size = new System.Drawing.Size(373, 34);
            this.txtConfirmPswd.TabIndex = 6;
            this.txtConfirmPswd.UseSelectable = true;
            this.txtConfirmPswd.WaterMark = "Confirm Password";
            this.txtConfirmPswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPswd.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPswd.TextChanged += new System.EventHandler(this.TxtConfirmPswd_TextChanged);
            this.txtConfirmPswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmPswd_KeyDown);
            this.txtConfirmPswd.Leave += new System.EventHandler(this.TxtConfirmPswd_Leave);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPswd.Location = new System.Drawing.Point(68, 408);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(61, 15);
            this.lblPswd.TabIndex = 32;
            this.lblPswd.Text = "Password";
            this.lblPswd.Visible = false;
            // 
            // lblConfirmPswd
            // 
            this.lblConfirmPswd.AutoSize = true;
            this.lblConfirmPswd.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblConfirmPswd, BunifuAnimatorNS.DecorationType.None);
            this.lblConfirmPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPswd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblConfirmPswd.Location = new System.Drawing.Point(67, 471);
            this.lblConfirmPswd.Name = "lblConfirmPswd";
            this.lblConfirmPswd.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPswd.TabIndex = 33;
            this.lblConfirmPswd.Text = "Confirm Password";
            this.lblConfirmPswd.Visible = false;
            // 
            // chkQRpasscode
            // 
            this.chkQRpasscode.AutoSize = true;
            this.chkQRpasscode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.chkQRpasscode, BunifuAnimatorNS.DecorationType.None);
            this.chkQRpasscode.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkQRpasscode.Location = new System.Drawing.Point(114, 524);
            this.chkQRpasscode.Name = "chkQRpasscode";
            this.chkQRpasscode.Size = new System.Drawing.Size(223, 25);
            this.chkQRpasscode.TabIndex = 34;
            this.chkQRpasscode.Text = "QR Verification Passcode";
            this.chkQRpasscode.UseSelectable = true;
            this.chkQRpasscode.CheckedChanged += new System.EventHandler(this.ChkQRpasscode_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(339, 524);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox2, "QR Verification Passcode\r\nGet your password with the help of QR, if you forgot");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(354, 532);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox3, "QR Verification Passcode\r\nGet your password with the help of QR, if you forgot");
            // 
            // errorProvider_Password
            // 
            this.errorProvider_Password.ContainerControl = this;
            // 
            // errorProvider_ConfirmPswd
            // 
            this.errorProvider_ConfirmPswd.ContainerControl = this;
            // 
            // lblPasswordChar
            // 
            this.lblPasswordChar.AutoSize = true;
            this.animator1.SetDecoration(this.lblPasswordChar, BunifuAnimatorNS.DecorationType.None);
            this.lblPasswordChar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordChar.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordChar.Location = new System.Drawing.Point(59, 460);
            this.lblPasswordChar.Name = "lblPasswordChar";
            this.lblPasswordChar.Size = new System.Drawing.Size(376, 13);
            this.lblPasswordChar.TabIndex = 73;
            this.lblPasswordChar.Text = "Your password must be at least 6 or 8 characters long. Please try another.";
            this.lblPasswordChar.Visible = false;
            // 
            // picShowpaswd
            // 
            this.picShowpaswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picShowpaswd, BunifuAnimatorNS.DecorationType.None);
            this.picShowpaswd.Image = ((System.Drawing.Image)(resources.GetObject("picShowpaswd.Image")));
            this.picShowpaswd.Location = new System.Drawing.Point(401, 424);
            this.picShowpaswd.Name = "picShowpaswd";
            this.picShowpaswd.Size = new System.Drawing.Size(30, 30);
            this.picShowpaswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowpaswd.TabIndex = 75;
            this.picShowpaswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picShowpaswd, "Show password!");
            this.picShowpaswd.Click += new System.EventHandler(this.PicShowpaswd_Click);
            // 
            // picHidepswd
            // 
            this.picHidepswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picHidepswd, BunifuAnimatorNS.DecorationType.None);
            this.picHidepswd.Image = ((System.Drawing.Image)(resources.GetObject("picHidepswd.Image")));
            this.picHidepswd.Location = new System.Drawing.Point(401, 424);
            this.picHidepswd.Name = "picHidepswd";
            this.picHidepswd.Size = new System.Drawing.Size(30, 30);
            this.picHidepswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHidepswd.TabIndex = 74;
            this.picHidepswd.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picHidepswd, "Hide password!");
            this.picHidepswd.Visible = false;
            this.picHidepswd.Click += new System.EventHandler(this.PicHidepswd_Click);
            // 
            // picTick
            // 
            this.animator1.SetDecoration(this.picTick, BunifuAnimatorNS.DecorationType.None);
            this.picTick.Image = ((System.Drawing.Image)(resources.GetObject("picTick.Image")));
            this.picTick.Location = new System.Drawing.Point(401, 488);
            this.picTick.Name = "picTick";
            this.picTick.Size = new System.Drawing.Size(28, 28);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTick.TabIndex = 72;
            this.picTick.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picTick, "Password match!");
            this.picTick.Visible = false;
            // 
            // picCross
            // 
            this.animator1.SetDecoration(this.picCross, BunifuAnimatorNS.DecorationType.None);
            this.picCross.Image = ((System.Drawing.Image)(resources.GetObject("picCross.Image")));
            this.picCross.Location = new System.Drawing.Point(401, 488);
            this.picCross.Name = "picCross";
            this.picCross.Size = new System.Drawing.Size(28, 28);
            this.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCross.TabIndex = 71;
            this.picCross.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picCross, "Password not match!");
            this.picCross.Visible = false;
            // 
            // picMiniLoad
            // 
            this.animator1.SetDecoration(this.picMiniLoad, BunifuAnimatorNS.DecorationType.None);
            this.picMiniLoad.Image = ((System.Drawing.Image)(resources.GetObject("picMiniLoad.Image")));
            this.picMiniLoad.Location = new System.Drawing.Point(236, 619);
            this.picMiniLoad.Name = "picMiniLoad";
            this.picMiniLoad.Size = new System.Drawing.Size(35, 15);
            this.picMiniLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMiniLoad.TabIndex = 76;
            this.picMiniLoad.TabStop = false;
            this.picMiniLoad.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.animator1.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.lblTime.Location = new System.Drawing.Point(277, 620);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 77;
            this.lblTime.Text = "3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel2, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel2.Location = new System.Drawing.Point(49, 306);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(390, 38);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "You must update your password because your previous password\r\n has been expired.";
            // 
            // pictureBox5
            // 
            this.animator1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(92, 357);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 83;
            this.pictureBox5.TabStop = false;
            // 
            // btnShowUserName
            // 
            this.btnShowUserName.ActiveBorderThickness = 1;
            this.btnShowUserName.ActiveCornerRadius = 20;
            this.btnShowUserName.ActiveFillColor = System.Drawing.Color.White;
            this.btnShowUserName.ActiveForecolor = System.Drawing.Color.Black;
            this.btnShowUserName.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnShowUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowUserName.BackgroundImage")));
            this.btnShowUserName.ButtonText = "ziafdc_kiet@yahoo.com";
            this.btnShowUserName.Cursor = System.Windows.Forms.Cursors.Help;
            this.animator1.SetDecoration(this.btnShowUserName, BunifuAnimatorNS.DecorationType.None);
            this.btnShowUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUserName.ForeColor = System.Drawing.Color.Black;
            this.btnShowUserName.IdleBorderThickness = 1;
            this.btnShowUserName.IdleCornerRadius = 20;
            this.btnShowUserName.IdleFillColor = System.Drawing.Color.White;
            this.btnShowUserName.IdleForecolor = System.Drawing.Color.Black;
            this.btnShowUserName.IdleLineColor = System.Drawing.Color.Silver;
            this.btnShowUserName.Location = new System.Drawing.Point(81, 349);
            this.btnShowUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowUserName.Name = "btnShowUserName";
            this.btnShowUserName.Size = new System.Drawing.Size(330, 39);
            this.btnShowUserName.TabIndex = 82;
            this.btnShowUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturnMainMenu);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.metroLabel3);
            this.animator1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 581);
            this.panel1.TabIndex = 84;
            this.panel1.Visible = false;
            // 
            // btnReturnMainMenu
            // 
            this.animator1.SetDecoration(this.btnReturnMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnReturnMainMenu.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReturnMainMenu.Location = new System.Drawing.Point(110, 284);
            this.btnReturnMainMenu.Name = "btnReturnMainMenu";
            this.btnReturnMainMenu.Size = new System.Drawing.Size(236, 45);
            this.btnReturnMainMenu.TabIndex = 5;
            this.btnReturnMainMenu.Text = "Return to Main Menu";
            this.btnReturnMainMenu.UseSelectable = true;
            // 
            // pictureBox7
            // 
            this.animator1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(181, 127);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel3, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(53, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(345, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Congrats, Password Updated Successfully.";
            // 
            // pictureBox4
            // 
            this.animator1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(468, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 28);
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
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
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.TimeStep = 0.01F;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 667);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnShowUserName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picMiniLoad);
            this.Controls.Add(this.picShowpaswd);
            this.Controls.Add(this.picHidepswd);
            this.Controls.Add(this.lblPasswordChar);
            this.Controls.Add(this.picTick);
            this.Controls.Add(this.picCross);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chkQRpasscode);
            this.Controls.Add(this.lblConfirmPswd);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.txtConfirmPswd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "UpdatePassword";
            this.Resizable = false;
            this.Text = "Account Security";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ConfirmPswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowpaswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidepswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnUpdatePassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtConfirmPswd;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblConfirmPswd;
        private MetroFramework.Controls.MetroCheckBox chkQRpasscode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CircularPictureBox picTick;
        private CircularPictureBox picCross;
        private System.Windows.Forms.ErrorProvider errorProvider_Password;
        private System.Windows.Forms.ErrorProvider errorProvider_ConfirmPswd;
        private System.Windows.Forms.Label lblPasswordChar;
        private System.Windows.Forms.PictureBox picShowpaswd;
        private System.Windows.Forms.PictureBox picHidepswd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picMiniLoad;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShowUserName;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private MetroFramework.Controls.MetroButton btnReturnMainMenu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private BunifuAnimatorNS.BunifuTransition animator1;
    }
}