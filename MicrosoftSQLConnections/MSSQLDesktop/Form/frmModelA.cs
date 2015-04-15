using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSSQLDesktop
{
    public partial class frmModelA : Form
    {
        public frmModelA()
        {
            InitializeComponent();
            Debugar.Status();
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
                Debugar.TypeDebugPrint("\r\t Change Text Hide and Show Password");
                txtSenhaPassword.UseSystemPasswordChar = false;
                btnShow.Text = "Hide";

            }
            else if ((btnShow.Text == ("Hide")) && (txtSenhaPassword.UseSystemPasswordChar == (false)))
            {
                Debugar.TypeDebugPrint("\r\t Change Text Show and Hide Password");
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
                MSSQLDesktop.Debugar.TypeDebugPrint("\r\r\r btnLigaDesliga = Liga");
                lblTimeOutConnectTimeout.Enabled = (!lblTimeOutConnectTimeout.Enabled);
                cboTimeOutConnectTimeout.Enabled = (!true);
                cboTimeOutConnectTimeout.Items.Clear();
                cboTimeOutConnectTimeout.Text = (String.Empty);


                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)2);

                MSSQLDesktop.Debugar.TypeDebugPrint("\r numeroItens [CLEAR] = " + Convert.ToString(cboTimeOutConnectTimeout.Items.Count));
            }
            else if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.OFF))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r\r\r btnLigaDesliga = Desliga");
               
                lblTimeOutConnectTimeout.Enabled = (!lblTimeOutConnectTimeout.Enabled);
                cboTimeOutConnectTimeout.Enabled = (true);

                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)1);

                int[] numeroItens = new int[999];
                foreach (int i in numeroItens)
                {
                    numeroItens[0]++;
                    cboTimeOutConnectTimeout.Items.Add(Convert.ToString(numeroItens[0]));

                    MSSQLDesktop.Debugar.TypeDebugPrint("\r numeroItens [TOTAL] = " + Convert.ToString(numeroItens[0]));
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
            MSSQLDesktop.Debugar.TypeDebugPrint("Status Login = " + Convert.ToString(txtUsuarioUserID.Enabled));
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
            ConnectionsSQLModelA.StringBuilderSQL_ConnectionString = (String.Empty);

            MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_DataSource = (txtServerDataSource.Text.ToString());
            MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_InitialCatalog = (txtBancoInitialCatalog.Text.ToString());

            /// Escolhoas Entre rbtSQLServer e rbtWindowsLocal
            if (((rbtSQLServer.Checked) == (true)) | ((rbtWindowsLocal.Checked) == ((false))))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via SQL Server");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_UserID = (txtUsuarioUserID.Text.ToString());
                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_Password = (txtSenhaPassword.Text.ToString());

            }
            else if (((rbtWindowsLocal.Checked) == (true)) | ((rbtSQLServer.Checked) == ((false))))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via Windows Local");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_UserID = (String.Empty);
                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_Password = (String.Empty);

            }

            MSSQLDesktop.Debugar.TypeDebugPrint("\r\t Valor TimeOut Atual = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));
            if ((cboTimeOutConnectTimeout.Enabled) == (true))
            {

                MSSQLDesktop.Debugar.TypeDebugPrint("\t Escrevendo Valor TimeOut...");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout = (int.Parse(cboTimeOutConnectTimeout.Text.ToString()));

            }
            else
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\t Default Valor TimeOut...");
            }
            MSSQLDesktop.Debugar.TypeDebugPrint("\t\t Valor TimeOut Final = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));

            var ReturnoConn = MSSQLDesktop.ConnectionsSQLModelA.FU_RetornaConnection(MSSQLDesktop.ConnectionsSQLModelA.choicesAction.ConnectionOpen);
            
            MessageBox.Show(Convert.ToString(ReturnoConn.Item1) + "   " + Convert.ToString(ReturnoConn.Item2));

        }
        #endregion ---> btnConectar ao Server

    

    }
}
