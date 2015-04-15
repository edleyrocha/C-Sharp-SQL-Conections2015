namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    #endregion

    #region ---> ( Class )
    /// <summary>
    /// #Class ConnectionsXML
    /// </summary>
    class ConnectionsXML
    {
        #region ---> ( Fiel )
        public string UserID { get; set; }
        public string Password { get; set; }
        public string DataSource { get; set; }
        public string ConnectTimeout { get; set; }
        public string InitialCatalog { get; set; }
        public string ConnectionString { get; set; }
        public string IntegratedSecurity { get; set; }
        #endregion

        #region ---> ( Constructor )
        /// <summary>
        /// #Constructor method(simple)
        /// </summary>
        public ConnectionsXML()
        {
            this.UserID = (String.Empty);
            this.Password = (String.Empty);
            this.DataSource = (String.Empty);
            this.ConnectTimeout = (String.Empty);
            this.InitialCatalog = (String.Empty);
            this.ConnectionString = (String.Empty);
            this.IntegratedSecurity = (String.Empty);
        }
        /// <summary>
        /// #Constructor method(string 7 )
        /// </summary>
        public ConnectionsXML(string UserID, string Password, string DataSource, string ConnectTimeout, string InitialCatalog, string ConnectionString, string IntegratedSecurity)
        {
            this.UserID = (UserID);
            this.Password = (Password);
            this.DataSource = (DataSource);
            this.ConnectTimeout = (ConnectTimeout);
            this.InitialCatalog = (InitialCatalog);
            this.ConnectionString = (ConnectionString);
            this.IntegratedSecurity = (IntegratedSecurity);
        }
        #endregion
    }
    #endregion
}