using System.Data.SqlClient;

namespace MSSQLConnections
{
    /// <summary>
    /// Clase ConnectionsSQLSimples para Conexao Simples
    /// </summary>
    public class ConnectionsSQLModeloA
    {
        #region ---> Metodo Contrutor

        /// <summary>
        /// Metodo Contrutor ConnectionsSQLSimples Simples
        /// </summary>
        public ConnectionsSQLModeloA()
        {

        }

        #endregion ---> Metodo Contrutor

        #region ---> SQL Connection
        /// <summary>
        /// ConnectionSQL Private
        /// </summary>
        private static SqlConnection connectionSQL = new SqlConnection();

        #endregion ---> SQL Connection

        #region ---> String Builder

        /// <summary>
        /// SQL Connection String Builder --> scsBuilder (Static)
        /// </summary>
        private static SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();

        /// <summary>
        /// String Completa de Conexao com Banco de Dados
        /// </summary>
        public static string StringBuilderSQL_ConnectionString
        {
            get { return stringBuilderSQL.ConnectionString; }
            set { stringBuilderSQL.ConnectionString = value; }
        }

        /// <summary>
        /// Tempo de Vida da Conexao
        /// </summary>
        public static int StringBuilderSQL_ConnectTimeout
        {
            get { return stringBuilderSQL.ConnectTimeout; }
            set { stringBuilderSQL.ConnectTimeout = value; }
        }

        /// <summary>
        /// Endereço Servidor SQL - Nome ou IP 
        /// </summary>
        public static string StringBuilderSQL_DataSource
        {
            private get { return stringBuilderSQL.DataSource; }
            set { stringBuilderSQL.DataSource = value; }
        }

        /// <summary>
        /// Nome Banco de Dados
        /// </summary>
        public static string StringBuilderSQL_InitialCatalog
        {
            private get { return stringBuilderSQL.InitialCatalog; }
            set { stringBuilderSQL.InitialCatalog = value; }
        }

        /// <summary>
        /// Tipo de Segurança para Login
        /// </summary>
        public static bool StringBuilderSQL_IntegratedSecurity
        {
            private get { return stringBuilderSQL.IntegratedSecurity; }
            set { stringBuilderSQL.IntegratedSecurity = value; }
        }

        /// <summary>
        /// Login de Usuario para Servidor Banco de Dados
        /// </summary>
        public static string StringBuilderSQL_UserID
        {
            private get { return stringBuilderSQL.UserID; }
            set { stringBuilderSQL.UserID = value; }
        }

        /// <summary>
        /// Senha para Autenticar Servidor Banco de Dados
        /// </summary>
        public static string StringBuilderSQL_Password
        {
            private get { return stringBuilderSQL.Password; }
            set { stringBuilderSQL.Password = value; }
        }

        #endregion ---> String Builder

        #region ---> Funcao de Retorno de Conexao
        /// <summary>
        /// Escolhas Entre ---> FecharConexaoFechado = 0, AbrirConexaoAberto = 1
        /// </summary>
        [System.ComponentModel.DefaultValue(FecharConexaoFechado)]
        public enum EscolhaAcao
        {
            FecharConexaoFechado = 0,
            AbrirConexaoAberto = 1

        }
        /// <summary>
        /// Funcao Conexao SQL Retorno ---> Tuple-> (SqlConnection, int) tuple.Item1 tuple.Item2
        /// </summary>
        /// <param name="AcaoEscolhida"></param>
        /// <returns></returns>
        public static System.Tuple<SqlConnection, int> FU_RetornaConnection(EscolhaAcao AcaoEscolhida)
        {
            try
            {
                switch (AcaoEscolhida)
                {
                    case EscolhaAcao.AbrirConexaoAberto:
                        {
                            connectionSQL.ConnectionString = stringBuilderSQL.ConnectionString;
                            connectionSQL.Open();
                            AcaoEscolhida = EscolhaAcao.AbrirConexaoAberto;
                            AppStatus.Debugar.EscreverDebugPrint("\t SQL Server Conectado...");
                            break;
                        }
                    case EscolhaAcao.FecharConexaoFechado:
                        {
                            connectionSQL.Close();
                            connectionSQL.Dispose();
                            AcaoEscolhida = EscolhaAcao.FecharConexaoFechado;
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
                AcaoEscolhida = EscolhaAcao.FecharConexaoFechado;
                AppStatus.Debugar.EscreverDebugPrint("\t SQL Server " + "[ERRO]" + " Desconectado...");
            }

            return System.Tuple.Create(connectionSQL, (int)AcaoEscolhida);

        }

        #endregion ---> Funcao de Retorno de Conexao
    }
}
