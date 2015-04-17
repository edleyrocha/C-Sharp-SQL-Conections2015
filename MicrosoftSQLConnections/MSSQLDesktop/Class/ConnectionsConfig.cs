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
        }
        /// <summary>
        /// #Constructor method(string 7 )
        /// </summary>
        public ConnectionsConfig(string UserID, string Password, string DataSource, string ConnectTimeout, string InitialCatalog, string ConnectionString, string IntegratedSecurity)
        {
            this.userID = (UserID);
            this.password = (Password);
            this.dataSource = (DataSource);
            this.connectTimeout = (ConnectTimeout);
            this.initialCatalog = (InitialCatalog);
            this.connectionString = (ConnectionString);
            this.integratedSecurity = (IntegratedSecurity);
        }
        #endregion
    }
    #endregion
}