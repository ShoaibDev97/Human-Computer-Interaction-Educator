namespace HCI_Educator
{
    partial class TwoStepVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoStepVerification));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.btnSecureAccount = new MetroFramework.Controls.MetroButton();
            this.picSecure = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSecureStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.lblCancelOrBack = new MetroFramework.Controls.MetroLink();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBack = new HCI_Educator.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(137, 374);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(248, 35);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.BackColor = System.Drawing.Color.Transparent;
            this.lblPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPswd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPswd.Location = new System.Drawing.Point(143, 359);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(68, 16);
            this.lblPswd.TabIndex = 31;
            this.lblPswd.Text = "Password";
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(252, 412);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(13, 13);
            this.lblSecretKey.TabIndex = 32;
            this.lblSecretKey.Text = "0";
            this.lblSecretKey.Visible = false;
            // 
            // btnSecureAccount
            // 
            this.btnSecureAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecureAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSecureAccount.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSecureAccount.Location = new System.Drawing.Point(159, 428);
            this.btnSecureAccount.Name = "btnSecureAccount";
            this.btnSecureAccount.Size = new System.Drawing.Size(210, 42);
            this.btnSecureAccount.TabIndex = 33;
            this.btnSecureAccount.Text = "Secure my Account";
            this.btnSecureAccount.UseSelectable = true;
            this.btnSecureAccount.Click += new System.EventHandler(this.BtnSecureAccount_Click);
            // 
            // picSecure
            // 
            this.picSecure.BackColor = System.Drawing.Color.Transparent;
            this.picSecure.Image = ((System.Drawing.Image)(resources.GetObject("picSecure.Image")));
            this.picSecure.Location = new System.Drawing.Point(211, 492);
            this.picSecure.Name = "picSecure";
            this.picSecure.Size = new System.Drawing.Size(96, 76);
            this.picSecure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecure.TabIndex = 34;
            this.picSecure.TabStop = false;
            this.picSecure.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblSecureStatus
            // 
            this.lblSecureStatus.AutoSize = true;
            this.lblSecureStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecureStatus.ForeColor = System.Drawing.Color.Green;
            this.lblSecureStatus.Location = new System.Drawing.Point(178, 571);
            this.lblSecureStatus.Name = "lblSecureStatus";
            this.lblSecureStatus.Size = new System.Drawing.Size(160, 34);
            this.lblSecureStatus.TabIndex = 35;
            this.lblSecureStatus.Text = "You are sucessfully done\r\n   Now you are secured ";
            this.lblSecureStatus.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(192, 529);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "?";
            this.lblTime.Visible = false;
            // 
            // picWait
            // 
            this.picWait.BackColor = System.Drawing.Color.Transparent;
            this.picWait.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picWait.Image = ((System.Drawing.Image)(resources.GetObject("picWait.Image")));
            this.picWait.Location = new System.Drawing.Point(211, 505);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(96, 91);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWait.TabIndex = 37;
            this.picWait.TabStop = false;
            this.picWait.Visible = false;
            // 
            // lblCancelOrBack
            // 
            this.lblCancelOrBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelOrBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblCancelOrBack.Location = new System.Drawing.Point(132, 676);
            this.lblCancelOrBack.Name = "lblCancelOrBack";
            this.lblCancelOrBack.Size = new System.Drawing.Size(299, 23);
            this.lblCancelOrBack.TabIndex = 61;
            this.lblCancelOrBack.Text = "Cancel Two Step Verification ... Click here";
            this.lblCancelOrBack.UseSelectable = true;
            this.lblCancelOrBack.Click += new System.EventHandler(this.LblCancelOrBack_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 655);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(469, 20);
            this.bunifuSeparator1.TabIndex = 60;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(484, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(102, 672);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 62;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // TwoStepVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 713);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lblCancelOrBack);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.picWait);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSecureStatus);
            this.Controls.Add(this.picSecure);
            this.Controls.Add(this.btnSecureAccount);
            this.Controls.Add(this.lblSecretKey);
            this.Controls.Add(this.lblPswd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "TwoStepVerification";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Two Step Verification";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblSecretKey;
        private MetroFramework.Controls.MetroButton btnSecureAccount;
        private System.Windows.Forms.PictureBox picSecure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSecureStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picWait;
        private CircularPictureBox picBack;
        private MetroFramework.Controls.MetroLink lblCancelOrBack;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}