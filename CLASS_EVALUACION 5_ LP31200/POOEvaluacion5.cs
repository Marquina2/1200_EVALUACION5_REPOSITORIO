using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_EVALUACION_5__LP31200
{
    public partial class POOEvaluacion5 : Form
    {
        public POOEvaluacion5()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            Promedio Alumno = new Promedio();
            Alumno.Nombre = NombretextBox1.Text;
            Alumno.Numero_Cuenta =Convert.ToInt64(CuentatextBox2.Text);
            Alumno.Nota1 = Convert.ToInt32(Nota1_textBox3.Text);
            Alumno.Nota2 = Convert.ToInt32(Nota2_textBox4.Text);
            Alumno.Nota3 = Convert.ToInt32(Nota3_textBox5.Text);
            Alumno.Nota4 = Convert.ToInt32(Nota4_textBox6.Text);


            MessageBox.Show(Alumno.CalcularPromedio());

            MessageBox.Show(Alumno.Observacion());


        }

        private void PromediotextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void limpiarcontroles()
        {
            NombretextBox1.Clear();
            CuentatextBox2.Clear();
            Nota1_textBox3.Clear();
            Nota2_textBox4.Clear();
            Nota3_textBox5.Clear();
            Nota4_textBox6.Clear();
        }

        private void Limpiarbutton1_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }
    }
}
