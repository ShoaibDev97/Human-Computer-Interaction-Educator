namespace HCI_Educator
{
    partial class AdminForgotPassword
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForgotPassword));
            this.lblServiceNum = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.lblDisappeartxt = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSecondtxt = new System.Windows.Forms.Label();
            this.lblSendReq = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsernamePassword = new MetroFramework.Controls.MetroLink();
            this.lblReqTimedOut = new MetroFramework.Controls.MetroLabel();
            this.lblBacktoAdminLogin = new MetroFramework.Controls.MetroLink();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtServiceNum = new MetroFramework.Controls.MetroTextBox();
            this.lblEnterServiceNum = new System.Windows.Forms.Label();
            this.btnSendReq = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picTimeOut = new System.Windows.Forms.PictureBox();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.picBack = new HCI_Educator.CircularPictureBox();
            this.circularPictureBox1 = new HCI_Educator.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceNum
            // 
            this.lblServiceNum.AutoSize = true;
            this.lblServiceNum.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.lblServiceNum, BunifuAnimatorNS.DecorationType.None);
            this.lblServiceNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceNum.ForeColor = System.Drawing.Color.Red;
            this.lblServiceNum.Location = new System.Drawing.Point(176, 291);
            this.lblServiceNum.Name = "lblServiceNum";
            this.lblServiceNum.Size = new System.Drawing.Size(149, 17);
            this.lblServiceNum.TabIndex = 3;
            this.lblServiceNum.Text = "Invalid Service Number";
            this.lblServiceNum.Visible = false;
            // 
            // picWait
            // 
            this.picWait.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.animator1.SetDecoration(this.picWait, BunifuAnimatorNS.DecorationType.None);
            this.picWait.Image = ((System.Drawing.Image)(resources.GetObject("picWait.Image")));
            this.picWait.Location = new System.Drawing.Point(153, 385);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(182, 112);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWait.TabIndex = 4;
            this.picWait.TabStop = false;
            this.picWait.Visible = false;
            // 
            // lblDisappeartxt
            // 
            this.lblDisappeartxt.AutoSize = true;
            this.lblDisappeartxt.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblDisappeartxt, BunifuAnimatorNS.DecorationType.None);
            this.lblDisappeartxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisappeartxt.ForeColor = System.Drawing.Color.Red;
            this.lblDisappeartxt.Location = new System.Drawing.Point(109, 484);
            this.lblDisappeartxt.Name = "lblDisappeartxt";
            this.lblDisappeartxt.Size = new System.Drawing.Size(232, 15);
            this.lblDisappeartxt.TabIndex = 8;
            this.lblDisappeartxt.Text = "User Name and Password disappaer after";
            this.lblDisappeartxt.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(339, 484);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "5";
            this.lblTime.Visible = false;
            // 
            // lblSecondtxt
            // 
            this.lblSecondtxt.AutoSize = true;
            this.lblSecondtxt.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblSecondtxt, BunifuAnimatorNS.DecorationType.None);
            this.lblSecondtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondtxt.ForeColor = System.Drawing.Color.Red;
            this.lblSecondtxt.Location = new System.Drawing.Point(349, 484);
            this.lblSecondtxt.Name = "lblSecondtxt";
            this.lblSecondtxt.Size = new System.Drawing.Size(50, 15);
            this.lblSecondtxt.TabIndex = 10;
            this.lblSecondtxt.Text = "Seconds";
            this.lblSecondtxt.Visible = false;
            // 
            // lblSendReq
            // 
            this.lblSendReq.AutoSize = true;
            this.animator1.SetDecoration(this.lblSendReq, BunifuAnimatorNS.DecorationType.None);
            this.lblSendReq.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSendReq.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSendReq.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSendReq.Location = new System.Drawing.Point(125, 482);
            this.lblSendReq.Name = "lblSendReq";
            this.lblSendReq.Size = new System.Drawing.Size(234, 25);
            this.lblSendReq.TabIndex = 11;
            this.lblSendReq.Text = "Send your request again...";
            this.lblSendReq.UseCustomForeColor = true;
            this.lblSendReq.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblUsernamePassword
            // 
            this.animator1.SetDecoration(this.lblUsernamePassword, BunifuAnimatorNS.DecorationType.None);
            this.lblUsernamePassword.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblUsernamePassword.Location = new System.Drawing.Point(125, 399);
            this.lblUsernamePassword.Name = "lblUsernamePassword";
            this.lblUsernamePassword.Size = new System.Drawing.Size(235, 83);
            this.lblUsernamePassword.TabIndex = 12;
            this.lblUsernamePassword.Text = "User Name:- admin\r\nPassword:- abc123";
            this.lblUsernamePassword.UseSelectable = true;
            this.lblUsernamePassword.Visible = false;
            // 
            // lblReqTimedOut
            // 
            this.lblReqTimedOut.AutoSize = true;
            this.animator1.SetDecoration(this.lblReqTimedOut, BunifuAnimatorNS.DecorationType.None);
            this.lblReqTimedOut.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblReqTimedOut.ForeColor = System.Drawing.Color.Red;
            this.lblReqTimedOut.Location = new System.Drawing.Point(81, 507);
            this.lblReqTimedOut.Name = "lblReqTimedOut";
            this.lblReqTimedOut.Size = new System.Drawing.Size(318, 19);
            this.lblReqTimedOut.TabIndex = 13;
            this.lblReqTimedOut.Text = "Your Session has timeout for security purpose.";
            this.lblReqTimedOut.UseCustomForeColor = true;
            this.lblReqTimedOut.Visible = false;
            // 
            // lblBacktoAdminLogin
            // 
            this.lblBacktoAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lblBacktoAdminLogin, BunifuAnimatorNS.DecorationType.None);
            this.lblBacktoAdminLogin.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblBacktoAdminLogin.Location = new System.Drawing.Point(108, 570);
            this.lblBacktoAdminLogin.Name = "lblBacktoAdminLogin";
            this.lblBacktoAdminLogin.Size = new System.Drawing.Size(272, 23);
            this.lblBacktoAdminLogin.TabIndex = 56;
            this.lblBacktoAdminLogin.Text = "Back to Admin Login form... Click here";
            this.lblBacktoAdminLogin.UseSelectable = true;
            this.lblBacktoAdminLogin.Click += new System.EventHandler(this.LblBacktoAdminLogin_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 549);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(454, 15);
            this.bunifuSeparator1.TabIndex = 57;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtServiceNum
            // 
            this.txtServiceNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtServiceNum.CustomButton.Image = null;
            this.txtServiceNum.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtServiceNum.CustomButton.Name = "";
            this.txtServiceNum.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtServiceNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServiceNum.CustomButton.TabIndex = 1;
            this.txtServiceNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServiceNum.CustomButton.UseSelectable = true;
            this.txtServiceNum.CustomButton.Visible = false;
            this.animator1.SetDecoration(this.txtServiceNum, BunifuAnimatorNS.DecorationType.None);
            this.txtServiceNum.DisplayIcon = true;
            this.txtServiceNum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtServiceNum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtServiceNum.Lines = new string[0];
            this.txtServiceNum.Location = new System.Drawing.Point(107, 252);
            this.txtServiceNum.MaxLength = 8;
            this.txtServiceNum.Multiline = true;
            this.txtServiceNum.Name = "txtServiceNum";
            this.txtServiceNum.PasswordChar = '\0';
            this.txtServiceNum.PromptText = "Service Number";
            this.txtServiceNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServiceNum.SelectedText = "";
            this.txtServiceNum.SelectionLength = 0;
            this.txtServiceNum.SelectionStart = 0;
            this.txtServiceNum.ShortcutsEnabled = true;
            this.txtServiceNum.ShowClearButton = true;
            this.txtServiceNum.Size = new System.Drawing.Size(275, 39);
            this.txtServiceNum.TabIndex = 60;
            this.txtServiceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServiceNum.UseSelectable = true;
            this.txtServiceNum.WaterMark = "Service Number";
            this.txtServiceNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServiceNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceNum.TextChanged += new System.EventHandler(this.TxtServiceNum_TextChanged);
            this.txtServiceNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtServiceNum_KeyDown);
            this.txtServiceNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtServiceNum_KeyPress);
            // 
            // lblEnterServiceNum
            // 
            this.lblEnterServiceNum.AutoSize = true;
            this.animator1.SetDecoration(this.lblEnterServiceNum, BunifuAnimatorNS.DecorationType.None);
            this.lblEnterServiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterServiceNum.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblEnterServiceNum.Location = new System.Drawing.Point(112, 238);
            this.lblEnterServiceNum.Name = "lblEnterServiceNum";
            this.lblEnterServiceNum.Size = new System.Drawing.Size(95, 15);
            this.lblEnterServiceNum.TabIndex = 61;
            this.lblEnterServiceNum.Text = "Service Number";
            this.lblEnterServiceNum.Visible = false;
            // 
            // btnSendReq
            // 
            this.btnSendReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnSendReq, BunifuAnimatorNS.DecorationType.None);
            this.btnSendReq.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSendReq.Location = new System.Drawing.Point(139, 311);
            this.btnSendReq.Name = "btnSendReq";
            this.btnSendReq.Size = new System.Drawing.Size(209, 45);
            this.btnSendReq.TabIndex = 62;
            this.btnSendReq.Text = "Send Request";
            this.btnSendReq.UseSelectable = true;
            this.btnSendReq.Click += new System.EventHandler(this.BtnSendReq_Click);
            // 
            // pictureBox2
            // 
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(468, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // picTimeOut
            // 
            this.picTimeOut.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.picTimeOut, BunifuAnimatorNS.DecorationType.None);
            this.picTimeOut.Image = ((System.Drawing.Image)(resources.GetObject("picTimeOut.Image")));
            this.picTimeOut.Location = new System.Drawing.Point(170, 366);
            this.picTimeOut.Name = "picTimeOut";
            this.picTimeOut.Size = new System.Drawing.Size(142, 116);
            this.picTimeOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTimeOut.TabIndex = 65;
            this.picTimeOut.TabStop = false;
            this.picTimeOut.Visible = false;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation4;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.picBack, BunifuAnimatorNS.DecorationType.None);
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(78, 566);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 58;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.animator1.SetDecoration(this.circularPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(153, 63);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(182, 158);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
            // 
            // AdminForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.picTimeOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSendReq);
            this.Controls.Add(this.lblEnterServiceNum);
            this.Controls.Add(this.txtServiceNum);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblBacktoAdminLogin);
            this.Controls.Add(this.lblReqTimedOut);
            this.Controls.Add(this.lblUsernamePassword);
            this.Controls.Add(this.lblSendReq);
            this.Controls.Add(this.lblSecondtxt);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDisappeartxt);
            this.Controls.Add(this.picWait);
            this.Controls.Add(this.lblServiceNum);
            this.Controls.Add(this.circularPictureBox1);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AdminForgotPassword";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Admin Forgot Password";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AdminForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label lblServiceNum;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.Label lblDisappeartxt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSecondtxt;
        private MetroFramework.Controls.MetroLabel lblSendReq;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLink lblUsernamePassword;
        private MetroFramework.Controls.MetroLabel lblReqTimedOut;
        private MetroFramework.Controls.MetroLink lblBacktoAdminLogin;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private CircularPictureBox picBack;
        private MetroFramework.Controls.MetroTextBox txtServiceNum;
        private System.Windows.Forms.Label lblEnterServiceNum;
        private MetroFramework.Controls.MetroButton btnSendReq;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picTimeOut;
        private BunifuAnimatorNS.BunifuTransition animator1;
    }
}