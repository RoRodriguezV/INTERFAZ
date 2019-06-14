using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGUNDOPARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Facil");
            comboBox1.Items.Add("Intermedio");
            comboBox1.Items.Add("Complicado");

            
            dataGridView1.Columns.Add("materia", "MATERIA");
            dataGridView1.Columns.Add("docente", "DOCENTE");

            dataGridView1.Rows.Add("DISENO 1", "ZURITA");
            dataGridView1.Rows.Add("DISENO 2", "RELOS");
            dataGridView1.Rows.Add("ASPECTOS LEGALES", "DE LA TORRE");
            dataGridView1.Rows.Add("COMPUTACION 1", "LOPEZ");
            dataGridView1.Rows.Add("PRE UNIVERSITARIO DE MATEMÁTICAS", "RODRIGUEZ");
            dataGridView1.Rows.Add("FISICA 1", "RIVAS");
            dataGridView1.Rows.Add("COMUNICACION ESCRITA", "ABASTO");





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mATEMÁTICASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOLICITUR ENVIADA");
        }
    }
}
