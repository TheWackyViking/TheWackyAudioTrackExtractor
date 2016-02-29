using AudioTrackExtractorLibs;
using TheWackyAudioTrackExtractor.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWackyAudioTrackExtractor
{
    public partial class MainWindow : Form
    {
        FileController fc = new FileController(Application.StartupPath + "/Settings.txt");
        List<FileInfo> all_files_in_folder = new List<FileInfo>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            if (settings.DialogResult == DialogResult.OK)
            {

                txtFolderInput.Text = fc.path_INPUT;
                txtFolderOutput.Text = fc.path_OUTPUT;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            fc.Load();
            txtFolderInput.Text = fc.path_INPUT;
            txtFolderOutput.Text = fc.path_OUTPUT;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PrintLn("Starting process...");
            // Setup extraction 
            LoadFilesFromInputFolder(fc.path_INPUT); // Loads fileinfo into the list which holds all files in directory

            // Do extraction here
            if (!File.Exists(fc.path_FFMPEG_EXE))
            {
                PrintLn("Error 1 - FFMPEG file does not exist. Aborting...");
                return;
            }
            PrintLn("FFMPEG file found!");
            FFMPEG_Controller ffmpeg = new FFMPEG_Controller(fc.path_FFMPEG_EXE);
            foreach(FileInfo f in all_files_in_folder)
            {
                PrintLn("Extracting from file: " + f.Name);
                string output = fc.path_OUTPUT + "\\" + f.Name.Replace(f.Extension, "\\");
                if (!Directory.Exists(output))
                {
                    Directory.CreateDirectory(output);
                }
                if(!(output.EndsWith("\\") || output.EndsWith("/")))
                {
                    //MessageBox.Show("Output does NOT end with / or \\");
                    output += "\\";
                }
                for(int i = 0; i < fc.numAudioTracks; i++) 
                {
                    if (ffmpeg.Extract(f, output, i, fc.suffixes[i]) == 1)
                    {
                        PrintLn(String.Format("Extracted audio track({0}, {1}) successfully!", i+1, f.Name.Replace(f.Extension, "") + fc.suffixes[i]));
                    }
                    else
                    {
                        PrintLn("Extraction failed.");
                    }
                }
                switch (fc.radio_SOURCE_FILE)
                {
                    case 0: // Delete
                        f.Delete();
                        break;
                    case 1: // Move
                        f.MoveTo(fc.path_SOURCE);
                        break;
                    case 2: // Keep
                        f.MoveTo(output); // Send the video to the same folder as the audio
                        break;
                }                
            }
            PrintLn("Extraction successful!");                     
        }
        public int CheckNumberOfAudioTracks(string folderPath)
        {
            // TODO: This function need to figure out how many audio tracks there are in the video!
            return 0;
        }
        public void LoadFilesFromInputFolder( string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                DirectoryInfo input = new DirectoryInfo(folderPath);
                foreach(FileInfo f in input.GetFiles())
                {
                    all_files_in_folder.Add(f);              
                }
            }
        }
        public void CheckNumberOfAudioTracksInFile()
        {
            foreach(FileInfo f in all_files_in_folder)
            {
                // TODO: Figure out a way to extract how many audio tracks is in a video file!    
                // You might be able to do this with FFMPEG           
            }
        }

        private void txtFolderInput_TextChanged(object sender, EventArgs e)
        {
            fc.path_INPUT = txtFolderInput.Text;
            fc.Save();
        }

        private void txtFolderOutput_TextChanged(object sender, EventArgs e)
        {
            fc.path_OUTPUT = txtFolderOutput.Text;
            fc.Save();
        }
        /// <summary>
        /// Prints a line to the output textbox
        /// </summary>
        /// <param name="toPrint">Line to add</param>
        public void PrintLn(string toPrint)
        {
            txtOutput.AppendText(toPrint);
            txtOutput.AppendText(Environment.NewLine);
        }

        private void serviceDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://discord.gg/0UUK0ZWD2mSVayEH");
            Process.Start(sInfo);
        }
    }
}
