using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSouls2SaveBackup
{
    class GameSave
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public GameSave()
        {
            string DS2AppDataLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DarkSoulsII";
            if (System.IO.Directory.Exists(DS2AppDataLoc))
            {
                string[] GameSaveLocationsArray = System.IO.Directory.GetFiles(DS2AppDataLoc, "DS2SOFS0000.sl2", System.IO.SearchOption.AllDirectories);
                if (GameSaveLocationsArray.Length != 0)
                {
                    path = GameSaveLocationsArray[0].Replace(@"\DS2SOFS0000.sl2", "");
                }
            }
        }

        public void restore(BackupSave backupSave)
        {
            FileSysManip.copyFile("DS2SOFS0000.sl2",  backupSave.Path + @"\Backups" + backupSave.LatestSaveIndex, this.Path);
        }
    }
}
