using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPSyncer
{
    class Logger
    {
        
        private static string logFile=String.Format("{0}log-{1:yy-MM-dd}.xml",Properties.Settings.Default["LogPath"],DateTime.Now);

        public static void log(String lines)
        {
            Console.Write(lines);
            System.IO.StreamWriter file = new System.IO.StreamWriter(logFile, true);
            file.WriteLine(String.Format("{0:HH:mm:ss} {1}", DateTime.Now,lines));
            file.Close();
        }

        public static void debug(String lines)
        {
            log(lines);
        }

        public static void error(String lines)
        {
            log(lines);
        }
    }
}
