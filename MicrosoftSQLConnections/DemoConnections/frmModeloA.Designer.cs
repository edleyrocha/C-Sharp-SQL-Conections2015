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
            this.pnlBtnShowLigar = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.cboTimeOut = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
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
            this.pnlModeloServerLogin.Controls.Add(this.cboTimeOut);
            this.pnlModeloServerLogin.Controls.Add(this.radioButton2);
            this.pnlModeloServerLogin.Controls.Add(this.radioButton1);
            this.pnlModeloServerLogin.Controls.Add(this.txtSenha);
            this.pnlModeloServerLogin.Controls.Add(this.textBox3);
            this.pnlModeloServerLogin.Controls.Add(this.textBox2);
            this.pnlModeloServerLogin.Controls.Add(this.textBox1);
            this.pnlModeloServerLogin.Controls.Add(this.label5);
            this.pnlModeloServerLogin.Controls.Add(this.label4);
            this.pnlModeloServerLogin.Controls.Add(this.label3);
            this.pnlModeloServerLogin.Controls.Add(this.label2);
            this.pnlModeloServerLogin.Controls.Add(this.label1);
            this.pnlModeloServerLogin.Location = new System.Drawing.Point(6, 19);
            this.pnlModeloServerLogin.Name = "pnlModeloServerLogin";
            this.pnlModeloServerLogin.Size = new System.Drawing.Size(272, 187);
            this.pnlModeloServerLogin.TabIndex = 0;
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
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.Location = new System.Drawing.Point(3, 27);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(64, 23);
            this.btnLigaDesliga.TabIndex = 2;
            this.btnLigaDesliga.Tag = "2";
            this.btnLigaDesliga.Text = "Ligar";
            this.btnLigaDesliga.UseVisualStyleBackColor = true;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // cboTimeOut
            // 
            this.cboTimeOut.Enabled = false;
            this.cboTimeOut.FormattingEnabled = true;
            this.cboTimeOut.Location = new System.Drawing.Point(90, 107);
            this.cboTimeOut.Name = "cboTimeOut";
            this.cboTimeOut.Size = new System.Drawing.Size(100, 21);
            this.cboTimeOut.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 134);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SQL Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 134);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Windows Local";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(90, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "TimeOut..:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha..:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario..:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banco..:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server..:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(3, 157);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(187, 23);
            this.btnConectar.TabIndex = 2;
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
            this.btnSair.TabIndex = 2;
            this.btnSair.Tag = "2";
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cboTimeOut;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLigaDesliga;
        private System.Windows.Forms.Panel pnlBtnShowLigar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSair;

    }
}