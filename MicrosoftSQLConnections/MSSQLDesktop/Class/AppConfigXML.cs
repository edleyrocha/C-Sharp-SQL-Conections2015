
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
    using System.Windows.Forms;
    using System.Configuration;
    using MSSQLDesktop.Properties;
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
                    XmlDocument appConfigXML = new XmlDocument();
                    XmlDeclaration xmlDeclaration;
                    xmlDeclaration = appConfigXML.CreateXmlDeclaration(("1.0"), (Convert.ToString(Encoding.UTF8.WebName)), (String.Empty));
                    appConfigXML.AppendChild(xmlDeclaration);
                    XmlElement xmlElement = appConfigXML.CreateElement("configuration");
                    xmlElement.InnerText = (String.Empty);
                    appConfigXML.AppendChild(xmlElement);
                    appConfigXML.Save(String.Concat((Directory.GetCurrentDirectory()), (@"\App.Config")));
                }
            });
            MSSQLDesktop.Debugar.TypeDebugPrint("\r Task for Check App.conf = Started");
            taskCheckAppConf.Start();
        }

        /// <summary>
        /// Save String for stringConnectionsSQLModelA
        /// </summary>
        /// <param name="KeyValue"></param>
        public void EditAppConfigFileConnectionsString(string KeyValue)
        {
            //Properties.Settings.Default.stringConnectionsSQLModelA = (KeyValue);
            //Properties.Settings.Default.Save();
        }
        #endregion

    }
    #endregion
}
