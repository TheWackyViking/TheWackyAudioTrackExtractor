using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioTrackExtractorLibs
{
    public class FFMPEG_Controller
    {
        string path_FFMPEG_EXE = "";

        public FFMPEG_Controller(string _folderPath = "empty")
        {
            if (_folderPath != "empty")
            {
                path_FFMPEG_EXE = _folderPath;
            }
            else
            {
                // Throw error, OR - TODO: Try to use application folder?
                path_FFMPEG_EXE = "";
            }

        }
        // public int Extract(FileInfo fileToExtract, int audioTrack, string _DEST, string SUFFIX)
        public int Extract(FileInfo fileToExtract, string _DEST,int track, string SUFFIX)
        {
            // Run this function when you need to extract the audio files.
            Process ffmpeg = new Process();

            try
            {
                ffmpeg.StartInfo.RedirectStandardOutput = true;
                ffmpeg.StartInfo.UseShellExecute = false;
                ffmpeg.StartInfo.FileName = path_FFMPEG_EXE;//"D:/FFmpeg/bin/ffmpeg.exe";
                ffmpeg.StartInfo.CreateNoWindow = true;
                ffmpeg.StartInfo.RedirectStandardOutput = true;
                ffmpeg.StartInfo.RedirectStandardError = true;
                // OLD: "-i {0} -map 0:a:{2} -vn -sn {1}"
                // 0 = Old file, 1 = output file path(full), 2 = audio track ID
                ffmpeg.StartInfo.Arguments = String.Format("-i {0} -map 0:a:{2} -vn -sn {1} -y", fileToExtract.FullName, _DEST + fileToExtract.Name.Replace(fileToExtract.Extension, "") + SUFFIX + ".wav", track); // Shell arguments here

                ffmpeg.Start();
                string ffmpegLog = ffmpeg.StandardOutput.ReadToEnd(); // This logs output from the hidden ffmpeg command line. No need to add this I would think.

                ffmpeg.WaitForExit();
                return 1;
            }
            catch
            {
                // Something went wrong
                return 0;
            }
        }
    }

}
