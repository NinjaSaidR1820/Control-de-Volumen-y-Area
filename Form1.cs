using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Volumen_y_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Medidas",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)  this.Close();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            double radio = diametro / 2;
            double area = (2 * Math.PI / radio) * (radio * altura);

        }
    }
}
