using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int producto = Num1 * Num2;
            MessageBox.Show("el resultado del producto es " + producto);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Suma = Num1 * Num2;
            MessageBox.Show("el resultado de la suma" + Suma);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Num3 = 1;
            int Potencia = 1;

            while (Num3 != Num2)
            {
                Potencia = Potencia * Num1;
                Num3 = Num3 + 1;

                MessageBox.Show("el resultado de la potencia" + Potencia);


            }
    }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = int.Parse(TextVar1.Text);
            float num2 = int.Parse(TextVar2.Text);

            if (num2 > 0)
           {
                float Division = num1 / num2;

                MessageBox.Show("el resultado es " + Division);

            }

            {

                MessageBox.Show("La Division es indifinida");
        }

   }
  }
}




