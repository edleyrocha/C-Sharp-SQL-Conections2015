namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    #endregion

    #region ---> ( Class )
    /// <summary>
    /// #Main Class Program
    /// </summary>
    static class Program
    {
        /// <summary>
        /// #The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region ---> ( Aplication )
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if (DEBUG)
            Application.Run(new frmModel());
#endif
            #endregion
        }
    }
    #endregion
}