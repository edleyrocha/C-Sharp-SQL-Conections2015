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
    public class ConnectionsSQLModelA
    {
        #region --->( Constructor )
        /// <summary>
        /// #Method Constructor ConnectionsSQL Simple
        /// </summary>
        public ConnectionsSQLModelA()
        {
        }
        #endregion ---> Metodo Contrutor

        #region ---> ( SQL Connection )
        /// <summary>
        /// #ConnectionSQL Private
        /// </summary>
        private static SqlConnection connectionSQL = new SqlConnection();
        #endregion ---> SQL Connection

        #region ---> ( String Builder )
        /// <summary>
        /// #SQL Connection String Builder --> scsBuilder (Static)
        /// </summary>
        private static SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();
        /// <summary>
        /// #Complete String Connection with Database
        /// </summary>
        public static string StringBuilderSQL_ConnectionString
        {
            get { return stringBuilderSQL.ConnectionString; }
            set { stringBuilderSQL.ConnectionString = value; }
        }
        /// <summary>
        /// #TimeOut Connection
        /// </summary>
        public static int StringBuilderSQL_ConnectTimeout
        {
            get { return stringBuilderSQL.ConnectTimeout; }
            set { stringBuilderSQL.ConnectTimeout = value; }
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
        /// #Name DataBase
        /// </summary>
        public static string StringBuilderSQL_InitialCatalog
        {
            private get { return stringBuilderSQL.InitialCatalog; }
            set { stringBuilderSQL.InitialCatalog = value; }
        }
        /// <summary>
        /// #Security Type
        /// </summary>
        public static bool StringBuilderSQL_IntegratedSecurity
        {
            private get { return stringBuilderSQL.IntegratedSecurity; }
            set { stringBuilderSQL.IntegratedSecurity = value; }
        }
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
        #endregion ---> String Builder

        #region ---> ( Connection Returne )
        /// <summary>
        /// #Choices ---> ConnectionClose = 0, ConnectionOpen = 1
        /// </summary>
        [DefaultValue(ConnectionClose)]
        public enum choicesAction
        {
            ConnectionClose = 0,
            ConnectionOpen = 1
        }
        /// <summary>
        /// #SQL function Connection Return--> Tuple-> (SqlConnection, int) tuple.Item1 tuple.Item2
        /// </summary>
        public static Tuple<System.Data.SqlClient.SqlConnection, int> ReturnConnection(choicesAction ActionChosen)
        {
            try
            {
                switch (ActionChosen)
                {
                    case choicesAction.ConnectionOpen:
                        {
                            connectionSQL.ConnectionString = stringBuilderSQL.ConnectionString;
                            connectionSQL.Open();
                            ActionChosen = choicesAction.ConnectionOpen;
                            MSSQLDesktop.Debugar.TypeDebugPrint("\t SQL Server Online...");
                            break;
                        }
                    case choicesAction.ConnectionClose:
                        {
                            connectionSQL.Close();
                            connectionSQL.Dispose();
                            ActionChosen = choicesAction.ConnectionClose;
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
                ActionChosen = choicesAction.ConnectionClose;
                MSSQLDesktop.Debugar.TypeDebugPrint("\t SQL Server " + "[ERRO]" + " Offline...");
            }
            return Tuple.Create(connectionSQL, (int)ActionChosen);
        }
        #endregion
    }
    #endregion
}