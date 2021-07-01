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
            int[,] matriz = new int[Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)];
            Random matrizAleatoria = new Random();


            for (int filas = 0 ; filas < matriz.GetLength(0); filas++)
            {
                for(int colum = 0; colum < matriz.GetLength(1); colum++)
                {
                    matriz[filas, colum] = matrizAleatoria.Next(0,100);
                    MessageBox.Show("La posición es: " + filas + " , " + colum + " = " + matriz[filas, colum].ToString());
                }
            }

        }
    }
}
