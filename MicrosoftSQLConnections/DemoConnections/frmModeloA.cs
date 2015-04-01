using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoConnections
{
    public partial class frmModeloA : Form
    {
        public frmModeloA()
        {
            InitializeComponent();
            AppStatus.Debugar.Status();
        }

        #region ---> btnShow Simples
        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((btnShow.Text == ("Show")) && (txtSenhaPassword.UseSystemPasswordChar == (true)))
            {
                btnShow.Text = "NoShow";
                txtSenhaPassword.UseSystemPasswordChar = false;

            }
            else if ((btnShow.Text == ("NoShow")) && (txtSenhaPassword.UseSystemPasswordChar == (false)))
            {
                btnShow.Text = "Show";
                txtSenhaPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion ---> btnShow Simples

        #region ---> btnLigaDesliga Completo

        private enum LigarDesligar
        {
            Ligar = 1,
            Desligar = 2
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(btnLigaDesliga.Tag)) == ((int)LigarDesligar.Ligar))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Liga");

                cboTimeOutConnectTimeout.Enabled = (!true);
                cboTimeOutConnectTimeout.Items.Clear();
                cboTimeOutConnectTimeout.Text = (String.Empty);


                btnLigaDesliga.Text = Convert.ToString((LigarDesligar)(Convert.ToInt32(btnLigaDesliga.Tag)));
                btnLigaDesliga.Tag = Convert.ToChar((LigarDesligar)2);

                AppStatus.Debugar.EscreverDebugPrint("\r numeroItens [CLEAR] = " + Convert.ToString(cboTimeOutConnectTimeout.Items.Count));
            }
            else if ((Convert.ToInt32(btnLigaDesliga.Tag)) == ((int)LigarDesligar.Desligar))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Desliga");

                cboTimeOutConnectTimeout.Enabled = (true);

                btnLigaDesliga.Text = Convert.ToString((LigarDesligar)(Convert.ToInt32(btnLigaDesliga.Tag)));
                btnLigaDesliga.Tag = Convert.ToChar((LigarDesligar)1);

                int[] numeroItens = new int[999];
                foreach (int i in numeroItens)
                {
                    numeroItens[0]++;
                    cboTimeOutConnectTimeout.Items.Add(Convert.ToString(numeroItens[0]));

                    AppStatus.Debugar.EscreverDebugPrint("\r numeroItens [TOTAL] = " + Convert.ToString(numeroItens[0]));
                }

                cboTimeOutConnectTimeout.Text = Convert.ToString(cboTimeOutConnectTimeout.Items[29].ToString());

            }
        }

        #endregion ---> btnLigaDesliga Completo

        #region ---> Escolhas rbt WindowsLocal e SQLServer
        /// <summary>
        /// Habilita desabilita Componentes
        /// </summary>
        private void EnableDisableLogin()
        {
            txtUsuarioUserID.Enabled = !(txtUsuarioUserID.Enabled);
            lblUsuarioUserID.Enabled = !(lblUsuarioUserID.Enabled);
            txtSenhaPassword.Enabled = !(txtSenhaPassword.Enabled);
            lblSenhaPassword.Enabled = !(lblSenhaPassword.Enabled);
            AppStatus.Debugar.EscreverDebugPrint("Status Login = " + Convert.ToString(txtUsuarioUserID.Enabled));
        }
        private void rbtWindowsLocal_Click(object sender, EventArgs e)
        {
            EnableDisableLogin();
        }
        private void rbtSQLServer_Click(object sender, EventArgs e)
        {
            EnableDisableLogin();
        }
        #endregion ---> Escolhas rbt WindowsLocal e SQLServer

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_ConnectionString = (String.Empty);

            MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_DataSource = (txtServerDataSource.Text.ToString());
            MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_InitialCatalog = (txtBancoInitialCatalog.Text.ToString());

            if (((rbtSQLServer.Checked) == (true)) | ((rbtWindowsLocal.Checked) == ((false))))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r \tLogin via SQL Server");

                MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_UserID = (txtUsuarioUserID.Text.ToString());
                MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_Password = (txtSenhaPassword.Text.ToString());

            }
            else if (((rbtWindowsLocal.Checked) == (true)) | ((rbtSQLServer.Checked) == ((false))))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r \tLogin via Windows Local");

                MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_UserID = (String.Empty);
                MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_Password = (String.Empty);

            }

            AppStatus.Debugar.EscreverDebugPrint("\r\t Valor TimeOut Atual = " + (Convert.ToString(MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_ConnectTimeout)));
            if ((cboTimeOutConnectTimeout.Enabled) == (true))
            {

                AppStatus.Debugar.EscreverDebugPrint("\t Escrevendo Valor TimeOut...");

                MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_ConnectTimeout = (int.Parse(cboTimeOutConnectTimeout.Text.ToString()));

            }
            else
            {
                AppStatus.Debugar.EscreverDebugPrint("\t Default Valor TimeOut...");
            }
            AppStatus.Debugar.EscreverDebugPrint("\t\t Valor TimeOut Final = " + (Convert.ToString(MSSQLConnections.ConnectionsSQLModeloA.StringBuilderSQL_ConnectTimeout)));

            var ReturnoConn = MSSQLConnections.ConnectionsSQLModeloA.FU_RetornaConnection
                             (MSSQLConnections.ConnectionsSQLModeloA.EscolhaAcao.AbrirConexaoAberto);
            
            MessageBox.Show(Convert.ToString(ReturnoConn.Item1) + "   " + Convert.ToString(ReturnoConn.Item2));

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
