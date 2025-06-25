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
    public partial class FormDDL : Form
    {
        public Point Point1;
        public Point Point2;
        public bool pressBefore = false;
        private DDA objLine;

        public FormDDL()
        {
            InitializeComponent();
        }


        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            if (!pressBefore)
            {
                Point1 = new Point(coordinates.X, -coordinates.Y);
                lbPoint1.Text = (coordinates.X.ToString() + " ; " + coordinates.Y.ToString());
                pressBefore = true;
            }
            else
            {
                Point2 = new Point(coordinates.X, -coordinates.Y);
                lbPoint2.Text = (coordinates.X.ToString() + " ; " + coordinates.Y.ToString());
                objLine = new DDA();
                objLine.ReadData(Point1, Point2, picCanvas, lbN, lbX, lbY);
                objLine.CalculateConstant();
                objLine.CalculatePendient();
                objLine.CalculateKValor();
                objLine.CalculatePoints();
                pressBefore = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            lbN.Text = "---";
            lbX.Text = "---";
            lbY.Text = "---";
            picCanvas.Refresh();
        }

        private void lbY_Click(object sender, EventArgs e)
        {

        }
    }
}
