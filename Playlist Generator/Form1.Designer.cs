namespace Playlist_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NumUpDown_SongNr = new System.Windows.Forms.NumericUpDown();
            this.Butt_SelSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_RefreshFilename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_SongNr)).BeginInit();
            this.SuspendLayout();
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(12, 12);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(518, 47);
            this.but_save.TabIndex = 0;
            this.but_save.Text = "Save Playlist to";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // NumUpDown_SongNr
            // 
            this.NumUpDown_SongNr.Location = new System.Drawing.Point(12, 72);
            this.NumUpDown_SongNr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDown_SongNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_SongNr.Name = "NumUpDown_SongNr";
            this.NumUpDown_SongNr.Size = new System.Drawing.Size(120, 31);
            this.NumUpDown_SongNr.TabIndex = 1;
            this.NumUpDown_SongNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDown_SongNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_SongNr.ValueChanged += new System.EventHandler(this.NumUpDown_SongNr_ValueChanged);
            // 
            // Butt_SelSong
            // 
            this.Butt_SelSong.Location = new System.Drawing.Point(138, 65);
            this.Butt_SelSong.Name = "Butt_SelSong";
            this.Butt_SelSong.Size = new System.Drawing.Size(392, 43);
            this.Butt_SelSong.TabIndex = 2;
            this.Butt_SelSong.Text = "Select Song";
            this.Butt_SelSong.UseVisualStyleBackColor = true;
            this.Butt_SelSong.Click += new System.EventHandler(this.Butt_SelSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "No File Selected";
            // 
            // Butt_RefreshFilename
            // 
            this.Butt_RefreshFilename.Location = new System.Drawing.Point(17, 175);
            this.Butt_RefreshFilename.Name = "Butt_RefreshFilename";
            this.Butt_RefreshFilename.Size = new System.Drawing.Size(513, 59);
            this.Butt_RefreshFilename.TabIndex = 4;
            this.Butt_RefreshFilename.Text = "Refresh Filename";
            this.Butt_RefreshFilename.UseVisualStyleBackColor = true;
            this.Butt_RefreshFilename.Click += new System.EventHandler(this.Butt_RefreshFilename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 246);
            this.Controls.Add(this.Butt_RefreshFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_SelSong);
            this.Controls.Add(this.NumUpDown_SongNr);
            this.Controls.Add(this.but_save);
            this.Name = "Form1";
            this.Text = "Playlist Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_SongNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown NumUpDown_SongNr;
        private System.Windows.Forms.Button Butt_SelSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_RefreshFilename;
    }
}

