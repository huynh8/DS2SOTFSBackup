using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSouls2SaveBackup
{
    public partial class DS2Backup : Form
    {
        private GameSave gameSave;
        private BackupSave backupSave;
        private bool backingUp;

        public DS2Backup()
        {
            InitializeComponent();
        }

        private void DS2Backup_Shown(object sender, EventArgs e)
        {
            backingUp = false;
            gameSave = new GameSave();
            backupSave = new BackupSave();

            GameSaveTextBox.Text = gameSave.Path;
            BackupSaveTextBox.Text = backupSave.Path;
        }

        private void chooseGameSaveLocationButton_Click(object sender, EventArgs e)
        {
            if(gameSaveFolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gameSave.Path = gameSaveFolderBrowser.SelectedPath;
            }

            GameSaveTextBox.Text = gameSave.Path;

        }

        private void chooseBackupSaveLocationButton_Click(object sender, EventArgs e)
        {
            if (backupSaveFolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                backupSave.Path = backupSaveFolderBrowser.SelectedPath;
            }

            BackupSaveTextBox.Text = backupSave.Path;
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(gameSave.Path) && System.IO.Directory.Exists(backupSave.Path))
            {
                backupSave.backup(gameSave);
                MessageBox.Show("Backup Complete");
            }
            else if (!System.IO.Directory.Exists(gameSave.Path))
            {
                MessageBox.Show("Game Save Location Not Found");
            }
            else if (!System.IO.Directory.Exists(backupSave.Path))
            {
                MessageBox.Show("Backup Save Location Not Found");
            }
            else
            {
                MessageBox.Show("Game Save Location and Backup Save Location Not Found");
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(gameSave.Path) && System.IO.Directory.Exists(backupSave.Path))
            {
                gameSave.restore(backupSave);
                MessageBox.Show("Restore Complete");
            }
            else if (!System.IO.Directory.Exists(gameSave.Path))
            {
                MessageBox.Show("Game Save Location Not Found");
            }
            else if (!System.IO.Directory.Exists(backupSave.Path))
            {
                MessageBox.Show("Backup Save Location Not Found");
            }
            else
            {
                MessageBox.Show("Game Save Location and Backup Save Location Not Found");
            }
        }

        private void DS2Backup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.numberOfBackupSaves = backupSave.NumBackupSaves;
            Properties.Settings.Default.backupSaveLocation = backupSave.Path;
            Properties.Settings.Default.Save();
        }
    }
}
