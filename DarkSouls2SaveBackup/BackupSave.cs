using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSouls2SaveBackup
{
    class BackupSave
    {
        private string path;
        private int numBackupSaves;
        private int latestSaveIndex;
        private readonly int MAX_BACKUP_SAVES = 10;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public int NumBackupSaves
        {
            get { return numBackupSaves; }
            set { numBackupSaves = value; }
        }

        public int LatestSaveIndex
        {
            get { return latestSaveIndex; }
            set { latestSaveIndex = value; }
        }


        public BackupSave()
        {
            if(Properties.Settings.Default.backupSaveLocation == "")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            else
            {
                path = Properties.Settings.Default.backupSaveLocation;
            }
            numBackupSaves = Properties.Settings.Default.numberOfBackupSaves;
        }

        public void backup(GameSave gameSave) 
        {
            if (!System.IO.Directory.Exists(this.path + @"\Backups"))
            {
                System.IO.Directory.CreateDirectory(this.path + @"\Backups");
            }

            if(numBackupSaves == MAX_BACKUP_SAVES)
            {
                numBackupSaves = 1;
                latestSaveIndex = numBackupSaves;
            }
            else
            {
                latestSaveIndex = numBackupSaves++;
            }

            FileSysManip.copyFile("DS2SOFS0000.sl2", gameSave.Path, this.Path + @"\Backups" + @"\" + numBackupSaves);
        }
    }
}
