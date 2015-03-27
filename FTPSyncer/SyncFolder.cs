using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPSyncer
{
    public enum Protocol
    {
        FTP,
        SFTP,
        FTPS
    }

    public class SyncFolder
    {
        public String LocalPath {get;set;}
        public String ServerPath { get; set; }

        public String Server { get; set; }
        public int Port { get; set; }
        public Protocol Protocol { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String CertFile { get; set; }


        //Sync mode (Manuel,daley,..)
        //Check mode (On Sync,Manuel,daley,..)
        public DateTime LastSync { get; set; }
        public DateTime lastChangeCheck { get; set; }

    }
}
