using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3_1201
{
    public partial class FrmEjercicio_5 : Form
    {
        public FrmEjercicio_5()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 2];

            matriz[0, 0] = Convert.ToInt32(textBox1.Text);
            matriz[0, 1] = Convert.ToInt32(textBox2.Text);
            matriz[1, 0] = Convert.ToInt32(textBox3.Text);
            matriz[1, 1] = Convert.ToInt32(textBox4.Text);

            for (int filas = 0 ; filas < matriz.GetLength(0); filas++)
            {
                for(int colum = 0; colum < matriz.GetLength(1); colum++)
                {
                    MessageBox.Show("La posición es: " + filas + " , " + colum + " = " + matriz[filas, colum].ToString());
                }
            }

        }
    }
}
