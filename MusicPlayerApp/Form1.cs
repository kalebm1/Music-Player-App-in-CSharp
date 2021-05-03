using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create global variables of String type array to save the titles or name of the tracks.
        //and the patyh of the track.
        String[] paths, files;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write code to play music.
            WindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to select songs.
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//Save the names of the track in files array
                paths = ofd.FileNames;//Save the path of the track in path array

                //Display the music titles in listbox
                foreach(String i in paths)
                {
                    listBoxSongs.Items.Add(i); //Display songs in list box
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to close the app
            this.Close();
        }
    }
}
