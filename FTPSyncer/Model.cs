using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FTPSyncer
{
    class Model
    {
        public List<SyncFolder> listSyncFolder { get; set; }

        public Model()
        {
            listSyncFolder = new List<SyncFolder>();
        }


        public void addSyncFolder(SyncFolder sf)
        {
            listSyncFolder.Add(sf);
        }

        public void removeSyncFolder(SyncFolder sf)
        {
            listSyncFolder.Remove(sf);
        }

        public void save(String filename)
        {

            FileStream f = null;
            try
            {
                f = File.Create(filename);
                XmlSerializer s = new XmlSerializer(listSyncFolder.GetType());
                s.Serialize(f, listSyncFolder);
            }
            catch (IOException e)
            {
                Logger.log("Could not save Syncfolders: " + e.Message);
            }
            finally
            {
                if (f != null)
                    f.Close();
            }
        }

        public void load(String filename)
        {
            FileStream f = null;
            try
            {
                f = File.OpenRead(filename);
                XmlSerializer s = new XmlSerializer(listSyncFolder.GetType());
                listSyncFolder = (List<SyncFolder>)s.Deserialize(f);
            }
            catch (Exception e)
            {
                Logger.log("Could not open saved Syncfolders: " + e.Message);
            }
            finally
            {
                if (f != null)
                    f.Close();
            }
        }

        public List<SyncFolder> getAll()
        {
            return listSyncFolder;
        }

    }
}
