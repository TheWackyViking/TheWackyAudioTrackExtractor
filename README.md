# TheWackyAudioTrackExtractor
This is a simple program that will enable you to extract multiple audio tracks from multiple video files with one simple click!
This readme will go over how to install and use the latest version of the software. There will be no pictures, because I have no idea how to add that to the readme, and I'm too lazy to google it.

NOTE: If you have any issues with using this software, please, feel free to contact me on the "service desk" Discord channel(https://discord.gg/0UUK0ZWD2mSVayEH). The link is also in the "Service desk" button in the "Help"-menu. :) 

1) Download the latest release of this software.
There will be, at all times, two different exe-files you can download from this site; The release version, and the debug-version. The debug-version will be the first one to get updates, but the release version will be more stable.

  Current release: https://github.com/TheWackyViking/TheWackyAudioTrackExtractor/raw/master/bin/Release/TheWackyAudioTrackExtractor.exe
  Current debug: https://github.com/TheWackyViking/TheWackyAudioTrackExtractor/raw/master/bin/Debug/TheWackyAudioTrackExtractor.exe
  
Clicking either of those links will download the version you want.

2) Install
When you have downloaded the file, the software is actually already installed! I will, however, suggest you move it to a folder of you choosing, for convinience. I recommend putting it in your "Recordings" directory. I will also recommand making these sub-directories in your "Recordings" folder; Raw and Processed

Record your footage straigt to the "Raw" folder in your "Recordings" directory. Then configure the software to process the files in your "Raw" folder and output the audio tracks to your "Processed" folder. 

3) Configure settings (IMPORTANT! Don't start extracting without configuring the settings)

Start the program by double-clicking it in your file explorer
To start configuring settings, click the "Settings" button in the menu up top in the program.

Here is a write-up of what each bit in the "settings"-dialog does:
"Number of audio tracks" - The textbox below this label should contain a number only. The number should reflect how many audio tracks you wish to extract from your recorded video files.
"Edit suffixes" - This button will let you edit the suffixes for your extracted audio files. Just click on the suffix-column for the audio track you want to name, and start typing! The suffix will be added to each audio file, and if set up correctly, identify the audio track. I use one audio track for DESKTOP, VOICE-CALL, MUSIC, and MIC which will then automatically get the suffix added to the end of the filename, respectivelly. Makes it easier to add audio when editing video :)
"FFMPEG.exe" - IMPORTANT: This should be the path and filename for your FFMPEG.exe file. You can download the neccessary files from their website(https://www.ffmpeg.org/download.html). The ffmpeg.exe file should be located in the folder you downloaded/installed it too, in the "bin" sub-directory.
"path to recordings folder" - This is the folder in which you keep the raw video file you want to extract audio tracks from. The software will extract audio tracks from all the files in this folder when you click the start-button. Great for managing many files at once!
"path to output folder" - This is the folder the software will put the extracted audio tracks. The program will make a sub-directory in this folder with the current file's name and put the extracted audio in there.
"delete original" - Enabling this option will delete the original video file after the extraction process is done
"move original" - Enabling this option will move the original video file to the folder specified in "move to this folder" after the extraction process is done. 
"keep original" will move the original video file to the same folder as the extracted audio tracks

After you have gone through all of these settings, click save.
Restart the software and you are ready to bulk-extract audio tracks from your raw video footage!

