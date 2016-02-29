using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AudioTrackExtractorLibs
{
    class FileController
    {
        string saveFileLocation = "";
        public string path_FFMPEG_EXE { get; set; }
        public string path_INPUT { get; set; } // Path to recordings
        public string path_OUTPUT { get; set; } // Put processed audio here
        public int radio_SOURCE_FILE { get; set; } // Save what to do with the source file as integer
        public string path_SOURCE { get; set; } // If radio "move source file" is checked, move the source file to this location. "Keep" should place the src-file together 
                                                // together with the processed audio tracks
        public int numAudioTracks { get; set; }
        public List<string> suffixes = new List<string>();
        public FileController(string file)
        {
            saveFileLocation = file;
        }
        public void Save()
        {
            if (File.Exists(saveFileLocation))
            {
                File.Delete(saveFileLocation);
            }
            // Start the saving procedure
            File.AppendAllText(saveFileLocation, "__SETTINGS__(if editing, make sure you don't add or removes lines. IMPORTANT!!" + "\n");
            File.AppendAllText(saveFileLocation, "FFMPEG-PATH:" + "\n");
            File.AppendAllText(saveFileLocation, path_FFMPEG_EXE + "\n");
            File.AppendAllText(saveFileLocation, "INPUT-PATH" + "\n");
            File.AppendAllText(saveFileLocation, path_INPUT + "\n");
            File.AppendAllText(saveFileLocation, "OUTPUT-PATH" + "\n");
            File.AppendAllText(saveFileLocation, path_OUTPUT + "\n");
            File.AppendAllText(saveFileLocation, "SOURCE-FILE-ACTION" + "\n");
            File.AppendAllText(saveFileLocation, radio_SOURCE_FILE.ToString() + "\n");
            File.AppendAllText(saveFileLocation, "SOURCE-FILE-PATH" + "\n");
            File.AppendAllText(saveFileLocation, path_SOURCE + "\n");
            File.AppendAllText(saveFileLocation, "AUDIO_TRACKS" + "\n");
            File.AppendAllText(saveFileLocation, numAudioTracks.ToString() + "\n");

            File.AppendAllText(saveFileLocation, "__SUFFIXES__" + "\n");
            foreach (string suffix in suffixes)
            {
                File.AppendAllText(saveFileLocation, suffix + "\n");
                // TODO: MAKE SURE TO FIX THIS SO SUFFIXES ARE SAVED!!
            }
        }
        private List<string> LoadSuffixes(StreamReader reader)
        {
            List<string> s = new List<string>();
            for (int i = 0; i < numAudioTracks; i++)
            {
                s.Add(reader.ReadLine());
            }
            reader.Close();
            return s;
        }
        public int Load()
        {
            if (!File.Exists(saveFileLocation))
            {
                return 0;
            }
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(saveFileLocation);

                    reader.ReadLine();
                    reader.ReadLine();
                    this.path_FFMPEG_EXE = reader.ReadLine();
                    reader.ReadLine();
                    this.path_INPUT = reader.ReadLine();
                    reader.ReadLine();
                    this.path_OUTPUT = reader.ReadLine();
                    reader.ReadLine();
                    this.radio_SOURCE_FILE = int.Parse(reader.ReadLine());
                    reader.ReadLine();
                    this.path_SOURCE = reader.ReadLine();
                    reader.ReadLine();
                    this.numAudioTracks = int.Parse(reader.ReadLine());
                    reader.ReadLine();
                    suffixes = LoadSuffixes(reader);
                    reader.Close();
                    return 1;
                }
                catch (Exception e)
                {
                    // Do something
                    return 0;
                }
            }
        }
    }
}
