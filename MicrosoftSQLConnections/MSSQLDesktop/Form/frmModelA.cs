namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading.Tasks;

    #endregion
    #region ---> ( Class frmModelA )
    /// <summary>
    /// #Class frmModelA Form
    /// </summary>
    public partial class frmModelA : Form
    {
        #region --->( Constructor )
        /// <summary>
        /// #Constructor frmModelA
        /// </summary>
        public frmModelA()
        {
            InitializeComponent();
            Debugar.Status();
        }
        #endregion

        #region ---> btnSair Super Simples
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Botao Sair Super Simples

        #region ---> btnShowHide Simples
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowHidePassword();
        }
        private void ShowHidePassword()
        {
            if ((btnShowHide.Text == ("Show")) && (txtPassword.UseSystemPasswordChar == (true)))
            {
                Debugar.TypeDebugPrint("\r\t Change Text Hide and Show Password");
                txtPassword.UseSystemPasswordChar = false;
                btnShowHide.Text = "Hide";
            }
            else if ((btnShowHide.Text == ("Hide")) && (txtPassword.UseSystemPasswordChar == (false)))
            {
                Debugar.TypeDebugPrint("\r\t Change Text Show and Hide Password");
                txtPassword.UseSystemPasswordChar = true;
                btnShowHide.Text = "Show";
            }
        }

        #endregion ---> btnShowHide Simples

        #region ---> btnOnOff Complete

        private enum TimeOutOnOff
        {
            ON = 1,
            OFF = 0
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.ON))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r\r\r btnLigaDesliga = ON");
                lblConnectTimeout.Enabled = (!lblConnectTimeout.Enabled);
                cboConnectTimeout.Enabled = (!true);
                cboConnectTimeout.Items.Clear();
                cboConnectTimeout.Text = (String.Empty);


                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)0);

                MSSQLDesktop.Debugar.TypeDebugPrint("\r ItensList [CLEAR] = " + Convert.ToString(cboConnectTimeout.Items.Count));
            }
            else if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.OFF))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r\r\r btnLigaDesliga = OFF");

                lblConnectTimeout.Enabled = (!lblConnectTimeout.Enabled);
                cboConnectTimeout.Enabled = (true);

                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
                btnOnOff.Tag = Convert.ToChar((TimeOutOnOff)1);

                int[] ItensList = new int[999];
                foreach (int Itens in ItensList)
                {
                    ItensList[0]++;
                    cboConnectTimeout.Items.Add(Convert.ToString(ItensList[0]));
                    MSSQLDesktop.Debugar.TypeDebugPrint("\r ItensList [TOTAL] = " + Convert.ToString(ItensList[0]));
                }
                
                cboConnectTimeout.Text = Convert.ToString(cboConnectTimeout.Items[29].ToString());
            }
        }

        #endregion ---> btnLigaDesliga Completo

        #region ---> Choice rbt WindowsLocal and SQLServer
        /// <summary>
        /// Enables disables Components
        /// </summary>
        private void EnableDisableLogin()
        {
            txtUserID.Enabled = !(txtUserID.Enabled);
            lblUserID.Enabled = !(lblUserID.Enabled);
            txtPassword.Enabled = !(txtPassword.Enabled);
            lblPassword.Enabled = !(lblPassword.Enabled);
            rbtSQLServer.Enabled = !(rbtSQLServer.Enabled);
            rbtWindowsLocal.Enabled = !(rbtWindowsLocal.Enabled);
            MSSQLDesktop.Debugar.TypeDebugPrint("Status Login = " + Convert.ToString(txtUserID.Enabled));
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
            Task tk = new Task(StartConnection);
            tk.Start();
 
         }

        public void StartConnection()
        {
            ///Clean
            ConnectionsSQLModelA.StringBuilderSQL_ConnectionString = (String.Empty);

            MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_DataSource = (txtServerDataSource.Text.ToString());
            MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_InitialCatalog = (txtDataInitialCatalog.Text.ToString());

            /// Choice rbtSQLServer and rbtWindowsLocal
            if (((rbtSQLServer.Checked) == (true)) | ((rbtWindowsLocal.Checked) == ((false))))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via SQL Server");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_UserID = (txtUserID.Text.ToString());
                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_Password = (txtPassword.Text.ToString());

            }
            else if (((rbtWindowsLocal.Checked) == (true)) | ((rbtSQLServer.Checked) == ((false))))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via Windows Local");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_UserID = (String.Empty);
                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_Password = (String.Empty);

            }

            MSSQLDesktop.Debugar.TypeDebugPrint("\r\t Valor TimeOut Atual = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));
            if ((cboConnectTimeout.Enabled) == (true))
            {

                MSSQLDesktop.Debugar.TypeDebugPrint("\t Print Value TimeOut...");

                MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout = (int.Parse(cboConnectTimeout.Text.ToString()));

            }
            else
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\t Default Value TimeOut...");
            }
            MSSQLDesktop.Debugar.TypeDebugPrint("\t\t Value TimeOut Final = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQLModelA.StringBuilderSQL_ConnectTimeout)));

            var ReturnoConn = MSSQLDesktop.ConnectionsSQLModelA.ReturnConnection(MSSQLDesktop.ConnectionsSQLModelA.choicesAction.ConnectionOpen);

            MessageBox.Show(Convert.ToString(ReturnoConn.Item1) + "   " + Convert.ToString(ReturnoConn.Item2));

        }
        #endregion
    }
    #endregion
}