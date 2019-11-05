using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Playlist_Generator
{
    public partial class Form1 : Form
    {
        //declaring the variable that stores all paths
        string[] PathNames = new string[] { };

        public Form1()
        {
            InitializeComponent();
            //resizing variable to fit our needs
            Array.Resize(ref PathNames, 10000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Butt_SelSong_Click(object sender, EventArgs e)
        {
            //Filtering and opening Dialogue to select file
            openFileDialog1.Filter = "Soundfiles *.mp3 | *.mp3| Soundfiles *.ogg | *.ogg| Soundfiles *.wav | *.wav";
            openFileDialog1.ShowDialog();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            //Filtering and opening Dialogue to save file
            saveFileDialog1.Filter = "Platlist files *.m3u | *.m3u";
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //setting the PathNames at the place of the current position to our filename
            PathNames[(int)NumUpDown_SongNr.Value-1] = openFileDialog1.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //disabling Buttons for safety
            Butt_SelSong.Enabled = false;
            but_save.Enabled = false;
            NumUpDown_SongNr.Enabled = false;

            //CreatingFile, Writing the song paths, deleting useless lines
            File.Create(saveFileDialog1.FileName).Close();
            File.WriteAllLines(saveFileDialog1.FileName, PathNames);
            File.WriteAllLines(saveFileDialog1.FileName, File.ReadAllLines(saveFileDialog1.FileName).Where(l => !string.IsNullOrWhiteSpace(l)));

            //re-enabling Buttons
            Butt_SelSong.Enabled = true;
            but_save.Enabled = true;
            NumUpDown_SongNr.Enabled = true;
            
        }

        private void NumUpDown_SongNr_ValueChanged(object sender, EventArgs e)
        {
            //Refreshing Song Names
            label1.Text = Path.GetFileName(PathNames[(int)NumUpDown_SongNr.Value - 1]);
        }

        private void Butt_RefreshFilename_Click(object sender, EventArgs e)
        {
            //Refreshing Song Names
            label1.Text = Path.GetFileName(PathNames[(int)NumUpDown_SongNr.Value - 1]);
        }
    }
}
