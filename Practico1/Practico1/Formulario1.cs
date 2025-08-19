using System;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            BGuardar.Click += BGuardar_Click;
            BEliminar.Click += BEliminar_Click;
            BSalir.Click += BSalir_Click;
            this.KeyPreview = true;
            this.KeyDown += Formulario1_KeyDown;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatenar Apellido y Nombre y mostrar en textBox1
            textBox1.Text = textBox2.Text + " " + textBox3.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Limpia el TextBox multilinea
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BSalir.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
