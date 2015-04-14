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
    public partial class frmModelA : Form
    {
        public frmModelA()
        {
            InitializeComponent();
            AppStatus.Debugar.Status();
        }

        #region ---> btnSair Super Simples
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Botao Sair Super Simples

        #region ---> btnShow Simples
        private void btnShow_Click(object sender, EventArgs e)
        {
            MostrarOcultarSenha();
        }
        private void MostrarOcultarSenha()
        {
            if ((btnShow.Text == ("Show")) && (txtSenhaPassword.UseSystemPasswordChar == (true)))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\t Change Text Hide and Show Password");
                txtSenhaPassword.UseSystemPasswordChar = false;
                btnShow.Text = "Hide";

            }
            else if ((btnShow.Text == ("Hide")) && (txtSenhaPassword.UseSystemPasswordChar == (false)))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\t Change Text Show and Hide Password");
                txtSenhaPassword.UseSystemPasswordChar = true;
                btnShow.Text = "Show";
            }
        }

        #endregion ---> btnShow Simples

        #region ---> btnLigaDesliga Completo

        private enum TimeOutOnOff
        {
            ON = 1,
            OFF = 2
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.ON))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Liga");
                lblTimeOutConnectTimeout.Enabled = (!lblTimeOutConnectTimeout.Enabled);
                cboTimeOutConnectTimeout.Enabled = (!true);
                cboTimeOutConnectTimeout.Items.Clear();
                cboTimeOutConnectTimeout.Text = (String.Empty);


                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)2);

                AppStatus.Debugar.EscreverDebugPrint("\r numeroItens [CLEAR] = " + Convert.ToString(cboTimeOutConnectTimeout.Items.Count));
            }
            else if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.OFF))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Desliga");
               
                lblTimeOutConnectTimeout.Enabled = (!lblTimeOutConnectTimeout.Enabled);
                cboTimeOutConnectTimeout.Enabled = (true);

                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)1);

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
            txtUsuarioUserID.Enabled    = !(txtUsuarioUserID.Enabled);
            lblUsuarioUserID.Enabled    = !(lblUsuarioUserID.Enabled);
            txtSenhaPassword.Enabled    = !(txtSenhaPassword.Enabled);
            lblSenhaPassword.Enabled    = !(lblSenhaPassword.Enabled);
            rbtSQLServer.Enabled        = !(rbtSQLServer.Enabled);
            rbtWindowsLocal.Enabled     = !(rbtWindowsLocal.Enabled);
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

        #region ---> btnConectar ao Server
        private void btnConectar_Click(object sender, EventArgs e)
        {
            ///Limpar
            MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_ConnectionString = (String.Empty);

            MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_DataSource = (txtServerDataSource.Text.ToString());
            MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_InitialCatalog = (txtBancoInitialCatalog.Text.ToString());

            /// Escolhoas Entre rbtSQLServer e rbtWindowsLocal
            if (((rbtSQLServer.Checked) == (true)) | ((rbtWindowsLocal.Checked) == ((false))))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r \tLogin via SQL Server");

                MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_UserID = (txtUsuarioUserID.Text.ToString());
                MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_Password = (txtSenhaPassword.Text.ToString());

            }
            else if (((rbtWindowsLocal.Checked) == (true)) | ((rbtSQLServer.Checked) == ((false))))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r \tLogin via Windows Local");

                MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_UserID = (String.Empty);
                MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_Password = (String.Empty);

            }

            AppStatus.Debugar.EscreverDebugPrint("\r\t Valor TimeOut Atual = " + (Convert.ToString(MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));
            if ((cboTimeOutConnectTimeout.Enabled) == (true))
            {

                AppStatus.Debugar.EscreverDebugPrint("\t Escrevendo Valor TimeOut...");

                MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout = (int.Parse(cboTimeOutConnectTimeout.Text.ToString()));

            }
            else
            {
                AppStatus.Debugar.EscreverDebugPrint("\t Default Valor TimeOut...");
            }
            AppStatus.Debugar.EscreverDebugPrint("\t\t Valor TimeOut Final = " + (Convert.ToString(MSSQLConnections.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));

            var ReturnoConn = MSSQLConnections.ConnectionsSQLModelA.FU_RetornaConnection(MSSQLConnections.ConnectionsSQLModelA.EscolhaAcao.ConnectionOpen);
            
            MessageBox.Show(Convert.ToString(ReturnoConn.Item1) + "   " + Convert.ToString(ReturnoConn.Item2));

        }
        #endregion ---> btnConectar ao Server

    

    }
}
