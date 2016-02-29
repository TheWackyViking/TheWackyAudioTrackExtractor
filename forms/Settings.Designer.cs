namespace MP4Extractor_Forms
{
    partial class Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.browserFFMPEG2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse_FFMPEG_EXE = new System.Windows.Forms.Button();
            this.txtFFMPEG_EXE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioKeep = new System.Windows.Forms.RadioButton();
            this.btnBrowse_Source = new System.Windows.Forms.Button();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowse_Output = new System.Windows.Forms.Button();
            this.btnBrowse_Recordings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecordings = new System.Windows.Forms.TextBox();
            this.browserINPUT = new System.Windows.Forms.FolderBrowserDialog();
            this.browserOUTPUT = new System.Windows.Forms.FolderBrowserDialog();
            this.browserSOURCE = new System.Windows.Forms.FolderBrowserDialog();
            this.browserFFMPEG = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAudioTracks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditSuffixes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(59, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowse_FFMPEG_EXE);
            this.panel1.Controls.Add(this.txtFFMPEG_EXE);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 54);
            this.panel1.TabIndex = 2;
            // 
            // btnBrowse_FFMPEG_EXE
            // 
            this.btnBrowse_FFMPEG_EXE.Location = new System.Drawing.Point(111, 21);
            this.btnBrowse_FFMPEG_EXE.Name = "btnBrowse_FFMPEG_EXE";
            this.btnBrowse_FFMPEG_EXE.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse_FFMPEG_EXE.TabIndex = 2;
            this.btnBrowse_FFMPEG_EXE.Text = "Browse";
            this.btnBrowse_FFMPEG_EXE.UseVisualStyleBackColor = true;
            this.btnBrowse_FFMPEG_EXE.Click += new System.EventHandler(this.btnBrowse_FFMPEG_EXE_Click);
            // 
            // txtFFMPEG_EXE
            // 
            this.txtFFMPEG_EXE.Location = new System.Drawing.Point(7, 23);
            this.txtFFMPEG_EXE.Name = "txtFFMPEG_EXE";
            this.txtFFMPEG_EXE.Size = new System.Drawing.Size(100, 20);
            this.txtFFMPEG_EXE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FFMPEG.exe";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnBrowse_Output);
            this.panel2.Controls.Add(this.btnBrowse_Recordings);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRecordings);
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 228);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKeep);
            this.groupBox1.Controls.Add(this.btnBrowse_Source);
            this.groupBox1.Controls.Add(this.radioMove);
            this.groupBox1.Controls.Add(this.radioDelete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source file";
            // 
            // radioKeep
            // 
            this.radioKeep.AutoSize = true;
            this.radioKeep.Checked = true;
            this.radioKeep.Location = new System.Drawing.Point(6, 65);
            this.radioKeep.Name = "radioKeep";
            this.radioKeep.Size = new System.Drawing.Size(86, 17);
            this.radioKeep.TabIndex = 2;
            this.radioKeep.TabStop = true;
            this.radioKeep.Text = "Keep original";
            this.radioKeep.UseVisualStyleBackColor = true;
            // 
            // btnBrowse_Source
            // 
            this.btnBrowse_Source.Location = new System.Drawing.Point(110, 107);
            this.btnBrowse_Source.Name = "btnBrowse_Source";
            this.btnBrowse_Source.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse_Source.TabIndex = 5;
            this.btnBrowse_Source.Text = "Browse";
            this.btnBrowse_Source.UseVisualStyleBackColor = true;
            this.btnBrowse_Source.Click += new System.EventHandler(this.btnBrowse_Source_Click);
            // 
            // radioMove
            // 
            this.radioMove.AutoSize = true;
            this.radioMove.Location = new System.Drawing.Point(6, 42);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(88, 17);
            this.radioMove.TabIndex = 1;
            this.radioMove.Text = "Move original";
            this.radioMove.UseVisualStyleBackColor = true;
            this.radioMove.CheckedChanged += new System.EventHandler(this.radioMove_CheckedChanged);
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(6, 19);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(92, 17);
            this.radioDelete.TabIndex = 0;
            this.radioDelete.Text = "Delete original";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Move to this folder";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(6, 109);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 4;
            // 
            // btnBrowse_Output
            // 
            this.btnBrowse_Output.Location = new System.Drawing.Point(112, 61);
            this.btnBrowse_Output.Name = "btnBrowse_Output";
            this.btnBrowse_Output.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse_Output.TabIndex = 5;
            this.btnBrowse_Output.Text = "Browse";
            this.btnBrowse_Output.UseVisualStyleBackColor = true;
            this.btnBrowse_Output.Click += new System.EventHandler(this.btnBrowse_Output_Click);
            // 
            // btnBrowse_Recordings
            // 
            this.btnBrowse_Recordings.Location = new System.Drawing.Point(112, 20);
            this.btnBrowse_Recordings.Name = "btnBrowse_Recordings";
            this.btnBrowse_Recordings.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse_Recordings.TabIndex = 5;
            this.btnBrowse_Recordings.Text = "Browse";
            this.btnBrowse_Recordings.UseVisualStyleBackColor = true;
            this.btnBrowse_Recordings.Click += new System.EventHandler(this.btnBrowse_Recordings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Path to output-folder";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(8, 63);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to recordings folder";
            // 
            // txtRecordings
            // 
            this.txtRecordings.Location = new System.Drawing.Point(8, 22);
            this.txtRecordings.Name = "txtRecordings";
            this.txtRecordings.Size = new System.Drawing.Size(100, 20);
            this.txtRecordings.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditSuffixes);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAudioTracks);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 41);
            this.panel3.TabIndex = 4;
            // 
            // txtAudioTracks
            // 
            this.txtAudioTracks.Location = new System.Drawing.Point(7, 18);
            this.txtAudioTracks.Name = "txtAudioTracks";
            this.txtAudioTracks.Size = new System.Drawing.Size(53, 20);
            this.txtAudioTracks.TabIndex = 0;
            this.txtAudioTracks.Text = "4";
            this.txtAudioTracks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number of audio tracks";
            // 
            // btnEditSuffixes
            // 
            this.btnEditSuffixes.Location = new System.Drawing.Point(65, 16);
            this.btnEditSuffixes.Name = "btnEditSuffixes";
            this.btnEditSuffixes.Size = new System.Drawing.Size(72, 23);
            this.btnEditSuffixes.TabIndex = 2;
            this.btnEditSuffixes.Text = "Edit suffixes";
            this.btnEditSuffixes.UseVisualStyleBackColor = true;
            this.btnEditSuffixes.Click += new System.EventHandler(this.btnEditSuffixes_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 379);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog browserFFMPEG2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse_FFMPEG_EXE;
        private System.Windows.Forms.TextBox txtFFMPEG_EXE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioKeep;
        private System.Windows.Forms.Button btnBrowse_Source;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnBrowse_Output;
        private System.Windows.Forms.Button btnBrowse_Recordings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecordings;
        private System.Windows.Forms.FolderBrowserDialog browserINPUT;
        private System.Windows.Forms.FolderBrowserDialog browserOUTPUT;
        private System.Windows.Forms.FolderBrowserDialog browserSOURCE;
        private System.Windows.Forms.OpenFileDialog browserFFMPEG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditSuffixes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAudioTracks;
    }
}