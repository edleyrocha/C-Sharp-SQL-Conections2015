namespace MSSQLDesktop
{
    #region ---> (Using)
    using System;
    #endregion
    public class Debugar
    {
        #region ---> (Debig Enable Disable)
        /// <summary>
        /// To Enable or Disable posts Code in DEBUG mode
        /// </summary>
        private static Boolean EnableDisablePritDebug = (true);
        #endregion

        #region ---> (Print Status Debig)
        /// <summary>
        /// Write Status if Debug Enabled
        /// </summary>
        public static void Status()
        {
            if (EnableDisablePritDebug)
            {
#if (DEBUG)
                System.Diagnostics.Debug.Print("\r \t" + " Status Mode = DEBUG");
#endif
            }
        }
        #endregion ---> ( Function Write TxT )

        #region
        /// <summary>
        /// Write Debug TxT
        /// </summary>
        /// <param name="txtWrite"></param>
        public static void TypeDebugPrint(String txtWrite)
        {
            if (EnableDisablePritDebug)
            {
#if (DEBUG)
                System.Diagnostics.Debug.Print("\r \t" + txtWrite);
#endif
            }
        }
        #endregion
    }
}