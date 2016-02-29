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
    public partial class EditSuffixes : Form
    {
        FileController fc = new FileController(Application.StartupPath + "/Settings.txt");
        public EditSuffixes()
        {
            InitializeComponent();
        }

        private void EditSuffixes_Load(object sender, EventArgs e)
        {
            fc.Load();
            ReloadDatagrid();
        }
        public void ReloadDatagrid()
        {
            int id = 0;
            foreach(string s in fc.suffixes)
            {
                dataGridView1.Rows.Insert(id, id + 1, s);
                id++;
            }
            
            dataGridView1.Refresh();
            dataGridView1.Update();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> rows = new List<string>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                rows.Add(row.Cells[1].Value.ToString());
            }
            fc.suffixes = rows;
            fc.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
