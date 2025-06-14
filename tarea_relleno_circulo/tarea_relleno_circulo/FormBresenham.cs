using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace tarea_relleno_circulo
{
    public partial class FormBresenham : Form
    {
        public Point Point1;
        public Point Point2;
        public bool pressBefore = false;
        private Bresenham objLine;

        public FormBresenham()
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
                objLine = new Bresenham();
                objLine.ReadData(Point1, Point2, picCanvas,lbN,lbX,lbY);
                objLine.CalculateConstant();
                objLine.CalculatePendient();
                objLine.CalculateKValor();
                objLine.CalculatePValor();
                objLine.CalculatePoints();
                pressBefore = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

    }
}
