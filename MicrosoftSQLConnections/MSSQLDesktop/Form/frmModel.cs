namespace MSSQLDesktop
{
    #region ---> ( Using )

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;

    #endregion

    #region ---> ( Class frmModel )

    /// <summary>
    /// #Class frmModel Form
    /// </summary>
    public partial class frmModel : Form
    {
        #region --->( Constructor )

        /// <summary>
        /// #Constructor frmModel
        /// </summary>
        public frmModel()
        {
            InitializeComponent();
            this.Text = (grpModelA.Text);
            execTaskForcboConnectTimeoutItens();
            // execTaskForAppConfCheck();
            Debugar.Status();
        }

        #endregion

        #region --->( List of Tasks )
        /// <summary>
        /// #Task For cboTimeOut Itens
        /// </summary>
        private void execTaskForcboConnectTimeoutItens()
        {
            Thread taskCreateNumberList = new Thread(CreateNumberListStrings);
            taskCreateNumberList.Start();
        }
        /// <summary>
        /// #Task For App.Conf Check File Exist
        /// </summary>
        private void execTaskForAppConfCheck()
        {
            AppConfigXML appConfigXML = new AppConfigXML();
            appConfigXML.TaskForAppConfCheckFileExist();
        }

        #endregion

        #region ---> ( btnClose Super Simples )
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ---> ( btnShowHide Simples )
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

        #region ---> ( btnOnOff Complete )

        private enum TimeOutOnOff
        {
            ON = 1,
            OFF = 0
        }

        private string[] itensRageForcboConnectTimeout = new string[999];
        private void CreateNumberListStrings()
        {
            for (int numberList = 0; numberList < itensRageForcboConnectTimeout.Length; numberList++)
            {
                itensRageForcboConnectTimeout[numberList] = Convert.ToString(numberList + (1));
                MSSQLDesktop.Debugar.TypeDebugPrint("\r ItensList [TOTAL] = " + itensRageForcboConnectTimeout[numberList]);
            }
        }
        private void OnAndOff()
        {
            if ((cboConnectTimeout.Items.Count) == (0))
            {
                cboConnectTimeout.Items.AddRange(itensRageForcboConnectTimeout);
            }
            if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.ON))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r btnOnOff ---> ON");
                cboConnectTimeout.Enabled = (!cboConnectTimeout.Enabled);
                cboConnectTimeout.Text = (string.Empty);
                btnOnOff.Tag = Convert.ToChar((int)TimeOutOnOff.OFF);
                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
            }
            else if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)TimeOutOnOff.OFF))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r btnOnOff ---> OFF");
                cboConnectTimeout.Enabled = (!cboConnectTimeout.Enabled);
                cboConnectTimeout.Text = Convert.ToString(cboConnectTimeout.Items[((30) - (1))].ToString());
                btnOnOff.Tag = Convert.ToChar((int)TimeOutOnOff.ON);
                btnOnOff.Text = Convert.ToString((TimeOutOnOff)(Convert.ToInt32(btnOnOff.Tag)));
            }
        }
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            this.OnAndOff();
        }

        #endregion ---> btnLigaDesliga Completo

        #region ---> (Choice rbt WindowsLocal and SQLServer)
        /// <summary>
        /// Enables disables Components
        /// </summary>
        private void EnableDisableLoginAndPassword()
        {
            txtUserID.Enabled = (!txtUserID.Enabled);
            txtPassword.Enabled = (!txtPassword.Enabled);
            rbtServerSQLIntegratedSecurity.Enabled = (!rbtServerSQLIntegratedSecurity.Enabled);
            rbtWindowsLocalIntegratedSecurity.Enabled = (!rbtWindowsLocalIntegratedSecurity.Enabled);
            MSSQLDesktop.Debugar.TypeDebugPrint("Status Login = " + Convert.ToString(txtUserID.Enabled));
        }
        private void rbtWindowsLocal_Click(object sender, EventArgs e)
        {
            EnableDisableLoginAndPassword();
        }
        private void rbtSQLServer_Click(object sender, EventArgs e)
        {
            EnableDisableLoginAndPassword();
        }
        #endregion ---> Escolhas rbt WindowsLocal e SQLServer

        #region ---> ( btnConnect on Server )
        private void btnConnect_Click(object sender, EventArgs e)
        {
            StartConnectionBaseSQLServer();
            if ( (ConnectionsSQL.StatusConnectionSQLString() ) == ("Open") )
            {
                ConnectionsSQL.ReturnConnectionSQL(ConnectionsSQL.choiceActions.ConnectionClose);
            }
            //MessageBox.Show(ConnectionsSQL.ReturnConnectionSQLString());
            ConnectionsSQL.ReturnConnectionSQL(ConnectionsSQL.choiceActions.ConnectionOpen);
            //MessageBox.Show(ConnectionsSQL.StatusConnectionSQLString());
        }

        //public void StartConnection()
        //{
        //    ///Clean
        //    ConnectionsSQL.StringBuilderSQL_ConnectionString = (String.Empty);

        //    MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_DataSource = (txtDataSource.Text.ToString());
        //    MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_InitialCatalog = (txtInitialCatalog.Text.ToString());

        //    /// Choice rbtSQLServer and rbtWindowsLocal
        //    if (((rbtServerSQLIntegratedSecurity.Checked) == (true)) | ((rbtWindowsLocalIntegratedSecurity.Checked) == ((false))))
        //    {
        //        MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via SQL Server");

        //        MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_UserID = (txtUserID.Text.ToString());
        //        MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_Password = (txtPassword.Text.ToString());

        //    }
        //    else if (((rbtWindowsLocalIntegratedSecurity.Checked) == (true)) | ((rbtServerSQLIntegratedSecurity.Checked) == ((false))))
        //    {
        //        MSSQLDesktop.Debugar.TypeDebugPrint("\r \tLogin via Windows Local");

        //        MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_UserID = (String.Empty);
        //        MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_Password = (String.Empty);

        //    }

        //    // MSSQLDesktop.Debugar.TypeDebugPrint("\r\t Valor TimeOut Current = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_ConnectTimeout)));
        //    if ((cboConnectTimeout.Enabled) == (true))
        //    {

        //        MSSQLDesktop.Debugar.TypeDebugPrint("\t Print Value TimeOut...");

        //        MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_ConnectTimeout = (int.Parse(cboConnectTimeout.Text.ToString()));

        //    }
        //    else
        //    {
        //        MSSQLDesktop.Debugar.TypeDebugPrint("\t Default Value TimeOut...");
        //    }
        //    // MSSQLDesktop.Debugar.TypeDebugPrint("\t\t Value TimeOut Final = " + (Convert.ToString(MSSQLDesktop.ConnectionsSQL.StringBuilderSQL_ConnectTimeout)));

        //    var ReturnoConn = MSSQLDesktop.ConnectionsSQL.ReturnConnectionSQL(MSSQLDesktop.ConnectionsSQL.choiceActions.ConnectionOpen);
        //    MessageBox.Show(Convert.ToString(ReturnoConn.Item1) + "   " + Convert.ToString(ReturnoConn.Item2));

        //}

        #endregion

        #region ---> ( Validate )
        private enum ChoiceFieldValidate
        {
            UserID = (1),
            Password = (2),
            DataSource = (3),
            ConnectTimeout = (4),
            InitialCatalog = (5),
            //ConnectionString = (6),
            IntegratedSecurity = (7),
            //PersistSecurityInfo = (8),

        }
        private string ValidateFieldsOnForm(ChoiceFieldValidate choiceFieldValidate)
        {
            String returnResult = (String.Empty);
            switch (choiceFieldValidate)
            {
                case (ChoiceFieldValidate.UserID):
                    {
                        if (!(string.IsNullOrEmpty(txtUserID.Text.ToString())))
                        {
                            returnResult = (txtUserID.Text.ToString());
                        }
                        else
                        {
                            MSSQLDesktop.Debugar.TypeDebugPrint("\r ERROR - Login Is Null Or Empty");
                            returnResult = (Convert.ToString(false));
                            MessageBox.Show(returnResult, Convert.ToString(choiceFieldValidate));
                        }
                        break;
                    }
                case (ChoiceFieldValidate.Password):
                    {
                        if (!(string.IsNullOrEmpty(txtPassword.Text.ToString())))
                        {
                            returnResult = (txtPassword.Text.ToString());
                        }
                        else
                        {
                            MSSQLDesktop.Debugar.TypeDebugPrint("\r ERROR - Password Is Null Or Empty");
                            returnResult = (Convert.ToString(false));
                            MessageBox.Show(returnResult, Convert.ToString(choiceFieldValidate));
                        }
                        break;
                    }
                case (ChoiceFieldValidate.DataSource):
                    {
                        if (!(string.IsNullOrEmpty(txtDataSource.Text.ToString())))
                        {
                            returnResult = (txtDataSource.Text.ToString());
                        }
                        else
                        {
                            MSSQLDesktop.Debugar.TypeDebugPrint("\r ERROR - Server Is Null Or Empty");
                            returnResult = (Convert.ToString(false));
                            MessageBox.Show(returnResult, Convert.ToString(choiceFieldValidate));
                        }
                        break;
                    }
                case (ChoiceFieldValidate.ConnectTimeout):
                    {
                        if (!(string.IsNullOrEmpty(cboConnectTimeout.Text.ToString())))
                        {
                            returnResult = (Convert.ToString(cboConnectTimeout.SelectedItem));
                        }
                        else
                        {
                            returnResult = (String.Empty);
                            MSSQLDesktop.Debugar.TypeDebugPrint("\r DEFAULT VALUE- TimeOut Is Null Or Empty");
                        }
                        break;
                    }
                case (ChoiceFieldValidate.InitialCatalog):
                    {
                        if (!(string.IsNullOrEmpty(txtInitialCatalog.Text.ToString())))
                        {
                            returnResult = (txtInitialCatalog.Text.ToString());
                        }
                        else
                        {
                            MSSQLDesktop.Debugar.TypeDebugPrint("\r ERROR - InitialCatalog Is Null Or Empty");
                            returnResult = (Convert.ToString(false));
                            MessageBox.Show(returnResult, Convert.ToString(choiceFieldValidate));
                        }
                        break;
                    }
                //case (ChoiceFieldValidate.ConnectionString):
                //    {
                //        break;
                //    }
                case (ChoiceFieldValidate.IntegratedSecurity):
                    {
                        MSSQLDesktop.Debugar.TypeDebugPrint("\r When FALSE (default) - User ID and Password are specified in the connection");
                        returnResult = (Convert.ToString(true));
                        break;
                    }
                //case (ChoiceFieldValidate.PersistSecurityInfo):
                //    {
                //        MSSQLDesktop.Debugar.TypeDebugPrint("\r When FALSE (default) - Strongly recommended security-sensitive information");
                //        returnResult = ((true).ToString());
                //        break;
                //    }
                default:
                    {
                        MSSQLDesktop.Debugar.TypeDebugPrint("\r CHOSE FIELD VALIDATE");
                        returnResult = "-0-";
                        break;
                    }
            }
            return returnResult;
        }

        public void StartConnectionBaseSQLServer()
        {
            if (rbtServerSQLIntegratedSecurity.Checked)
            {
                ConnectionsConfig connectionsConfig = new ConnectionsConfig(
                ValidateFieldsOnForm(ChoiceFieldValidate.UserID),
                ValidateFieldsOnForm(ChoiceFieldValidate.Password),
                ValidateFieldsOnForm(ChoiceFieldValidate.DataSource),
                ValidateFieldsOnForm(ChoiceFieldValidate.InitialCatalog),
                ValidateFieldsOnForm(ChoiceFieldValidate.ConnectTimeout));
            }
            else if (rbtWindowsLocalIntegratedSecurity.Checked)
            {
                ConnectionsConfig connectionsConfig = new ConnectionsConfig(
                ValidateFieldsOnForm(ChoiceFieldValidate.DataSource),
                ValidateFieldsOnForm(ChoiceFieldValidate.InitialCatalog),
                ValidateFieldsOnForm(ChoiceFieldValidate.IntegratedSecurity),
                ValidateFieldsOnForm(ChoiceFieldValidate.ConnectTimeout));
            }
            else
            {
                MessageBox.Show(
                (String.Format("{0} \n{1}",
                rbtServerSQLIntegratedSecurity.Text,
                rbtWindowsLocalIntegratedSecurity.Text)),
                ("Select the login type"));
            }
        }
        #endregion
    }
    #endregion
}