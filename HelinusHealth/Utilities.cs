using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace HelinusPingUtility
{
    internal class Utilities
    {
        public string ShowAppVersion()
        {
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(
               System.Reflection.Assembly.GetEntryAssembly().Location);
            return fvi.FileVersion;
        }

        public string ReadSetting()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "\\config.txt"))
                {
                    return sr.ReadLine();
                }
            }
            catch
            {

            }

            return string.Empty;
        }
    }
}
