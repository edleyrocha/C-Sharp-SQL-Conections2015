using System;

namespace AppStatus
{
    public class Debugar
    {
        private static Boolean AtivarPritDebug = (true);
        /// <summary>
        /// Escreve Status se Debug Ativado
        /// </summary>
        public static void Status()
        {
            if (AtivarPritDebug)
            {
#if (DEBUG)
                System.Diagnostics.Debug.Print("\r \t" + " Status Mode = DEBUG");
#endif
            }
        }
        /// <summary>
        /// Escreve Debug Print
        /// </summary>
        /// <param name="txtEscrever"></param>
        public static void EscreverDebugPrint(String txtEscrever)
        {
            if (AtivarPritDebug)
            {
#if (DEBUG)
                System.Diagnostics.Debug.Print("\r \t" + txtEscrever);
#endif
            }
        }
    }
}
