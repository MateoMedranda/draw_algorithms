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
    public partial class FormBezier : Form
    {
        private bool isDragging = false;
        private Point point1;
        private Point point2;
        private Point point3;
        private Bitmap buffer;
        private Graphics g;
        private Pen pen = new Pen(Color.Red, 1);

        public FormBezier()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            point1 = new Point(167, 167);
            point2 = new Point(334, 334);
            point3 = new Point(334, 167);
            buffer = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(buffer);
            picCanvas.Image = buffer;
            
        }

        private void drawLinealPoints()
        {
            g.Clear(picCanvas.BackColor);
            g.DrawEllipse(pen, point1.X, point1.Y, 9, 9);
            g.DrawEllipse(pen, point2.X, point2.Y, 9, 9);
            g.DrawEllipse(pen, point3.X, point3.Y, 9, 9);
            picCanvas.Image = buffer;
        }

        private bool isPointSelected(Point c, Point p)
        {
            return (c.X >= p.X - 9 && c.X <= p.X + 9 &&
                    c.Y >= p.Y - 9 && c.Y <= p.Y + 9);
        }


        private void btnLinear_Click(object sender, EventArgs e)
        {
            drawLinealPoints();
        }

        private void btnCuadratic_Click(object sender, EventArgs e)
        {

        }

        private void btnCubic_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {

        }

        private void btnTrace_Click(object sender, EventArgs e)
        {

        }

        private void btnCurve_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isPointSelected(e.Location, point1))
            {
                isDragging = true;
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                point1 = e.Location;

                g.Clear(picCanvas.BackColor);
                g.DrawEllipse(pen, point1.X, point1.Y, 9, 9);
                g.DrawEllipse(pen, point2.X, point2.Y, 9, 9);
                g.DrawEllipse(pen, point3.X, point3.Y, 9, 9);

                Bezier prueba = new Bezier();
                prueba.CuadraticDraw(point1, point2, point3, g); 

                picCanvas.Image = buffer;
            }
        }
    }
}
