namespace DarkSouls2SaveBackup
{
    partial class DS2Backup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backupButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.GameSaveTextBox = new System.Windows.Forms.TextBox();
            this.BackupSaveTextBox = new System.Windows.Forms.TextBox();
            this.chooseGameSaveLocationButton = new System.Windows.Forms.Button();
            this.chooseBackupSaveLocationButton = new System.Windows.Forms.Button();
            this.gameSaveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.backupSaveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Save Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup Save Location";
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(497, 33);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(497, 87);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 3;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // GameSaveTextBox
            // 
            this.GameSaveTextBox.Location = new System.Drawing.Point(28, 36);
            this.GameSaveTextBox.Name = "GameSaveTextBox";
            this.GameSaveTextBox.ReadOnly = true;
            this.GameSaveTextBox.Size = new System.Drawing.Size(343, 20);
            this.GameSaveTextBox.TabIndex = 4;
            // 
            // BackupSaveTextBox
            // 
            this.BackupSaveTextBox.Location = new System.Drawing.Point(28, 90);
            this.BackupSaveTextBox.Name = "BackupSaveTextBox";
            this.BackupSaveTextBox.ReadOnly = true;
            this.BackupSaveTextBox.Size = new System.Drawing.Size(343, 20);
            this.BackupSaveTextBox.TabIndex = 5;
            // 
            // chooseGameSaveLocationButton
            // 
            this.chooseGameSaveLocationButton.Location = new System.Drawing.Point(377, 33);
            this.chooseGameSaveLocationButton.Name = "chooseGameSaveLocationButton";
            this.chooseGameSaveLocationButton.Size = new System.Drawing.Size(26, 23);
            this.chooseGameSaveLocationButton.TabIndex = 6;
            this.chooseGameSaveLocationButton.Text = "...";
            this.chooseGameSaveLocationButton.UseVisualStyleBackColor = true;
            this.chooseGameSaveLocationButton.Click += new System.EventHandler(this.chooseGameSaveLocationButton_Click);
            // 
            // chooseBackupSaveLocationButton
            // 
            this.chooseBackupSaveLocationButton.Location = new System.Drawing.Point(377, 88);
            this.chooseBackupSaveLocationButton.Name = "chooseBackupSaveLocationButton";
            this.chooseBackupSaveLocationButton.Size = new System.Drawing.Size(26, 23);
            this.chooseBackupSaveLocationButton.TabIndex = 7;
            this.chooseBackupSaveLocationButton.Text = "...";
            this.chooseBackupSaveLocationButton.UseVisualStyleBackColor = true;
            this.chooseBackupSaveLocationButton.Click += new System.EventHandler(this.chooseBackupSaveLocationButton_Click);
            // 
            // DS2Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 148);
            this.Controls.Add(this.chooseBackupSaveLocationButton);
            this.Controls.Add(this.chooseGameSaveLocationButton);
            this.Controls.Add(this.BackupSaveTextBox);
            this.Controls.Add(this.GameSaveTextBox);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DS2Backup";
            this.Text = "Dark Souls 2 Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DS2Backup_FormClosing);
            this.Shown += new System.EventHandler(this.DS2Backup_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.TextBox GameSaveTextBox;
        private System.Windows.Forms.TextBox BackupSaveTextBox;
        private System.Windows.Forms.Button chooseGameSaveLocationButton;
        private System.Windows.Forms.Button chooseBackupSaveLocationButton;
        private System.Windows.Forms.FolderBrowserDialog gameSaveFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog backupSaveFolderBrowser;
    }
}

