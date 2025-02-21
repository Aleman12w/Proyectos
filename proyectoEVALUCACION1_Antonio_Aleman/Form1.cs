using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUCACION1_Antonio_Aleman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Pupusascantidad;
        double Pupusasprecio;
        double Bebidascantidad;
        double Bebidasprecio;
        double Total2;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pupusascantidad = Convert.ToDouble(PupusasCantidad.Text);
            Pupusasprecio = Convert.ToDouble(PupusasPrecio.Text);
            Bebidascantidad = Convert.ToDouble(BebidasCantidad.Text);
            Bebidasprecio = Convert.ToDouble(BebidasPrecio.Text);
            Total2 = (Pupusascantidad * Pupusasprecio) + (Bebidasprecio * Bebidascantidad);
            Total.Text = "$" + Convert.ToString(Total2);
        }
    }
}
