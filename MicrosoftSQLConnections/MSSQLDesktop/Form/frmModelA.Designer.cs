namespace MSSQLDesktop
{
    partial class frmModelA
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
            this.grpModelA = new System.Windows.Forms.GroupBox();
            this.pnlModelServerLogin = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBtnShowHideAndBtnOnOff = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.cboConnectTimeout = new System.Windows.Forms.ComboBox();
            this.rbtSQLServer = new System.Windows.Forms.RadioButton();
            this.rbtWindowsLocal = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDataInitialCatalog = new System.Windows.Forms.TextBox();
            this.txtServerDataSource = new System.Windows.Forms.TextBox();
            this.lblConnectTimeout = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblDataInitialCatalog = new System.Windows.Forms.Label();
            this.lblServerDataSource = new System.Windows.Forms.Label();
            this.grpModelA.SuspendLayout();
            this.pnlModelServerLogin.SuspendLayout();
            this.pnlBtnShowHideAndBtnOnOff.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModelA
            // 
            this.grpModelA.Controls.Add(this.pnlModelServerLogin);
            this.grpModelA.Location = new System.Drawing.Point(12, 12);
            this.grpModelA.Name = "grpModelA";
            this.grpModelA.Size = new System.Drawing.Size(284, 213);
            this.grpModelA.TabIndex = 0;
            this.grpModelA.TabStop = false;
            this.grpModelA.Text = "SQL Connection Model A";
            // 
            // pnlModelServerLogin
            // 
            this.pnlModelServerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModelServerLogin.Controls.Add(this.btnConnect);
            this.pnlModelServerLogin.Controls.Add(this.btnClose);
            this.pnlModelServerLogin.Controls.Add(this.pnlBtnShowHideAndBtnOnOff);
            this.pnlModelServerLogin.Controls.Add(this.cboConnectTimeout);
            this.pnlModelServerLogin.Controls.Add(this.rbtSQLServer);
            this.pnlModelServerLogin.Controls.Add(this.rbtWindowsLocal);
            this.pnlModelServerLogin.Controls.Add(this.txtPassword);
            this.pnlModelServerLogin.Controls.Add(this.txtUserID);
            this.pnlModelServerLogin.Controls.Add(this.txtDataInitialCatalog);
            this.pnlModelServerLogin.Controls.Add(this.txtServerDataSource);
            this.pnlModelServerLogin.Controls.Add(this.lblConnectTimeout);
            this.pnlModelServerLogin.Controls.Add(this.lblPassword);
            this.pnlModelServerLogin.Controls.Add(this.lblUserID);
            this.pnlModelServerLogin.Controls.Add(this.lblDataInitialCatalog);
            this.pnlModelServerLogin.Controls.Add(this.lblServerDataSource);
            this.pnlModelServerLogin.Location = new System.Drawing.Point(6, 19);
            this.pnlModelServerLogin.Name = "pnlModelServerLogin";
            this.pnlModelServerLogin.Size = new System.Drawing.Size(272, 187);
            this.pnlModelServerLogin.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 157);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(187, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Tag = "2";
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Tag = "2";
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlBtnShowHideAndBtnOnOff
            // 
            this.pnlBtnShowHideAndBtnOnOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtnShowHideAndBtnOnOff.Controls.Add(this.btnShowHide);
            this.pnlBtnShowHideAndBtnOnOff.Controls.Add(this.btnOnOff);
            this.pnlBtnShowHideAndBtnOnOff.Location = new System.Drawing.Point(196, 81);
            this.pnlBtnShowHideAndBtnOnOff.Name = "pnlBtnShowHideAndBtnOnOff";
            this.pnlBtnShowHideAndBtnOnOff.Size = new System.Drawing.Size(71, 54);
            this.pnlBtnShowHideAndBtnOnOff.TabIndex = 6;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(3, 3);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(64, 23);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.Text = "Show";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(3, 27);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(64, 23);
            this.btnOnOff.TabIndex = 6;
            this.btnOnOff.Tag = "2";
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // cboConnectTimeout
            // 
            this.cboConnectTimeout.Enabled = false;
            this.cboConnectTimeout.FormattingEnabled = true;
            this.cboConnectTimeout.Location = new System.Drawing.Point(90, 107);
            this.cboConnectTimeout.Name = "cboConnectTimeout";
            this.cboConnectTimeout.Size = new System.Drawing.Size(100, 21);
            this.cboConnectTimeout.TabIndex = 7;
            // 
            // rbtSQLServer
            // 
            this.rbtSQLServer.AutoSize = true;
            this.rbtSQLServer.Checked = true;
            this.rbtSQLServer.Enabled = false;
            this.rbtSQLServer.Location = new System.Drawing.Point(110, 134);
            this.rbtSQLServer.Name = "rbtSQLServer";
            this.rbtSQLServer.Size = new System.Drawing.Size(80, 17);
            this.rbtSQLServer.TabIndex = 8;
            this.rbtSQLServer.TabStop = true;
            this.rbtSQLServer.Text = "SQL Server";
            this.rbtSQLServer.UseVisualStyleBackColor = true;
            this.rbtSQLServer.Click += new System.EventHandler(this.rbtSQLServer_Click);
            // 
            // rbtWindowsLocal
            // 
            this.rbtWindowsLocal.AutoSize = true;
            this.rbtWindowsLocal.Location = new System.Drawing.Point(12, 134);
            this.rbtWindowsLocal.Name = "rbtWindowsLocal";
            this.rbtWindowsLocal.Size = new System.Drawing.Size(98, 17);
            this.rbtWindowsLocal.TabIndex = 9;
            this.rbtWindowsLocal.TabStop = true;
            this.rbtWindowsLocal.Text = "Windows Local";
            this.rbtWindowsLocal.UseVisualStyleBackColor = true;
            this.rbtWindowsLocal.Click += new System.EventHandler(this.rbtWindowsLocal_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(90, 55);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(177, 20);
            this.txtUserID.TabIndex = 3;
            // 
            // txtDataInitialCatalog
            // 
            this.txtDataInitialCatalog.Location = new System.Drawing.Point(90, 29);
            this.txtDataInitialCatalog.Name = "txtDataInitialCatalog";
            this.txtDataInitialCatalog.Size = new System.Drawing.Size(177, 20);
            this.txtDataInitialCatalog.TabIndex = 2;
            // 
            // txtServerDataSource
            // 
            this.txtServerDataSource.Location = new System.Drawing.Point(90, 3);
            this.txtServerDataSource.Name = "txtServerDataSource";
            this.txtServerDataSource.Size = new System.Drawing.Size(177, 20);
            this.txtServerDataSource.TabIndex = 1;
            // 
            // lblConnectTimeout
            // 
            this.lblConnectTimeout.AutoSize = true;
            this.lblConnectTimeout.Enabled = false;
            this.lblConnectTimeout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectTimeout.Location = new System.Drawing.Point(6, 107);
            this.lblConnectTimeout.Name = "lblConnectTimeout";
            this.lblConnectTimeout.Size = new System.Drawing.Size(80, 19);
            this.lblConnectTimeout.TabIndex = 0;
            this.lblConnectTimeout.Text = "TimeOut..:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(0, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password..:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(28, 56);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(58, 19);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Login..:";
            // 
            // lblDataInitialCatalog
            // 
            this.lblDataInitialCatalog.AutoSize = true;
            this.lblDataInitialCatalog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInitialCatalog.Location = new System.Drawing.Point(2, 30);
            this.lblDataInitialCatalog.Name = "lblDataInitialCatalog";
            this.lblDataInitialCatalog.Size = new System.Drawing.Size(84, 19);
            this.lblDataInitialCatalog.TabIndex = 0;
            this.lblDataInitialCatalog.Text = "Database..:";
            // 
            // lblServerDataSource
            // 
            this.lblServerDataSource.AutoSize = true;
            this.lblServerDataSource.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerDataSource.Location = new System.Drawing.Point(22, 4);
            this.lblServerDataSource.Name = "lblServerDataSource";
            this.lblServerDataSource.Size = new System.Drawing.Size(64, 19);
            this.lblServerDataSource.TabIndex = 0;
            this.lblServerDataSource.Text = "Server..:";
            // 
            // frmModelA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 234);
            this.ControlBox = false;
            this.Controls.Add(this.grpModelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModelA";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloA";
            this.grpModelA.ResumeLayout(false);
            this.pnlModelServerLogin.ResumeLayout(false);
            this.pnlModelServerLogin.PerformLayout();
            this.pnlBtnShowHideAndBtnOnOff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModelA;
        private System.Windows.Forms.Panel pnlModelServerLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblDataInitialCatalog;
        private System.Windows.Forms.Label lblServerDataSource;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDataInitialCatalog;
        private System.Windows.Forms.TextBox txtServerDataSource;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.ComboBox cboConnectTimeout;
        private System.Windows.Forms.RadioButton rbtSQLServer;
        private System.Windows.Forms.RadioButton rbtWindowsLocal;
        private System.Windows.Forms.Label lblConnectTimeout;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Panel pnlBtnShowHideAndBtnOnOff;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClose;

    }
}