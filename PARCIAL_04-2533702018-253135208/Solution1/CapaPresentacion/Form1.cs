using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        ManttHospital neg = new ManttHospital();

        ManttHospital enlc = new ManttHospital();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void limpiar()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar()
        {
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void limpiar2()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar2()
        {
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
        }

    }
}
