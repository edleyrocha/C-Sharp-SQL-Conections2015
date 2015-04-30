namespace MSSQLDesktop
{
    #region ---> ( Using )

    using System;
    using System.Collections;
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
        /// Task For For Connections SQL
        /// </summary>
        private void execTaskForConnectionsSQL(SelectOnOff selected)
        {
            Thread threadConnectionsSQL = new Thread(() =>
                {
                    if ((ConnectionsSQL.GetStatusConnectionSQLString()) == ("Open"))
                    {
                        ConnectionsSQL.GetReturnConnectionSQL(ConnectionsSQL.choiceActions.ConnectionClose);
                    };
                    if ((ConnectionsSQL.GetReturnConnectionSQL(ConnectionsSQL.choiceActions.ConnectionOpen).Item2) ==
                       ((int)(ConnectionsSQL.choiceActions.ConnectionOpen)))
                    {
                        String msgText = ("Save a Connection?");
                        String msgTitle = ("Connected");
                        MessageBoxButtons msgButton = (MessageBoxButtons.YesNo);
                        MessageBoxIcon msgIcon = (MessageBoxIcon.Question);
                        DialogResult msgResult;
                        if ((selected) == (SelectOnOff.ON))
                        {
                            msgResult = MessageBox.Show(msgText, msgTitle, msgButton, msgIcon);
                            if (msgResult == (DialogResult.Yes))
                            {
                                AppConfigXML appConfigXML = new AppConfigXML();
                                appConfigXML.SetAppConfigFileConnectionsString("stringSQLModel", ConnectionsSQL.GetConnectionSQLString());
                            }
                        }
                        else if ((selected) == (SelectOnOff.OFF))
                        {
                            msgText = ("Connection is [OK]");
                            msgButton = (MessageBoxButtons.OK);
                            msgIcon = (MessageBoxIcon.Information);
                            MessageBox.Show(msgText, msgTitle, msgButton, msgIcon);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Disconnected");
                    };
                });
            threadConnectionsSQL.Start();
        }

        #endregion

        #region ---> ( btnReadAndTest )
        private void btnReadAndTest_Click(object sender, EventArgs e)
        {
            GetAppConfigFileConnectionsString();
        }
        public void GetAppConfigFileConnectionsString()
        {
            String stringDB;
            AppConfigXML appConfigXML = new AppConfigXML();
            stringDB = appConfigXML.GetAppConfigFileConnectionsString("stringSQLModel");

            if ((!String.IsNullOrEmpty(stringDB)) && (btnReadAndTest.Text == ("Read")))
            {

                rtbStrings.Text = (stringDB);
                MSSQLDesktop.Debugar.TypeDebugPrint("\r Get Settings Saved (stringSQLModel) ");
                btnReadAndTest.Text = ("Test");
            }
            else if (btnReadAndTest.Text == ("Test"))
            {
                ConnectionsSQL.SetConnectionSQLAppConfig(stringDB);
                execTaskForConnectionsSQL(SelectOnOff.OFF);
                btnReadAndTest.Text = ("Read");
            };
        }
        #endregion

        #region ---> ( btnClose Super simple )
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ---> ( btnShowHide Simple )
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

        private enum SelectOnOff
        {
            ON = 1,
            OFF = 0
        }

        private string[] itensRageForcboConnectTimeout = new string[1000];
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
            if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)SelectOnOff.ON))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r btnOnOff ---> ON");
                cboConnectTimeout.Enabled = (!cboConnectTimeout.Enabled);
                cboConnectTimeout.Text = (string.Empty);
                btnOnOff.Tag = Convert.ToChar((int)SelectOnOff.OFF);
                btnOnOff.Text = Convert.ToString((SelectOnOff)(Convert.ToInt32(btnOnOff.Tag)));
            }
            else if ((Convert.ToInt32(btnOnOff.Tag)) == ((int)SelectOnOff.OFF))
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r btnOnOff ---> OFF");
                cboConnectTimeout.Enabled = (!cboConnectTimeout.Enabled);
                cboConnectTimeout.Text = Convert.ToString(cboConnectTimeout.Items[((30) - (1))].ToString());
                btnOnOff.Tag = Convert.ToChar((int)SelectOnOff.ON);
                btnOnOff.Text = Convert.ToString((SelectOnOff)(Convert.ToInt32(btnOnOff.Tag)));
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
            if (rbtServerSQLIntegratedSecurity.Checked)
            {
                txtUserID.Enabled = (true);
                txtPassword.Enabled = (true);
            }
            else if (rbtWindowsLocalIntegratedSecurity.Checked)
            {
                txtUserID.Enabled = (false);
                txtPassword.Enabled = (false);
            };
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
        #endregion

        #region ---> ( btnConnect on Server )
        private void btnConnect_Click(object sender, EventArgs e)
        {
            StartConnectionBaseSQLServer();
            execTaskForConnectionsSQL(SelectOnOff.ON);
        }
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
                        if (!(string.IsNullOrEmpty(cboInitialCatalog.Text.ToString())))
                        {
                            returnResult = (cboInitialCatalog.Text.ToString());
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

        #region ---> ( Comp ReadyOnly )
        private void cboConnectTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None; //ReadOnly ComboBox
        }

        private void cboInitialCatalog_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None; //ReadOnly ComboBox
        }

        private void rtbStrings_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None; //ReadOnly ComboBox
        }
        #endregion
        private BackgroundWorker bw = new BackgroundWorker();
        private void backgroudShowProgessBar()
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
          

               

            for (int i = 1; (i <= 999); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                   worker.ReportProgress((i * 1));
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
            }
            else if (!(e.Error == null))
            {

            }
            else
            {
            };
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        private void ShowListDataBase()
        {
            if (rbtServerSQLIntegratedSecurity.Checked)
            {
                String tgsource = cboInitialCatalog.Tag.ToString();
                String dSource = txtDataSource.Text;
                String uSource = txtUserID.Text;
                String pSource = txtPassword.Text;
                if (!String.IsNullOrEmpty(dSource) && !String.IsNullOrEmpty(uSource) && !String.IsNullOrEmpty(pSource))
                {
                    if ((tgsource) != (dSource))
                    {
                        cboInitialCatalog.Tag = (dSource);
                        String[] stringDatas = new String[5];
                        stringDatas[0] = (uSource);
                        stringDatas[1] = (pSource);
                        stringDatas[2] = (dSource);
                        stringDatas[3] = ("master");
                        stringDatas[4] = ("1");
                        ConnectionsConfig cnConfig = new ConnectionsConfig(
                        stringDatas[0],
                        stringDatas[1],
                        stringDatas[2],
                        stringDatas[3],
                        stringDatas[4]);
                        List<string> initialCatalog = new List<string>();
                        initialCatalog.Clear();
                        this.Cursor = Cursors.WaitCursor;
                        initialCatalog = ConnectionsSQL.GetDataBaseInitialCatalog(ConnectionsSQL.choiceLocal.Local);
                        this.Cursor = Cursors.Default;
                        if ((initialCatalog.Count) == (0))
                        {
                            cboInitialCatalog.Items.Clear();
                            cboInitialCatalog.Text = (String.Empty);
                        }
                        else
                        {
                            cboInitialCatalog.Items.Clear();
                            cboInitialCatalog.Text = (String.Empty);
                            cboInitialCatalog.Items.AddRange(initialCatalog.ToArray());
                        };
                    };
                };
            }
            else if (rbtWindowsLocalIntegratedSecurity.Checked)
            {
                String tgsource = txtDataSource.Tag.ToString();
                String dsource = txtDataSource.Text;
                if (!String.IsNullOrEmpty(dsource))
                {
                   // backgroudShowProgessBar();
                    if ((tgsource) != (dsource))
                    {
                        txtDataSource.Tag = (dsource);
                        String[] stringDatas = new String[4];
                        stringDatas[0] = (dsource);
                        stringDatas[1] = ("master");
                        stringDatas[2] = ("true");
                        stringDatas[3] = ("1");
                        ConnectionsConfig cnConfig = new ConnectionsConfig(
                        stringDatas[0],
                        stringDatas[1],
                        stringDatas[2],
                        stringDatas[3]);
                        List<string> initialCatalog = new List<string>();
                        initialCatalog.Clear();
                      
                        this.Cursor = Cursors.WaitCursor;
                        initialCatalog = ConnectionsSQL.GetDataBaseInitialCatalog(ConnectionsSQL.choiceLocal.Local);
                        this.Cursor = Cursors.Default;
                        if ((initialCatalog.Count) == (0))
                        {
                            cboInitialCatalog.Items.Clear();
                            cboInitialCatalog.Text = (String.Empty);
                        }
                        else
                        {
                            cboInitialCatalog.Items.Clear();
                            cboInitialCatalog.Text = (String.Empty);
                            cboInitialCatalog.Items.AddRange(initialCatalog.ToArray());
                        };
                     
                    };
                };
            }
            else
            {
                MessageBox.Show(
                (String.Format("{0} \n{1}",
                rbtServerSQLIntegratedSecurity.Text,
                rbtWindowsLocalIntegratedSecurity.Text)),
                ("Select the login type"));
            };
        }
        private void cboInitialCatalog_Enter(object sender, EventArgs e)
        {
             ShowListDataBase();
        }

    
    }
    #endregion
}