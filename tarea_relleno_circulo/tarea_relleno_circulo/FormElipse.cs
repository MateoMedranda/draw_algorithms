using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_relleno_circulo
{
    public partial class FormElipse : Form
    {
        Elipse elipse = new Elipse();
        public FormElipse()
        {
            InitializeComponent();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            int radioA;
            int radioB;
            string inputA = txtRadiusA.Text.Trim();
            string inputB = txtRadiusB.Text.Trim();
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            lbPoint.Text = me.Location.X.ToString() + " , " + me.Location.Y.ToString();

            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB))
            {
                MessageBox.Show("El campo de radio no puede estar en blanco.");
            }
            else if (!int.TryParse(inputA, out radioA) || !int.TryParse(inputB, out radioB))
            {
                MessageBox.Show("Ingrese solo números enteros válidos.");
            }
            else
            {
                radioA = Convert.ToInt32(inputA);
                radioB = Convert.ToInt32(inputB);

                elipse.readData(coordinates, radioA, radioB, picCanvas, lbN, lbX, lbY);
                elipse.DrawEllipseMidPoint();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
    }
}
