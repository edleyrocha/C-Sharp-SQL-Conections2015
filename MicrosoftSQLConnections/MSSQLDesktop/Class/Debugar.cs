namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    #endregion

    #region ---> ( Class )
    /// <summary>
    /// # Debugar Class
    /// </summary>
    public class Debugar
    {
        #region ---> ( Debig Enable Disable )
        /// <summary>
        /// #To Enable or Disable posts Code in DEBUG mode
        /// </summary>
        private static Boolean EnableDisablePritDebug = (true);
        #endregion

        #region ---> ( Print Status Debug )
        /// <summary>
        /// #Write Status if Debug Enabled
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

        #region ---> ( Print Text Debug )
        /// <summary>
        /// #Write Debug TxT
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
    #endregion
}