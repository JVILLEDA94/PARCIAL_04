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
    public partial class Form5 : Form
    {
        ManttHospital neg = new ManttHospital();

        ManttHospital enlc = new ManttHospital();
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar()
        {
            neg.mostrarDepartamento();
            dataGridView1.DataSource = neg.dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }
    }
}
