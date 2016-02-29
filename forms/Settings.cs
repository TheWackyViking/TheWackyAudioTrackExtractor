using AudioTrackExtractorLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4Extractor_Forms
{
    
    public partial class Settings : Form
    {
        FileController fc = new FileController(Application.StartupPath + "/Settings.txt");
        public Settings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fc.path_FFMPEG_EXE = txtFFMPEG_EXE.Text;
            fc.path_INPUT = txtRecordings.Text;
            fc.path_OUTPUT = txtOutput.Text;
            fc.path_SOURCE = txtSource.Text;
            fc.numAudioTracks = int.Parse(txtAudioTracks.Text);
            if (radioDelete.Checked)
            {
                fc.radio_SOURCE_FILE = 0;
            }
            else if (radioMove.Checked)
            {
                fc.radio_SOURCE_FILE = 1;
            }
            else if (radioKeep.Checked)
            {
                fc.radio_SOURCE_FILE = 2;
            }
            fc.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void radioMove_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMove.Checked)
            {
                txtSource.Enabled = true;
                btnBrowse_Source.Enabled = true;
            }
            else
            {

                txtSource.Enabled = false;
                btnBrowse_Source.Enabled = false;
            }
        }

        private void btnBrowse_FFMPEG_EXE_Click(object sender, EventArgs e)
        {
            //browserFFMPEG.InitialDirectory = fc.path_FFMPEG_EXE.Replace("ffmpeg.exe", "");
            browserFFMPEG.ShowDialog();
            txtFFMPEG_EXE.Text = browserFFMPEG.FileName;
        }

        private void btnBrowse_Recordings_Click(object sender, EventArgs e)
        {
            browserINPUT.ShowDialog();
            txtRecordings.Text = browserINPUT.SelectedPath;
        }

        private void btnBrowse_Output_Click(object sender, EventArgs e)
        {
            browserOUTPUT.ShowDialog();
            txtOutput.Text = browserOUTPUT.SelectedPath;
        }

        private void btnBrowse_Source_Click(object sender, EventArgs e)
        {
            browserSOURCE.ShowDialog();
            txtSource.Text = browserSOURCE.SelectedPath;
        }

        private void btnEditSuffixes_Click(object sender, EventArgs e)
        {
            fc.numAudioTracks = int.Parse(txtAudioTracks.Text);
            fc.Save();
            EditSuffixes editSuffixes = new EditSuffixes();
            editSuffixes.ShowDialog();
            if (editSuffixes.DialogResult == DialogResult.OK)
            {
                // Re-load filecontroller
                LoadSettings();
            }
        }
        private void LoadSettings()
        {
            fc.Load();
            txtFFMPEG_EXE.Text = fc.path_FFMPEG_EXE;
            txtOutput.Text = fc.path_OUTPUT;
            txtRecordings.Text = fc.path_INPUT;
            txtSource.Text = fc.path_SOURCE;
            txtAudioTracks.Text = fc.numAudioTracks.ToString();

            radioDelete.Checked = false;
            radioKeep.Checked = false;
            radioMove.Checked = false;
            txtSource.Enabled = false;
            btnBrowse_Source.Enabled = false;
            switch (fc.radio_SOURCE_FILE)
            {
                case 0:
                    radioDelete.Checked = true;
                    break;
                case 1:
                    radioMove.Checked = true;
                    txtSource.Enabled = true;
                    btnBrowse_Source.Enabled = true;
                    break;
                case 2:
                    radioKeep.Checked = true;
                    break;
            }
        }
    }
}
