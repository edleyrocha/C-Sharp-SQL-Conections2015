namespace DemoConnections
{
    partial class frmModeloA
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
            this.grpModeloA = new System.Windows.Forms.GroupBox();
            this.pnlModeloServerLogin = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlBtnShowLigar = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.cboTimeOutConnectTimeout = new System.Windows.Forms.ComboBox();
            this.rbtSQLServer = new System.Windows.Forms.RadioButton();
            this.rbtWindowsLocal = new System.Windows.Forms.RadioButton();
            this.txtSenhaPassword = new System.Windows.Forms.TextBox();
            this.txtUsuarioUserID = new System.Windows.Forms.TextBox();
            this.txtBancoInitialCatalog = new System.Windows.Forms.TextBox();
            this.txtServerDataSource = new System.Windows.Forms.TextBox();
            this.lblTimeOutConnectTimeout = new System.Windows.Forms.Label();
            this.lblSenhaPassword = new System.Windows.Forms.Label();
            this.lblUsuarioUserID = new System.Windows.Forms.Label();
            this.lblBancoInitialCatalog = new System.Windows.Forms.Label();
            this.lblServerDataSource = new System.Windows.Forms.Label();
            this.grpModeloA.SuspendLayout();
            this.pnlModeloServerLogin.SuspendLayout();
            this.pnlBtnShowLigar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModeloA
            // 
            this.grpModeloA.Controls.Add(this.pnlModeloServerLogin);
            this.grpModeloA.Location = new System.Drawing.Point(12, 12);
            this.grpModeloA.Name = "grpModeloA";
            this.grpModeloA.Size = new System.Drawing.Size(284, 213);
            this.grpModeloA.TabIndex = 0;
            this.grpModeloA.TabStop = false;
            this.grpModeloA.Text = "SQL Connection Modelo A";
            // 
            // pnlModeloServerLogin
            // 
            this.pnlModeloServerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModeloServerLogin.Controls.Add(this.btnConectar);
            this.pnlModeloServerLogin.Controls.Add(this.btnSair);
            this.pnlModeloServerLogin.Controls.Add(this.pnlBtnShowLigar);
            this.pnlModeloServerLogin.Controls.Add(this.cboTimeOutConnectTimeout);
            this.pnlModeloServerLogin.Controls.Add(this.rbtSQLServer);
            this.pnlModeloServerLogin.Controls.Add(this.rbtWindowsLocal);
            this.pnlModeloServerLogin.Controls.Add(this.txtSenhaPassword);
            this.pnlModeloServerLogin.Controls.Add(this.txtUsuarioUserID);
            this.pnlModeloServerLogin.Controls.Add(this.txtBancoInitialCatalog);
            this.pnlModeloServerLogin.Controls.Add(this.txtServerDataSource);
            this.pnlModeloServerLogin.Controls.Add(this.lblTimeOutConnectTimeout);
            this.pnlModeloServerLogin.Controls.Add(this.lblSenhaPassword);
            this.pnlModeloServerLogin.Controls.Add(this.lblUsuarioUserID);
            this.pnlModeloServerLogin.Controls.Add(this.lblBancoInitialCatalog);
            this.pnlModeloServerLogin.Controls.Add(this.lblServerDataSource);
            this.pnlModeloServerLogin.Location = new System.Drawing.Point(6, 19);
            this.pnlModeloServerLogin.Name = "pnlModeloServerLogin";
            this.pnlModeloServerLogin.Size = new System.Drawing.Size(272, 187);
            this.pnlModeloServerLogin.TabIndex = 0;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(3, 157);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(187, 23);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Tag = "2";
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(200, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Tag = "2";
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlBtnShowLigar
            // 
            this.pnlBtnShowLigar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtnShowLigar.Controls.Add(this.btnShow);
            this.pnlBtnShowLigar.Controls.Add(this.btnLigaDesliga);
            this.pnlBtnShowLigar.Location = new System.Drawing.Point(196, 81);
            this.pnlBtnShowLigar.Name = "pnlBtnShowLigar";
            this.pnlBtnShowLigar.Size = new System.Drawing.Size(71, 54);
            this.pnlBtnShowLigar.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(3, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(64, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.Location = new System.Drawing.Point(3, 27);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(64, 23);
            this.btnLigaDesliga.TabIndex = 6;
            this.btnLigaDesliga.Tag = "2";
            this.btnLigaDesliga.Text = "Ligar";
            this.btnLigaDesliga.UseVisualStyleBackColor = true;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // cboTimeOutConnectTimeout
            // 
            this.cboTimeOutConnectTimeout.Enabled = false;
            this.cboTimeOutConnectTimeout.FormattingEnabled = true;
            this.cboTimeOutConnectTimeout.Location = new System.Drawing.Point(90, 107);
            this.cboTimeOutConnectTimeout.Name = "cboTimeOutConnectTimeout";
            this.cboTimeOutConnectTimeout.Size = new System.Drawing.Size(100, 21);
            this.cboTimeOutConnectTimeout.TabIndex = 7;
            // 
            // rbtSQLServer
            // 
            this.rbtSQLServer.AutoSize = true;
            this.rbtSQLServer.Checked = true;
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
            // txtSenhaPassword
            // 
            this.txtSenhaPassword.Location = new System.Drawing.Point(90, 81);
            this.txtSenhaPassword.Name = "txtSenhaPassword";
            this.txtSenhaPassword.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPassword.TabIndex = 4;
            this.txtSenhaPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuarioUserID
            // 
            this.txtUsuarioUserID.Location = new System.Drawing.Point(90, 55);
            this.txtUsuarioUserID.Name = "txtUsuarioUserID";
            this.txtUsuarioUserID.Size = new System.Drawing.Size(177, 20);
            this.txtUsuarioUserID.TabIndex = 3;
            // 
            // txtBancoInitialCatalog
            // 
            this.txtBancoInitialCatalog.Location = new System.Drawing.Point(90, 29);
            this.txtBancoInitialCatalog.Name = "txtBancoInitialCatalog";
            this.txtBancoInitialCatalog.Size = new System.Drawing.Size(177, 20);
            this.txtBancoInitialCatalog.TabIndex = 2;
            // 
            // txtServerDataSource
            // 
            this.txtServerDataSource.Location = new System.Drawing.Point(90, 3);
            this.txtServerDataSource.Name = "txtServerDataSource";
            this.txtServerDataSource.Size = new System.Drawing.Size(177, 20);
            this.txtServerDataSource.TabIndex = 1;
            // 
            // lblTimeOutConnectTimeout
            // 
            this.lblTimeOutConnectTimeout.AutoSize = true;
            this.lblTimeOutConnectTimeout.Enabled = false;
            this.lblTimeOutConnectTimeout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOutConnectTimeout.Location = new System.Drawing.Point(4, 107);
            this.lblTimeOutConnectTimeout.Name = "lblTimeOutConnectTimeout";
            this.lblTimeOutConnectTimeout.Size = new System.Drawing.Size(80, 19);
            this.lblTimeOutConnectTimeout.TabIndex = 0;
            this.lblTimeOutConnectTimeout.Text = "TimeOut..:";
            // 
            // lblSenhaPassword
            // 
            this.lblSenhaPassword.AutoSize = true;
            this.lblSenhaPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPassword.Location = new System.Drawing.Point(21, 82);
            this.lblSenhaPassword.Name = "lblSenhaPassword";
            this.lblSenhaPassword.Size = new System.Drawing.Size(63, 19);
            this.lblSenhaPassword.TabIndex = 0;
            this.lblSenhaPassword.Text = "Senha..:";
            // 
            // lblUsuarioUserID
            // 
            this.lblUsuarioUserID.AutoSize = true;
            this.lblUsuarioUserID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioUserID.Location = new System.Drawing.Point(11, 56);
            this.lblUsuarioUserID.Name = "lblUsuarioUserID";
            this.lblUsuarioUserID.Size = new System.Drawing.Size(73, 19);
            this.lblUsuarioUserID.TabIndex = 0;
            this.lblUsuarioUserID.Text = "Usuario..:";
            // 
            // lblBancoInitialCatalog
            // 
            this.lblBancoInitialCatalog.AutoSize = true;
            this.lblBancoInitialCatalog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoInitialCatalog.Location = new System.Drawing.Point(21, 30);
            this.lblBancoInitialCatalog.Name = "lblBancoInitialCatalog";
            this.lblBancoInitialCatalog.Size = new System.Drawing.Size(63, 19);
            this.lblBancoInitialCatalog.TabIndex = 0;
            this.lblBancoInitialCatalog.Text = "Banco..:";
            // 
            // lblServerDataSource
            // 
            this.lblServerDataSource.AutoSize = true;
            this.lblServerDataSource.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerDataSource.Location = new System.Drawing.Point(20, 4);
            this.lblServerDataSource.Name = "lblServerDataSource";
            this.lblServerDataSource.Size = new System.Drawing.Size(64, 19);
            this.lblServerDataSource.TabIndex = 0;
            this.lblServerDataSource.Text = "Server..:";
            // 
            // frmModeloA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 234);
            this.ControlBox = false;
            this.Controls.Add(this.grpModeloA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeloA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloA";
            this.grpModeloA.ResumeLayout(false);
            this.pnlModeloServerLogin.ResumeLayout(false);
            this.pnlModeloServerLogin.PerformLayout();
            this.pnlBtnShowLigar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModeloA;
        private System.Windows.Forms.Panel pnlModeloServerLogin;
        private System.Windows.Forms.Label lblSenhaPassword;
        private System.Windows.Forms.Label lblUsuarioUserID;
        private System.Windows.Forms.Label lblBancoInitialCatalog;
        private System.Windows.Forms.Label lblServerDataSource;
        private System.Windows.Forms.TextBox txtSenhaPassword;
        private System.Windows.Forms.TextBox txtUsuarioUserID;
        private System.Windows.Forms.TextBox txtBancoInitialCatalog;
        private System.Windows.Forms.TextBox txtServerDataSource;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cboTimeOutConnectTimeout;
        private System.Windows.Forms.RadioButton rbtSQLServer;
        private System.Windows.Forms.RadioButton rbtWindowsLocal;
        private System.Windows.Forms.Label lblTimeOutConnectTimeout;
        private System.Windows.Forms.Button btnLigaDesliga;
        private System.Windows.Forms.Panel pnlBtnShowLigar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSair;

    }
}