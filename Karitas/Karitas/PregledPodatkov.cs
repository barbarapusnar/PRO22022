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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Karitas
{
    public partial class PregledPodatkov : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        int številoSpremeb = 0;
        public PregledPodatkov()
        {
            InitializeComponent();
        }

        private void PregledPodatkov_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Resource1.pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Darovi d;
            try {
                while (true)
                {
                    d = (Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            }
            catch (SerializationException) { }
            fs.Close();
            dgvPodatki.DataSource = spremembe;
        }

        private void PregledPodatkov_Shown(object sender, EventArgs e)
        {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "###.00 €";
            dgvPodatki.Columns[3].DefaultCellStyle = dcs;
            dgvPodatki.Columns[4].Width = 175;
            foreach(DataGridViewRow row in dgvPodatki.Rows)
            {
                double vrednost = double.Parse(row.Cells[3].Value.ToString());
                if (vrednost < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            dgvPodatki.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShraniSpremembe();
            številoSpremeb = 0;
        }

        private void ShraniSpremembe()
        {
            FileInfo fi = new FileInfo(Resource1.pot);
            fi.Delete();
            FileStream fs = new FileStream(Resource1.pot, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe)
            {
                bf.Serialize(fs, d);
            }
            fs.Close();
        }

        private void dgvPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapŠt = int.Parse(dgvPodatki.Rows[vrstica].Cells["ZapŠt"].Value.ToString());
            d.Datum = DateTime.Parse(dgvPodatki.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgvPodatki.Rows[vrstica].Cells["Namen"].Value.ToString();
            d.Znesek = double.Parse(dgvPodatki.Rows[vrstica].Cells["Znesek"].Value.ToString());
            d.Opombe = dgvPodatki.Rows[vrstica].Cells["Opombe"].Value.ToString();
            spremembe[vrstica] = d;
            številoSpremeb++;
        }

        private void PregledPodatkov_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (številoSpremeb > 0)
            {
                DialogResult shrani = MessageBox.Show("Obstajajo neshranjene spremembe" +
                     Environment.NewLine +
                    "Shranim sedaj?", "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (shrani == DialogResult.Yes)
                    ShraniSpremembe();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Res izbrišem vrstico?",
                "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                DataGridViewRow vrstica = dgvPodatki.CurrentRow;
                int b = vrstica.Index;
                BrišiVrstico(b);
            }
        }

        private void BrišiVrstico(int b)
        {
            //odstrani iz seznama List<Darovi> spremembe
            spremembe.RemoveAt(b);
            dgvPodatki.DataSource = null;
            dgvPodatki.Rows.Clear();
            dgvPodatki.DataSource = spremembe;
            številoSpremeb++;
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "###.00 €";
            dgvPodatki.Columns[3].DefaultCellStyle = dcs;
            dgvPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow row in dgvPodatki.Rows)
            {
                double vrednost = double.Parse(row.Cells[3].Value.ToString());
                if (vrednost < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            dgvPodatki.Refresh();
        }
    }
}
