namespace HCI_Educator
{
    partial class SecurityCode
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
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityCode));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEnterCode = new MetroFramework.Controls.MetroTextBox();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.lblInvalidCode = new System.Windows.Forms.Label();
            this.btnVerifyCode = new MetroFramework.Controls.MetroButton();
            this.lblInfoCode = new MetroFramework.Controls.MetroLink();
            this.lblVerified = new MetroFramework.Controls.MetroLabel();
            this.picVerify = new System.Windows.Forms.PictureBox();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.lblDidntReceive = new MetroFramework.Controls.MetroLabel();
            this.lblResendCode = new MetroFramework.Controls.MetroLink();
            this.lblBack = new MetroFramework.Controls.MetroLink();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblTryAnotherWay = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnShowUserName = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnShownUserName = new Bunifu.Framework.UI.BunifuThinButton2();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendEmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSendMsg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer1 = new System.Windows.Forms.Label();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.lblPleaseWait = new MetroFramework.Controls.MetroLabel();
            this.picBack = new HCI_Educator.CircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // txtEnterCode
            // 
            // 
            // 
            // 
            this.txtEnterCode.CustomButton.Image = null;
            this.txtEnterCode.CustomButton.Location = new System.Drawing.Point(199, 2);
            this.txtEnterCode.CustomButton.Name = "";
            this.txtEnterCode.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtEnterCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnterCode.CustomButton.TabIndex = 1;
            this.txtEnterCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnterCode.CustomButton.UseSelectable = true;
            this.txtEnterCode.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtEnterCode, BunifuAnimatorNS.DecorationType.None);
            this.txtEnterCode.DisplayIcon = true;
            this.txtEnterCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEnterCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtEnterCode.Icon = ((System.Drawing.Image)(resources.GetObject("txtEnterCode.Icon")));
            this.txtEnterCode.Lines = new string[0];
            this.txtEnterCode.Location = new System.Drawing.Point(137, 301);
            this.txtEnterCode.MaxLength = 32767;
            this.txtEnterCode.Multiline = true;
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PasswordChar = '\0';
            this.txtEnterCode.PromptText = "Enter the Code";
            this.txtEnterCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnterCode.SelectedText = "";
            this.txtEnterCode.SelectionLength = 0;
            this.txtEnterCode.SelectionStart = 0;
            this.txtEnterCode.ShortcutsEnabled = true;
            this.txtEnterCode.ShowClearButton = true;
            this.txtEnterCode.Size = new System.Drawing.Size(239, 42);
            this.txtEnterCode.TabIndex = 18;
            this.txtEnterCode.UseSelectable = true;
            this.txtEnterCode.WaterMark = "Enter the Code";
            this.txtEnterCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnterCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCode.TextChanged += new System.EventHandler(this.TxtEnterCode_TextChanged);
            this.txtEnterCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEnterCode_KeyDown);
            this.txtEnterCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnterCode_KeyPress);
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblEnterCode, BunifuAnimatorNS.DecorationType.None);
            this.lblEnterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEnterCode.Location = new System.Drawing.Point(144, 288);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(88, 15);
            this.lblEnterCode.TabIndex = 32;
            this.lblEnterCode.Text = "Enter the Code";
            this.lblEnterCode.Visible = false;
            // 
            // lblInvalidCode
            // 
            this.lblInvalidCode.AutoSize = true;
            this.animator1.SetDecoration(this.lblInvalidCode, BunifuAnimatorNS.DecorationType.None);
            this.lblInvalidCode.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCode.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCode.Location = new System.Drawing.Point(216, 346);
            this.lblInvalidCode.Name = "lblInvalidCode";
            this.lblInvalidCode.Size = new System.Drawing.Size(77, 15);
            this.lblInvalidCode.TabIndex = 33;
            this.lblInvalidCode.Text = "Invalid Code";
            this.lblInvalidCode.Visible = false;
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnVerifyCode, BunifuAnimatorNS.DecorationType.None);
            this.btnVerifyCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVerifyCode.Location = new System.Drawing.Point(137, 364);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(239, 50);
            this.btnVerifyCode.TabIndex = 34;
            this.btnVerifyCode.Text = "Verify Code";
            this.btnVerifyCode.UseSelectable = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.BtnVerifyCode_Click);
            // 
            // lblInfoCode
            // 
            this.animator1.SetDecoration(this.lblInfoCode, BunifuAnimatorNS.DecorationType.None);
            this.lblInfoCode.Location = new System.Drawing.Point(97, 420);
            this.lblInfoCode.Name = "lblInfoCode";
            this.lblInfoCode.Size = new System.Drawing.Size(333, 36);
            this.lblInfoCode.TabIndex = 35;
            this.lblInfoCode.Text = "Your verification code may take a few moments to arrive.\r\nDo not share this verif" +
    "ication code with anyone.";
            this.lblInfoCode.UseSelectable = true;
            // 
            // lblVerified
            // 
            this.lblVerified.AutoSize = true;
            this.animator1.SetDecoration(this.lblVerified, BunifuAnimatorNS.DecorationType.None);
            this.lblVerified.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVerified.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblVerified.Location = new System.Drawing.Point(179, 570);
            this.lblVerified.Name = "lblVerified";
            this.lblVerified.Size = new System.Drawing.Size(149, 19);
            this.lblVerified.TabIndex = 37;
            this.lblVerified.Text = "Your Code is verified";
            this.lblVerified.UseCustomForeColor = true;
            this.lblVerified.Visible = false;
            // 
            // picVerify
            // 
            this.animator1.SetDecoration(this.picVerify, BunifuAnimatorNS.DecorationType.None);
            this.picVerify.Image = ((System.Drawing.Image)(resources.GetObject("picVerify.Image")));
            this.picVerify.Location = new System.Drawing.Point(23, 477);
            this.picVerify.Name = "picVerify";
            this.picVerify.Size = new System.Drawing.Size(462, 103);
            this.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVerify.TabIndex = 36;
            this.picVerify.TabStop = false;
            this.picVerify.Visible = false;
            // 
            // picWait
            // 
            this.picWait.BackColor = System.Drawing.Color.Transparent;
            this.picWait.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.picWait, BunifuAnimatorNS.DecorationType.None);
            this.picWait.Image = ((System.Drawing.Image)(resources.GetObject("picWait.Image")));
            this.picWait.Location = new System.Drawing.Point(23, 477);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(462, 103);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWait.TabIndex = 38;
            this.picWait.TabStop = false;
            this.picWait.Visible = false;
            // 
            // lblDidntReceive
            // 
            this.lblDidntReceive.AutoSize = true;
            this.animator1.SetDecoration(this.lblDidntReceive, BunifuAnimatorNS.DecorationType.None);
            this.lblDidntReceive.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDidntReceive.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDidntReceive.Location = new System.Drawing.Point(126, 457);
            this.lblDidntReceive.Name = "lblDidntReceive";
            this.lblDidntReceive.Size = new System.Drawing.Size(187, 15);
            this.lblDidntReceive.TabIndex = 39;
            this.lblDidntReceive.Text = "Didn\'t receive a verification code? ";
            // 
            // lblResendCode
            // 
            this.lblResendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblResendCode, BunifuAnimatorNS.DecorationType.None);
            this.lblResendCode.Location = new System.Drawing.Point(309, 455);
            this.lblResendCode.Name = "lblResendCode";
            this.lblResendCode.Size = new System.Drawing.Size(85, 19);
            this.lblResendCode.TabIndex = 40;
            this.lblResendCode.Text = "Resend Code";
            this.lblResendCode.UseSelectable = true;
            this.lblResendCode.Click += new System.EventHandler(this.LblResendCode_Click);
            // 
            // lblBack
            // 
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblBack, BunifuAnimatorNS.DecorationType.None);
            this.lblBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblBack.Location = new System.Drawing.Point(170, 661);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(197, 23);
            this.lblBack.TabIndex = 64;
            this.lblBack.Text = "Back to Sign in ... Click here";
            this.lblBack.UseSelectable = true;
            this.lblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 641);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(462, 20);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblTryAnotherWay
            // 
            this.lblTryAnotherWay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblTryAnotherWay, BunifuAnimatorNS.DecorationType.None);
            this.lblTryAnotherWay.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblTryAnotherWay.Location = new System.Drawing.Point(137, 604);
            this.lblTryAnotherWay.Name = "lblTryAnotherWay";
            this.lblTryAnotherWay.Size = new System.Drawing.Size(239, 31);
            this.lblTryAnotherWay.TabIndex = 66;
            this.lblTryAnotherWay.Text = "Try another way";
            this.lblTryAnotherWay.UseSelectable = true;
            this.lblTryAnotherWay.Click += new System.EventHandler(this.LblTryAnotherWay_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel2, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(100, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(324, 19);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "This extra step shows it’s really you trying to sign in";
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
            this.btnShowUserName.ButtonText = "User Name";
            this.btnShowUserName.Cursor = System.Windows.Forms.Cursors.Help;
            this.animator1.SetDecoration(this.btnShowUserName, BunifuAnimatorNS.DecorationType.None);
            this.btnShowUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUserName.ForeColor = System.Drawing.Color.Black;
            this.btnShowUserName.IdleBorderThickness = 1;
            this.btnShowUserName.IdleCornerRadius = 20;
            this.btnShowUserName.IdleFillColor = System.Drawing.Color.White;
            this.btnShowUserName.IdleForecolor = System.Drawing.Color.Black;
            this.btnShowUserName.IdleLineColor = System.Drawing.Color.Silver;
            this.btnShowUserName.Location = new System.Drawing.Point(100, 221);
            this.btnShowUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowUserName.Name = "btnShowUserName";
            this.btnShowUserName.Size = new System.Drawing.Size(330, 39);
            this.btnShowUserName.TabIndex = 68;
            this.btnShowUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.animator1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(111, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.pictureBox5);
            this.panelOptions.Controls.Add(this.btnShownUserName);
            this.panelOptions.Controls.Add(this.metroLabel5);
            this.panelOptions.Controls.Add(this.label2);
            this.panelOptions.Controls.Add(this.btnSendEmail);
            this.panelOptions.Controls.Add(this.btnSendMsg);
            this.panelOptions.Controls.Add(this.metroLabel4);
            this.panelOptions.Controls.Add(this.pictureBox4);
            this.animator1.SetDecoration(this.panelOptions, BunifuAnimatorNS.DecorationType.None);
            this.panelOptions.Location = new System.Drawing.Point(23, 63);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(469, 572);
            this.panelOptions.TabIndex = 73;
            this.panelOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOptions_Paint);
            // 
            // pictureBox5
            // 
            this.animator1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(88, 166);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // btnShownUserName
            // 
            this.btnShownUserName.ActiveBorderThickness = 1;
            this.btnShownUserName.ActiveCornerRadius = 20;
            this.btnShownUserName.ActiveFillColor = System.Drawing.Color.White;
            this.btnShownUserName.ActiveForecolor = System.Drawing.Color.Black;
            this.btnShownUserName.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnShownUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShownUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShownUserName.BackgroundImage")));
            this.btnShownUserName.ButtonText = "User Name";
            this.btnShownUserName.Cursor = System.Windows.Forms.Cursors.Help;
            this.animator1.SetDecoration(this.btnShownUserName, BunifuAnimatorNS.DecorationType.None);
            this.btnShownUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShownUserName.ForeColor = System.Drawing.Color.Black;
            this.btnShownUserName.IdleBorderThickness = 1;
            this.btnShownUserName.IdleCornerRadius = 20;
            this.btnShownUserName.IdleFillColor = System.Drawing.Color.White;
            this.btnShownUserName.IdleForecolor = System.Drawing.Color.Black;
            this.btnShownUserName.IdleLineColor = System.Drawing.Color.Silver;
            this.btnShownUserName.Location = new System.Drawing.Point(77, 158);
            this.btnShownUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShownUserName.Name = "btnShownUserName";
            this.btnShownUserName.Size = new System.Drawing.Size(330, 39);
            this.btnShownUserName.TabIndex = 80;
            this.btnShownUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel5, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(77, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(324, 19);
            this.metroLabel5.TabIndex = 79;
            this.metroLabel5.Text = "This extra step shows it’s really you trying to sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(122, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Messaging and Data Rates may apply";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Activecolor = System.Drawing.Color.White;
            this.btnSendEmail.BackColor = System.Drawing.Color.White;
            this.btnSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendEmail.BorderRadius = 5;
            this.btnSendEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSendEmail.ButtonText = "Send as a Email";
            this.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnSendEmail, BunifuAnimatorNS.DecorationType.None);
            this.btnSendEmail.DisabledColor = System.Drawing.Color.Gray;
            this.btnSendEmail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSendEmail.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.Iconimage")));
            this.btnSendEmail.Iconimage_right = null;
            this.btnSendEmail.Iconimage_right_Selected = null;
            this.btnSendEmail.Iconimage_Selected = null;
            this.btnSendEmail.IconMarginLeft = 0;
            this.btnSendEmail.IconMarginRight = 0;
            this.btnSendEmail.IconRightVisible = true;
            this.btnSendEmail.IconRightZoom = 0D;
            this.btnSendEmail.IconVisible = true;
            this.btnSendEmail.IconZoom = 60D;
            this.btnSendEmail.IsTab = false;
            this.btnSendEmail.Location = new System.Drawing.Point(66, 427);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Normalcolor = System.Drawing.Color.White;
            this.btnSendEmail.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.btnSendEmail.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSendEmail.selected = false;
            this.btnSendEmail.Size = new System.Drawing.Size(341, 71);
            this.btnSendEmail.TabIndex = 74;
            this.btnSendEmail.Text = "Send as a Email";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendEmail.Textcolor = System.Drawing.Color.Black;
            this.btnSendEmail.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Click += new System.EventHandler(this.BtnSendEmail_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Activecolor = System.Drawing.Color.White;
            this.btnSendMsg.BackColor = System.Drawing.Color.White;
            this.btnSendMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMsg.BorderRadius = 5;
            this.btnSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSendMsg.ButtonText = "Send as a text message";
            this.btnSendMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnSendMsg, BunifuAnimatorNS.DecorationType.None);
            this.btnSendMsg.DisabledColor = System.Drawing.Color.Gray;
            this.btnSendMsg.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSendMsg.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSendMsg.Iconimage")));
            this.btnSendMsg.Iconimage_right = null;
            this.btnSendMsg.Iconimage_right_Selected = null;
            this.btnSendMsg.Iconimage_Selected = null;
            this.btnSendMsg.IconMarginLeft = 0;
            this.btnSendMsg.IconMarginRight = 0;
            this.btnSendMsg.IconRightVisible = true;
            this.btnSendMsg.IconRightZoom = 0D;
            this.btnSendMsg.IconVisible = true;
            this.btnSendMsg.IconZoom = 60D;
            this.btnSendMsg.IsTab = false;
            this.btnSendMsg.Location = new System.Drawing.Point(66, 320);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Normalcolor = System.Drawing.Color.White;
            this.btnSendMsg.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.btnSendMsg.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSendMsg.selected = false;
            this.btnSendMsg.Size = new System.Drawing.Size(341, 71);
            this.btnSendMsg.TabIndex = 73;
            this.btnSendMsg.Text = "Send as a text message";
            this.btnSendMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendMsg.Textcolor = System.Drawing.Color.Black;
            this.btnSendMsg.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMsg.Click += new System.EventHandler(this.BtnSendMsg_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.animator1.SetDecoration(this.metroLabel4, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(-3, 251);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(475, 50);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "      We haven seen that you used Two Step Verification.\r\nChoose a method below t" +
    "o verify that this is your account.";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(462, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // lblTimer1
            // 
            this.lblTimer1.AutoSize = true;
            this.animator1.SetDecoration(this.lblTimer1, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer1.Location = new System.Drawing.Point(23, 262);
            this.lblTimer1.Name = "lblTimer1";
            this.lblTimer1.Size = new System.Drawing.Size(13, 13);
            this.lblTimer1.TabIndex = 74;
            this.lblTimer1.Text = "5";
            this.lblTimer1.Visible = false;
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.animator1.SetDecoration(this.lblTimer2, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer2.Location = new System.Drawing.Point(23, 278);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(13, 13);
            this.lblTimer2.TabIndex = 75;
            this.lblTimer2.Text = "8";
            this.lblTimer2.Visible = false;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.animator1.SetDecoration(this.lblPleaseWait, BunifuAnimatorNS.DecorationType.None);
            this.lblPleaseWait.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPleaseWait.Location = new System.Drawing.Point(212, 570);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(86, 19);
            this.lblPleaseWait.TabIndex = 76;
            this.lblPleaseWait.Text = "Please Wait";
            this.lblPleaseWait.Visible = false;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picBack, BunifuAnimatorNS.DecorationType.None);
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(126, 658);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 65;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(484, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation8;
            this.animator1.TimeStep = 0.01F;
            // 
            // SecurityCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPleaseWait);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer1);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnShowUserName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblTryAnotherWay);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblResendCode);
            this.Controls.Add(this.lblDidntReceive);
            this.Controls.Add(this.picWait);
            this.Controls.Add(this.lblVerified);
            this.Controls.Add(this.picVerify);
            this.Controls.Add(this.lblInfoCode);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.lblInvalidCode);
            this.Controls.Add(this.lblEnterCode);
            this.Controls.Add(this.txtEnterCode);
            this.Controls.Add(this.pictureBox2);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "SecurityCode";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Account Security";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecurityCode_FormClosing);
            this.Load += new System.EventHandler(this.SecurityCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtEnterCode;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.Label lblInvalidCode;
        private MetroFramework.Controls.MetroButton btnVerifyCode;
        private MetroFramework.Controls.MetroLink lblInfoCode;
        private MetroFramework.Controls.MetroLabel lblVerified;
        private System.Windows.Forms.PictureBox picVerify;
        private System.Windows.Forms.PictureBox picWait;
        private MetroFramework.Controls.MetroLabel lblDidntReceive;
        private CircularPictureBox picBack;
        private MetroFramework.Controls.MetroLink lblBack;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLink lblTryAnotherWay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShowUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLink lblResendCode;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShownUserName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSendEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnSendMsg;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimer1;
        private System.Windows.Forms.Label lblTimer2;
        private MetroFramework.Controls.MetroLabel lblPleaseWait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition animator1;
    }
}