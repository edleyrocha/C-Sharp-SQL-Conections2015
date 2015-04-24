namespace MSSQLDesktop
{
    partial class frmModel
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
            this.pnlModelStings = new System.Windows.Forms.Panel();
            this.btnReadAndTest = new System.Windows.Forms.Button();
            this.lblStrings = new System.Windows.Forms.Label();
            this.pnlModel = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBtnShowHideAndBtnOnOff = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.cboConnectTimeout = new System.Windows.Forms.ComboBox();
            this.rbtServerSQLIntegratedSecurity = new System.Windows.Forms.RadioButton();
            this.rbtWindowsLocalIntegratedSecurity = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtInitialCatalog = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.lblConnectTimeout = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblInitialCatalog = new System.Windows.Forms.Label();
            this.lbDataSource = new System.Windows.Forms.Label();
            this.grpModelA.SuspendLayout();
            this.pnlModelStings.SuspendLayout();
            this.pnlModel.SuspendLayout();
            this.pnlBtnShowHideAndBtnOnOff.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModelA
            // 
            this.grpModelA.Controls.Add(this.pnlModelStings);
            this.grpModelA.Controls.Add(this.pnlModel);
            this.grpModelA.Location = new System.Drawing.Point(12, 12);
            this.grpModelA.Name = "grpModelA";
            this.grpModelA.Size = new System.Drawing.Size(284, 320);
            this.grpModelA.TabIndex = 0;
            this.grpModelA.TabStop = false;
            this.grpModelA.Text = "SQL Connection";
            // 
            // pnlModelStings
            // 
            this.pnlModelStings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModelStings.Controls.Add(this.btnReadAndTest);
            this.pnlModelStings.Controls.Add(this.lblStrings);
            this.pnlModelStings.Location = new System.Drawing.Point(6, 212);
            this.pnlModelStings.Name = "pnlModelStings";
            this.pnlModelStings.Size = new System.Drawing.Size(272, 100);
            this.pnlModelStings.TabIndex = 2;
            // 
            // btnReadAndTest
            // 
            this.btnReadAndTest.Location = new System.Drawing.Point(188, 72);
            this.btnReadAndTest.Name = "btnReadAndTest";
            this.btnReadAndTest.Size = new System.Drawing.Size(75, 23);
            this.btnReadAndTest.TabIndex = 2;
            this.btnReadAndTest.Text = "Read";
            this.btnReadAndTest.UseVisualStyleBackColor = true;
            this.btnReadAndTest.Click += new System.EventHandler(this.btnReadAndTest_Click);
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.Location = new System.Drawing.Point(5, 5);
            this.lblStrings.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(97, 13);
            this.lblStrings.TabIndex = 1;
            this.lblStrings.Text = "%DataBaseString%";
            // 
            // pnlModel
            // 
            this.pnlModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModel.Controls.Add(this.btnConnect);
            this.pnlModel.Controls.Add(this.btnClose);
            this.pnlModel.Controls.Add(this.pnlBtnShowHideAndBtnOnOff);
            this.pnlModel.Controls.Add(this.cboConnectTimeout);
            this.pnlModel.Controls.Add(this.rbtServerSQLIntegratedSecurity);
            this.pnlModel.Controls.Add(this.rbtWindowsLocalIntegratedSecurity);
            this.pnlModel.Controls.Add(this.txtPassword);
            this.pnlModel.Controls.Add(this.txtUserID);
            this.pnlModel.Controls.Add(this.txtInitialCatalog);
            this.pnlModel.Controls.Add(this.txtDataSource);
            this.pnlModel.Controls.Add(this.lblConnectTimeout);
            this.pnlModel.Controls.Add(this.lblPassword);
            this.pnlModel.Controls.Add(this.lblUserID);
            this.pnlModel.Controls.Add(this.lblInitialCatalog);
            this.pnlModel.Controls.Add(this.lbDataSource);
            this.pnlModel.Location = new System.Drawing.Point(6, 19);
            this.pnlModel.Name = "pnlModel";
            this.pnlModel.Size = new System.Drawing.Size(272, 187);
            this.pnlModel.TabIndex = 0;
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
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnOnOff.Tag = "0";
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
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
            // rbtServerSQLIntegratedSecurity
            // 
            this.rbtServerSQLIntegratedSecurity.AutoSize = true;
            this.rbtServerSQLIntegratedSecurity.Checked = true;
            this.rbtServerSQLIntegratedSecurity.Enabled = false;
            this.rbtServerSQLIntegratedSecurity.Location = new System.Drawing.Point(110, 134);
            this.rbtServerSQLIntegratedSecurity.Name = "rbtServerSQLIntegratedSecurity";
            this.rbtServerSQLIntegratedSecurity.Size = new System.Drawing.Size(80, 17);
            this.rbtServerSQLIntegratedSecurity.TabIndex = 8;
            this.rbtServerSQLIntegratedSecurity.TabStop = true;
            this.rbtServerSQLIntegratedSecurity.Text = "SQL Server";
            this.rbtServerSQLIntegratedSecurity.UseVisualStyleBackColor = true;
            this.rbtServerSQLIntegratedSecurity.Click += new System.EventHandler(this.rbtSQLServer_Click);
            // 
            // rbtWindowsLocalIntegratedSecurity
            // 
            this.rbtWindowsLocalIntegratedSecurity.AutoSize = true;
            this.rbtWindowsLocalIntegratedSecurity.Location = new System.Drawing.Point(12, 134);
            this.rbtWindowsLocalIntegratedSecurity.Name = "rbtWindowsLocalIntegratedSecurity";
            this.rbtWindowsLocalIntegratedSecurity.Size = new System.Drawing.Size(98, 17);
            this.rbtWindowsLocalIntegratedSecurity.TabIndex = 9;
            this.rbtWindowsLocalIntegratedSecurity.Text = "Windows Local";
            this.rbtWindowsLocalIntegratedSecurity.UseVisualStyleBackColor = true;
            this.rbtWindowsLocalIntegratedSecurity.Click += new System.EventHandler(this.rbtWindowsLocal_Click);
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
            // txtInitialCatalog
            // 
            this.txtInitialCatalog.Location = new System.Drawing.Point(90, 29);
            this.txtInitialCatalog.Name = "txtInitialCatalog";
            this.txtInitialCatalog.Size = new System.Drawing.Size(177, 20);
            this.txtInitialCatalog.TabIndex = 2;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(90, 3);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(177, 20);
            this.txtDataSource.TabIndex = 1;
            // 
            // lblConnectTimeout
            // 
            this.lblConnectTimeout.AutoSize = true;
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
            // lblInitialCatalog
            // 
            this.lblInitialCatalog.AutoSize = true;
            this.lblInitialCatalog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialCatalog.Location = new System.Drawing.Point(2, 30);
            this.lblInitialCatalog.Name = "lblInitialCatalog";
            this.lblInitialCatalog.Size = new System.Drawing.Size(84, 19);
            this.lblInitialCatalog.TabIndex = 0;
            this.lblInitialCatalog.Text = "Database..:";
            // 
            // lbDataSource
            // 
            this.lbDataSource.AutoSize = true;
            this.lbDataSource.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataSource.Location = new System.Drawing.Point(22, 4);
            this.lbDataSource.Name = "lbDataSource";
            this.lbDataSource.Size = new System.Drawing.Size(64, 19);
            this.lbDataSource.TabIndex = 0;
            this.lbDataSource.Text = "Server..:";
            // 
            // frmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 329);
            this.ControlBox = false;
            this.Controls.Add(this.grpModelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%TITLE%";
            this.grpModelA.ResumeLayout(false);
            this.pnlModelStings.ResumeLayout(false);
            this.pnlModelStings.PerformLayout();
            this.pnlModel.ResumeLayout(false);
            this.pnlModel.PerformLayout();
            this.pnlBtnShowHideAndBtnOnOff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModelA;
        private System.Windows.Forms.Panel pnlModel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblInitialCatalog;
        private System.Windows.Forms.Label lbDataSource;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtInitialCatalog;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.ComboBox cboConnectTimeout;
        private System.Windows.Forms.RadioButton rbtServerSQLIntegratedSecurity;
        private System.Windows.Forms.RadioButton rbtWindowsLocalIntegratedSecurity;
        private System.Windows.Forms.Label lblConnectTimeout;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Panel pnlBtnShowHideAndBtnOnOff;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.Panel pnlModelStings;
        private System.Windows.Forms.Button btnReadAndTest;

    }
}