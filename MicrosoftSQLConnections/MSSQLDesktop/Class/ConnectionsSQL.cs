namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.ComponentModel;
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

        #region ---> ( Connection and String Returne )

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
        public static Tuple<SqlConnection, int> ReturnConnectionSQL(choiceActions ActionChosen)
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
        /// <summary>
        /// #String SQL Return
        /// </summary>
        public static string ReturnConnectionSQLString()
        {
            return (StringBuilderSQL_ConnectionString);
        }
        /// <summary>
        /// #Clear ALL StringBuilderSQL_ConnectionString
        /// </summary>
        public static void ClearConnectionSQLString()
        {
           (StringBuilderSQL_ConnectionString) = (String.Empty);
        }
        public static string StatusConnectionSQLString()
        {
            return (connectionSQL.State.ToString());
        }
        #endregion
    }
    #endregion
}