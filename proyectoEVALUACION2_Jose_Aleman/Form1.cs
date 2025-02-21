using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION2_Jose_Aleman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double nota5;
        double nota6;
        double Promedio;
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nota1 = Convert.ToInt32(textBox1.Text);
            nota2 = Convert.ToInt32(textBox2.Text);
            nota3 = Convert.ToInt32(textBox3.Text);
            nota4 = Convert.ToInt32(textBox4.Text);
            nota5 = Convert.ToInt32(textBox5.Text);
            nota6 = Convert.ToInt32(textBox6.Text);
            
            Promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6);
            textBox7.Text = "Promedio: " + Promedio.ToString();

            if (Promedio >= 7 && Promedio <= 10)
            {
                textBox7.Text = "Aprobado".ToString();
                textBox8.Text = "Muy bien...Lo felicito, trate de mejorar mucho mas.".ToString();
                pictureBox1.Image = Properties.Resources.Feliz;
                pictureBox1.Visible = true;

            }
            if(Promedio >= 6 && Promedio <= 6.99) {
            
                textBox7.Text = "Aprobado".ToString();
                textBox8.Text = "Por poco y no lo logra.".ToString();
                pictureBox1.Image = Properties.Resources.Igual;
                pictureBox1.Visible = true;
            }
            if(Promedio >= 3 && Promedio <= 5.99) {
            
                textBox7.Text = "Reprobado".ToString();
                textBox8.Text = "Digame que le paso???.".ToString();
                pictureBox1.Image = Properties.Resources.Decepcion;
                pictureBox1.Visible = true;
            }
            if (Promedio <= 0.00 && Promedio >= 2.99)
            {

                textBox7.Text = "Reprobado".ToString();
                textBox8.Text = "Muy mal caballero o caballera.".ToString();
                pictureBox1.Image = Properties.Resources.Triste;
                pictureBox1.Visible = true;
            }

        }
    }
}
