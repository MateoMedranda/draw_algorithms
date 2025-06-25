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
    public partial class FormCohen : Form
    {
        Point pointMax = new Point(334, 334);
        Point pointMin = new Point(167, 167);
        Point point1;
        Point point2;
        List<Point> OriginalLines = new List<Point>();
        public bool pressBefore = false;

        public FormCohen()
        {
            InitializeComponent();
            picCanvas.Paint += PicCanvas_Paint;
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, new Point(167, 0), new Point(167, 501));
            g.DrawLine(pen, new Point(334, 0), new Point(334, 501));
            g.DrawLine(pen, new Point(0, 167), new Point(501, 167));
            g.DrawLine(pen, new Point(0, 334), new Point(501, 334));
        }

        private void drawPanel()
        {
            Graphics g = picCanvas.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, new Point(167, 0), new Point(167, 501));
            g.DrawLine(pen, new Point(334, 0), new Point(334, 501));
            g.DrawLine(pen, new Point(0, 167), new Point(501, 167));
            g.DrawLine(pen, new Point(0, 334), new Point(501, 334));
        }

        private void btnShowOriginal_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            drawPanel();
            Graphics g = picCanvas.CreateGraphics();
            for (int i = 0; i < OriginalLines.Count; i = i + 2)
            {
                Pen pen = new Pen(Color.Green, 1);
                g.DrawLine(pen, OriginalLines[i], OriginalLines[i + 1]);
            }
        }

        private void btnShowCut_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            drawPanel();
            if (OriginalLines.Count > 0)
            {
                for (int i = 0; i < OriginalLines.Count; i = i + 2)
                {
                    Cohen recorte = new Cohen();
                    recorte.readData(OriginalLines[i], OriginalLines[i + 1], pointMax, pointMin);
                    List<Point> newpoints = recorte.calculateNewPoints();

                    Graphics g = picCanvas.CreateGraphics();
                    Pen pen = new Pen(Color.Red, 1);
                    g.DrawLine(pen, newpoints[0], newpoints[1]);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            drawPanel();
            OriginalLines.Clear(); 
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Graphics g = picCanvas.CreateGraphics();

            if (!pressBefore)
            {
                point1 = new Point(coordinates.X, coordinates.Y);
                lbPoint1.Text = "x: " + point1.X + " , y: " + point1.Y;
                pressBefore = true;
            }
            else
            {
                point2 = new Point(coordinates.X, coordinates.Y);
                lbPoint2.Text = "x: " + point2.X + " , y: " + point2.Y;
                Pen pen = new Pen(Color.Green, 1);
                g.DrawLine(pen, point1, point2);
                OriginalLines.Add(point1);
                OriginalLines.Add(point2);
                pressBefore = false;
            }
        }
    }
}
