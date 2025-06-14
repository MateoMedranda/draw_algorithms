using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_relleno_circulo
{
    public partial class FormCircunferencia : Form
    {
        Circunferencia circunferencia = new Circunferencia();

        public FormCircunferencia()
        {
            InitializeComponent();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            int radio;
            string input = txtRadius.Text.Trim();
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            lbPoint1.Text = me.Location.X.ToString() + " , " + me.Location.Y.ToString();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("El campo de radio no puede estar en blanco.");
            }
            else if (!int.TryParse(input, out radio))
            {
                MessageBox.Show("Ingrese solo números enteros válidos.");
            }
            else
            {
                radio = Convert.ToInt32(input);
                
                circunferencia.readData(coordinates, radio, picCanvas, lbN, lbX, lbY);
                circunferencia.DrawCircleMidPoint();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
    }
}
