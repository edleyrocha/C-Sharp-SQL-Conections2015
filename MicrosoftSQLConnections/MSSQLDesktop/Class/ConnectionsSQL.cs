namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    #endregion

    #region ---> ( Class )
    /// <summary>
    /// #Class ConnectionsSQL Simple
    /// </summary>
    class ConnectionsSQL
    {
        #region --->( Constructor )
        /// <summary>
        /// #Method Constructor ConnectionsSQL Simple
        /// </summary>
        public ConnectionsSQL()
        {

        }

        #endregion

        #region ---> ( SQL Connection )
        /// <summary>
        /// #ConnectionSQL Private
        /// </summary>
        private static SqlConnection connectionSQL = new SqlConnection();
        #endregion

        #region ---> ( String Builder )
        /// <summary>
        /// #SQL Connection String Builder --> scsBuilder (Static)
        /// </summary>
        private static SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();
        /// <summary>
        /// #User ID Login
        /// </summary>
        public static string StringBuilderSQL_UserID
        {
            private get { return stringBuilderSQL.UserID; }
            set { stringBuilderSQL.UserID = value; }
        }
        /// <summary>
        /// #Password for SQL Server
        /// </summary>
        public static string StringBuilderSQL_Password
        {
            private get { return stringBuilderSQL.Password; }
            set { stringBuilderSQL.Password = value; }
        }
        /// <summary>
        /// #Address Server SQL - Name/IP 
        /// </summary>
        public static string StringBuilderSQL_DataSource
        {
            private get { return stringBuilderSQL.DataSource; }
            set { stringBuilderSQL.DataSource = value; }
        }
        /// <summary>
        /// #TimeOut Connection
        /// </summary>
        public static int StringBuilderSQL_ConnectTimeout
        {
            private get { return stringBuilderSQL.ConnectTimeout; }
            set { stringBuilderSQL.ConnectTimeout = value; }
        }
        /// <summary>
        /// #Name DataBase
        /// </summary>
        public static string StringBuilderSQL_InitialCatalog
        {
            private get { return stringBuilderSQL.InitialCatalog; }
            set { stringBuilderSQL.InitialCatalog = value; }
        }
        /// <summary>
        /// #Complete String Connection with Database
        /// </summary>
        public static string StringBuilderSQL_ConnectionString
        {
            private get { return stringBuilderSQL.ConnectionString; }
            set { stringBuilderSQL.ConnectionString = value; }
        }
        /// <summary>
        /// #Security Type Login Windows Local
        /// </summary>
        public static bool StringBuilderSQL_IntegratedSecurity
        {
            private get { return stringBuilderSQL.IntegratedSecurity; }
            set { stringBuilderSQL.IntegratedSecurity = value; }
        }
        /// <summary>
        /// #Security Type Login SQL Server
        /// </summary>
        public static bool StringBuilderSQL_PersistSecurityInfo
        {
            private get { return stringBuilderSQL.PersistSecurityInfo; }
            set { stringBuilderSQL.PersistSecurityInfo = value; }
        }
        #endregion

        #region ---> ( Connection And String Returne )

        /// <summary>
        /// #Choices ---> ConnectionClose = 0, ConnectionOpen = 1
        /// </summary>
        [DefaultValue(ConnectionClose)]
        public enum choiceActions
        {
            ConnectionClose = 0,
            ConnectionOpen = 1
        }
        /// <summary>
        /// #SQL function Connection Return--> Tuple-> (SqlConnection, int) tuple.Item1 tuple.Item2
        /// </summary>
        public static Tuple<SqlConnection, int> GetReturnConnectionSQL(choiceActions ActionChosen)
        {
            try
            {
                switch (ActionChosen)
                {
                    case choiceActions.ConnectionOpen:
                        {
                            ConnectionsSQL.connectionSQL.ConnectionString = (stringBuilderSQL.ConnectionString);
                            ConnectionsSQL.connectionSQL.Open();
                            ActionChosen = (choiceActions.ConnectionOpen);
                            MSSQLDesktop.Debugar.TypeDebugPrint("\t SQL Server Online...");
                            break;
                        }
                    case choiceActions.ConnectionClose:
                        {
                            ConnectionsSQL.connectionSQL.Close();
                            ConnectionsSQL.connectionSQL.Dispose();
                            ActionChosen = (choiceActions.ConnectionClose);
                            MSSQLDesktop.Debugar.TypeDebugPrint("\t SQL Server Offline...");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch
            {
                ActionChosen = (choiceActions.ConnectionClose);
                MSSQLDesktop.Debugar.TypeDebugPrint("\t SQL Server " + "[ERRO]" + " Offline...");
            }
            return Tuple.Create(connectionSQL, (int)ActionChosen);
        }
        #endregion

        #region ---> ( Connection Show InitialCatalog)
        public enum choiceLocal
        {
            Remote = 0,
            Local = 1
        }
        public static List<string> GetDataBaseInitialCatalog(choiceLocal localSelect)
        {
            MSSQLDesktop.Debugar.TypeDebugPrint("\r Start GetDataBaseInitialCatalog");
            List<string> returnInitialCatalog = new List<string>();
            ConnectionsSQL.connectionSQL.Close();
            try
            {
                connectionSQL.ConnectionString = (stringBuilderSQL.ConnectionString);
                MSSQLDesktop.Debugar.TypeDebugPrint("\r Conected A \n");
                connectionSQL.Open();
                MSSQLDesktop.Debugar.TypeDebugPrint("\r Conected B \n");
                string query = ("SELECT (name) FROM sys.databases;");
                SqlCommand cmd = new SqlCommand(query, connectionSQL);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        returnInitialCatalog.Add(item.ToString());
                    };
                };
            }
            catch (Exception e)
            {
                MSSQLDesktop.Debugar.TypeDebugPrint("\r ERROR GetDataBaseInitialCatalog\n" + (e.ToString()));
            }
            connectionSQL.Close();
            MSSQLDesktop.Debugar.TypeDebugPrint("\r End GetDataBaseInitialCatalog");
            return returnInitialCatalog;
        }
        #endregion

        #region ---> ( Get and Set Other )
        /// <summary>
        /// #String SQL Return
        /// </summary>
        public static string GetConnectionSQLString()
        {
            return (StringBuilderSQL_ConnectionString);
        }
        /// <summary>
        /// #Status Connection SQL
        /// </summary>
        /// <returns></returns>
        public static string GetStatusConnectionSQLString()
        {
            return (connectionSQL.State.ToString());
        }
        /// <summary>
        /// #Set String on StringBuild From AppConfig
        /// </summary>
        public static void SetConnectionSQLAppConfig(string stringBuilderSQL)
        {
            SetClearConnectionSQLString();
            StringBuilderSQL_ConnectionString = (stringBuilderSQL);
        }
        /// <summary>
        /// #Clear ALL StringBuilderSQL_ConnectionString
        /// </summary>
        public static void SetClearConnectionSQLString()
        {
            (StringBuilderSQL_ConnectionString) = (String.Empty);
        }
        #endregion
    }
    #endregion
}