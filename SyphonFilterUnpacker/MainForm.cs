using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SyphonFilterUnpacker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private string[] FOGUnpackFiles, HOGUnpackFiles;
        private string FOGRepackFile, FOGRepackSave, HOGRepackFile, HOGRepackSave;



        private void repackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();

            ofd2.Filter = "Assembly.xml|Assembly.xml";


            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog save = new FolderBrowserDialog();

                if (save.ShowDialog() == DialogResult.OK)
                {
                    FOG fog = new FOG(ofd2.FileName);
                    fog.Repack(save.SelectedPath);
                    MessageBox.Show("Successfully Repacked!");
                }

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUnpackOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Filter = "FOG|*.FOG";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FOGUnpackFiles = ofd.FileNames;
                    foreach (string s in ofd.FileNames)
                    {
                        txtUnpackOpenPath.Text += Path.GetFileName(s) + " | ";
                    }
                }
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            if (FOGUnpackFiles == null || FOGUnpackFiles.Length <= 0)
            {
                MessageBox.Show("Select a file to Unpack!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FOG fog;
            foreach (string name in FOGUnpackFiles)
            {
               
                fog = new FOG(name);
                fog.setAtt(ref ssPB, ref ssLblStat);


                if (chBoxUnpack.Checked)
                    fog.UnpackHOG = true;

                fog.Unpack();
            }
             MessageBox.Show("Sucefully Unpacked!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             CleanFOGUnpack();
        }

        private void btnFOGRepackOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "FOGInfo.xml|FOGInfo.xml";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FOGRepackFile = ofd.FileName;
                    txtFOGRepackOpen.Text = Path.GetDirectoryName(ofd.FileName);
                }
            }
        }

        private void btnFOGUnpackSave_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    FOGRepackSave = fbd.SelectedPath;
                    txtFOGSaveRepack.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnFOGRepack_Click(object sender, EventArgs e)
        {

            if (FOGRepackFile == String.Empty || FOGRepackFile == null)
            {
                MessageBox.Show("Select a file to Repack!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (FOGRepackSave == String.Empty || FOGRepackSave == null)
            {
                MessageBox.Show("Select a folder to save the file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FOG fog = new FOG(FOGRepackFile);
            if (chBoxRepack.Checked)
                fog.RepackHOG = true;

            fog.setAtt(ref ssPB, ref ssLblStat);
            fog.Repack(FOGRepackSave);

            MessageBox.Show("Sucefully Repacked!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            CleanFOGRepack();
            
        }

        private void btnHOGUnpackOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "HOG|*.HOG";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    HOGUnpackFiles = ofd.FileNames;
                    foreach(string s in ofd.FileNames)
                    {
                        txtHOGUnpackOpen.Text += Path.GetFileName(s) + " | ";
                    }
                }
            }
        }

        private void btnHOGUnpack_Click(object sender, EventArgs e)
        {
            if (HOGUnpackFiles == null || HOGUnpackFiles.Length <= 0)
            {
                MessageBox.Show("Select a file to Unpack!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HOG hog;
            foreach (string s in HOGUnpackFiles)
            {
                hog = new HOG(s);
                hog.Unpack();
            }
            MessageBox.Show("Sucefully Unpacked!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            CleanHOGUnpack();
        }

        private void btnHOGRepackOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "HOGInfo.xml|HOGInfo.xml";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    HOGRepackFile = ofd.FileName;
                    txtHOGRepackOpen.Text = Path.GetDirectoryName(ofd.FileName);
                }
            }
        }

        private void btnHOGRepack_Click(object sender, EventArgs e)
        {
            if (HOGRepackFile == String.Empty || HOGRepackFile == null)
            {
                MessageBox.Show("Select a file to Repack!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (HOGRepackSave == String.Empty || HOGRepackSave == null)
            {
                MessageBox.Show("Select a folder to save the file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HOG hog = new HOG(HOGRepackFile);
            hog.Repack(HOGRepackSave);

            MessageBox.Show("Sucefully Repacked!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            CleanHOGRepack();
        }

        private void btnHOGRepackSave_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    HOGRepackSave = fbd.SelectedPath;
                    txtHOGRepackSave.Text = fbd.SelectedPath;
                }
            }
        }


        private void CleanHOGUnpack()
        {
            HOGUnpackFiles = null;
            txtHOGUnpackOpen.Text = String.Empty;
        }

        private void CleanHOGRepack()
        {
            HOGRepackSave = HOGRepackFile = txtHOGRepackOpen.Text = txtHOGRepackSave.Text = String.Empty;
        }


        private void CleanFOGUnpack()
        {
            FOGUnpackFiles = null;
            txtUnpackOpenPath.Text = String.Empty;
            chBoxUnpack.Checked = false;
        }

        private void CleanFOGRepack()
        {
            FOGRepackSave = FOGRepackFile = txtFOGRepackOpen.Text = txtFOGSaveRepack.Text = String.Empty;
            chBoxRepack.Checked = false;
        }

    }
}
