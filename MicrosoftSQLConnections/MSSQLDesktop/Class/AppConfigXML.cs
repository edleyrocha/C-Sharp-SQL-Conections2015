
namespace MSSQLDesktop
{
    #region ---> ( Using )
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Xml;
    #endregion

    #region ---> ( Class )
    class AppConfigXML
    {
        #region ---> ( Fiel )

        #endregion

        #region ---> ( Property )

        #endregion

        #region ---> ( Constructor )
        public AppConfigXML()
        {

        }
        #endregion

        #region --->( List of Tasks )
        /// <summary>
        /// #Task For App.Conf Check File Exist
        /// </summary>
        public void TaskForAppConfCheckFileExist()
        {
            Thread taskCheckAppConf = new Thread(() =>
            {
                if (!File.Exists((Directory.GetCurrentDirectory()) + (@"\App.Config")))
                {
                    XmlDocument AppConfigXML = new XmlDocument();
                    XmlDeclaration xmldecl;
                    xmldecl = AppConfigXML.CreateXmlDeclaration(("1.0"), (Convert.ToString(Encoding.UTF8.WebName)), (String.Empty));
                    AppConfigXML.AppendChild(xmldecl);
                    XmlElement xmlElem = AppConfigXML.CreateElement("configuration");
                    xmlElem.InnerText = (String.Empty);
                    AppConfigXML.AppendChild(xmlElem);
                    AppConfigXML.Save(String.Concat((Directory.GetCurrentDirectory()), (@"\App.Config")));
                }
            });
            MSSQLDesktop.Debugar.TypeDebugPrint("\r Task for Check App.conf = Started");
            taskCheckAppConf.Start();
        }
        #endregion

    }
    #endregion
}
