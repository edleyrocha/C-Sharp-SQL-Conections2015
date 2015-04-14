namespace MSSQLConnections
{
    #region ---> ( Using )
    //using System.Data.SqlClient;
    #endregion
    /// <summary>
    /// Class ConnectionsSQL Simple to Conexao Simple
    /// </summary>
    public class ConnectionsSQLModelA
    {
        #region --->( Constructor )
        /// <summary>
        /// Method constructor ConnectionsSQL Simple Simple
        /// </summary>
        public ConnectionsSQLModelA()
        {
        }
        #endregion ---> Metodo Contrutor

        #region ---> ( SQL Connection )
        /// <summary>
        /// ConnectionSQL Private
        /// </summary>
        private static System.Data.SqlClient.SqlConnection connectionSQL = new System.Data.SqlClient.SqlConnection();
        #endregion ---> SQL Connection

        #region ---> ( String Builder )
        /// <summary>
        /// SQL Connection String Builder --> scsBuilder (Static)
        /// </summary>
        private static System.Data.SqlClient.SqlConnectionStringBuilder stringBuilderSQL = new System.Data.SqlClient.SqlConnectionStringBuilder();
        /// <summary>
        /// Complete String Connection with Database
        /// </summary>
        public static string StringBuilderSQL_ConnectionString
        {
            get { return stringBuilderSQL.ConnectionString; }
            set { stringBuilderSQL.ConnectionString = value; }
        }
        /// <summary>
        /// TimeOut Connection
        /// </summary>
        public static int StringBuilderSQL_ConnectTimeout
        {
            get { return stringBuilderSQL.ConnectTimeout; }
            set { stringBuilderSQL.ConnectTimeout = value; }
        }
        /// <summary>
        /// Address Server SQL - Name/IP 
        /// </summary>
        public static string StringBuilderSQL_DataSource
        {
            private get { return stringBuilderSQL.DataSource; }
            set { stringBuilderSQL.DataSource = value; }
        }
        /// <summary>
        /// Name DataBase
        /// </summary>
        public static string StringBuilderSQL_InitialCatalog
        {
            private get { return stringBuilderSQL.InitialCatalog; }
            set { stringBuilderSQL.InitialCatalog = value; }
        }
        /// <summary>
        /// Security Type
        /// </summary>
        public static bool StringBuilderSQL_IntegratedSecurity
        {
            private get { return stringBuilderSQL.IntegratedSecurity; }
            set { stringBuilderSQL.IntegratedSecurity = value; }
        }
        /// <summary>
        /// User ID Login
        /// </summary>
        public static string StringBuilderSQL_UserID
        {
            private get { return stringBuilderSQL.UserID; }
            set { stringBuilderSQL.UserID = value; }
        }

        /// <summary>
        /// Password for SQL Server
        /// </summary>
        public static string StringBuilderSQL_Password
        {
            private get { return stringBuilderSQL.Password; }
            set { stringBuilderSQL.Password = value; }
        }

        #endregion ---> String Builder

        #region ---> ( Connection Returne )
        /// <summary>
        /// Escolhas Entre ---> ConnectionClose = 0, ConnectionOpen = 1
        /// </summary>
        [System.ComponentModel.DefaultValue(ConnectionClose)]
        public enum EscolhaAcao
        {
            ConnectionClose = 0,
            ConnectionOpen = 1
        }
        /// <summary>
        /// SQL function Connection Return--> Tuple-> (SqlConnection, int) tuple.Item1 tuple.Item2
        /// </summary>
        /// <param name="AcaoEscolhida"></param>
        /// <returns></returns>
        public static System.Tuple<System.Data.SqlClient.SqlConnection, int> FU_RetornaConnection(EscolhaAcao AcaoEscolhida)
        {
            try
            {
                switch (AcaoEscolhida)
                {
                    case EscolhaAcao.ConnectionOpen:
                        {
                            connectionSQL.ConnectionString = stringBuilderSQL.ConnectionString;
                            connectionSQL.Open();
                            AcaoEscolhida = EscolhaAcao.ConnectionOpen;
                            AppStatus.Debugar.EscreverDebugPrint("\t SQL Server Conectado...");
                            break;
                        }
                    case EscolhaAcao.ConnectionClose:
                        {
                            connectionSQL.Close();
                            connectionSQL.Dispose();
                            AcaoEscolhida = EscolhaAcao.ConnectionClose;
                            AppStatus.Debugar.EscreverDebugPrint("\t SQL Server Desconectado...");
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
                AcaoEscolhida = EscolhaAcao.ConnectionClose;
                AppStatus.Debugar.EscreverDebugPrint("\t SQL Server " + "[ERRO]" + " Desconectado...");
            }
            return System.Tuple.Create(connectionSQL, (int)AcaoEscolhida);
        }
        #endregion
    }
}