//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

using System.Data.SqlClient;
using System.Data;
using System;

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
        
        /// <summary>
        /// ConnectionSQL Public
        /// </summary>
        //public static SqlConnection ConnectionSQL
        //{
        //    get { return ConnectionsSQLModeloA.connectionSQL; }
        //    set { ConnectionsSQLModeloA.connectionSQL = value; }
        //}

        #endregion ---> SQL Connection

        #region ---> String Builder

        /// <summary>
        /// SQL Connection String Builder --> scsBuilder (Static)
        /// </summary>
        private static SqlConnectionStringBuilder stringBuilderSQL = new SqlConnectionStringBuilder();

        public static string StringBuilderSQL_ConnectionString
        {
            get { return stringBuilderSQL.ConnectionString; }
            set { stringBuilderSQL.ConnectionString = value; }
        }

        public static string StringBuilderSQL_DataSource
        {
            private get { return stringBuilderSQL.DataSource; }
            set { stringBuilderSQL.DataSource = value; }
        }
       
        public static string StringBuilderSQL_InitialCatalog 
        {
            private get { return stringBuilderSQL.InitialCatalog; }
            set { stringBuilderSQL.InitialCatalog = value; }
        }

        public static bool StringBuilderSQL_IntegratedSecurity
        {
            private get { return stringBuilderSQL.IntegratedSecurity; }
            set { stringBuilderSQL.IntegratedSecurity = value; }
        }

        public static string StringBuilderSQL_UserID
        {
            private get { return stringBuilderSQL.UserID; }
            set { stringBuilderSQL.UserID = value; }
        }

        public static string StringBuilderSQL_Password
        {
            private get { return stringBuilderSQL.Password; }
            set { stringBuilderSQL.Password = value; }
        }

        public static int StringBuilderSQL_ConnectTimeout
        {
            private get { return stringBuilderSQL.ConnectTimeout; }
            set { stringBuilderSQL.ConnectTimeout = value; }
        }

        #endregion ---> String Builder

        #region ---> Funcao de Retorno de Conexao
        public enum EscolhaAcao
        {
            AbrirConexao,
            FecharConexao
        }

        public static SqlConnection FU_RetornaConnection(EscolhaAcao AcaoEscolhida)
        {
            switch (AcaoEscolhida)
            {
                case EscolhaAcao.AbrirConexao:
                    {
                        connectionSQL.ConnectionString = StringBuilderSQL_ConnectionString;
                        connectionSQL.Open();
                        break;
                    }
                case EscolhaAcao.FecharConexao:
                    {
                        connectionSQL.Close();
                        connectionSQL.Dispose();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return connectionSQL;
        }
 
        #endregion ---> Funcao de Retorno de Conexao
    }
}
