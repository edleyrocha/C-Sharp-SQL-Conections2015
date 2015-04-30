namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    #endregion

    #region ---> ( Class )
    /// <summary>
    /// #Class ConnectionsConfig
    /// </summary>
    class ConnectionsConfig
    {
        #region ---> ( Fiel )
        private string userID;
        private string password;
        private string dataSource;
        private string connectTimeout;
        private string initialCatalog;
        private string connectionString;
        private string integratedSecurity;
        private string persistSecurityInfo;
        #endregion

        #region ---> ( Property )
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        public string ConnectTimeout
        {
            get { return connectTimeout; }
            set { connectTimeout = value; }
        }
        public string InitialCatalog
        {
            get { return initialCatalog; }
            set { initialCatalog = value; }
        }
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public string IntegratedSecurity
        {
            get { return integratedSecurity; }
            set { integratedSecurity = value; }
        }
        public string PersistSecurityInfo
        {
            get { return persistSecurityInfo; }
            set { persistSecurityInfo = value; }
        }
        #endregion

        #region ---> ( Constructor )
        /// <summary>
        /// #Constructor method(simple)
        /// </summary>
        public ConnectionsConfig()
        {
            this.userID = (String.Empty);
            this.password = (String.Empty);
            this.dataSource = (String.Empty);
            this.connectTimeout = (String.Empty);
            this.initialCatalog = (String.Empty);
            this.connectionString = (String.Empty);
            this.integratedSecurity = (String.Empty);
            this.persistSecurityInfo = (String.Empty);
        }
        /// <summary>
        /// #Constructor method(DB Windows Local * 4)
        /// </summary>
        public ConnectionsConfig(string DataSource, string InitialCatalog, string IntegratedSecurity, string ConnectTimeout)
        {
            this.dataSource = (DataSource);
            this.initialCatalog = (InitialCatalog);
            this.integratedSecurity = (IntegratedSecurity);
            this.connectionString = (ConnectTimeout);
            SetWindowsLocalForConnectionsSQL();
        }
        /// <summary>
        /// #Constructor method(DB Server SQL * 5)
        /// </summary>
        public ConnectionsConfig(string UserID, string Password, string DataSource, string InitialCatalog, string ConnectTimeout)
        {
            this.userID = (UserID);
            this.password = (Password);
            this.dataSource = (DataSource);
            this.initialCatalog = (InitialCatalog);
            this.connectionString = (ConnectTimeout);
            SetServerSQLForConnectionsSQL();
        }
        /// <summary>
        /// #Set For Windows Local 
        /// </summary>
        private void SetWindowsLocalForConnectionsSQL()
        {
            ConnectionsSQL.SetClearConnectionSQLString();
            ConnectionsSQL.StringBuilderSQL_DataSource = (this.DataSource);
            ConnectionsSQL.StringBuilderSQL_InitialCatalog = (this.InitialCatalog);
            ConnectionsSQL.StringBuilderSQL_IntegratedSecurity = (Convert.ToBoolean(this.IntegratedSecurity));
            if (!(string.IsNullOrEmpty(this.ConnectionString)))
            {
                ConnectionsSQL.StringBuilderSQL_ConnectTimeout = (Convert.ToInt32(this.ConnectionString));
            }
        }
        /// <summary>
        /// /// #Set For Server SQL 
        /// </summary>
        private void SetServerSQLForConnectionsSQL()
        {
            ConnectionsSQL.SetClearConnectionSQLString();
            ConnectionsSQL.StringBuilderSQL_UserID = (this.UserID);
            ConnectionsSQL.StringBuilderSQL_Password = (this.Password);
            ConnectionsSQL.StringBuilderSQL_DataSource = (this.DataSource);
            ConnectionsSQL.StringBuilderSQL_InitialCatalog = (this.InitialCatalog);
          if (!(string.IsNullOrEmpty(this.ConnectionString)))
          {
              ConnectionsSQL.StringBuilderSQL_ConnectTimeout = (Convert.ToInt32(this.ConnectionString));
          }
        }
        #endregion
    }
    #endregion
}