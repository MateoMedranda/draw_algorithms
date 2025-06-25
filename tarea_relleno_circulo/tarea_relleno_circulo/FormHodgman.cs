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
    public partial class FormHodgman : Form
    {
        Point pointMax = new Point(334, 334);
        Point pointMin = new Point(167, 167);
        List<Point> figura = new List<Point>();

        public FormHodgman()
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

        private void uploadLabel(List<Point> lista)
        {
            String N = "";
            String X = "";
            String Y = "";
            for (int i = 0; i < lista.Count; i++)
            {
                N += i + "\n";
                X += lista[i].X + "\n";
                Y += lista[i].Y + "\n";
            }

            lbN.Text = N;
            lbX.Text = X;
            lbY.Text = Y;
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
            Pen pen = new Pen(Color.Black, 1);
            g.DrawPolygon(pen, figura.ToArray());
            uploadLabel(figura);
        }

        private void btnShowCut_Click(object sender, EventArgs e)
        {
            if (figura.Count > 0)
            {
                picCanvas.Refresh();
                drawPanel();
                Sutherland_Hodgman hodgman = new Sutherland_Hodgman();
                hodgman.readData(figura, pointMax, pointMin);
                List<Point> newFigure = hodgman.calculatePoints();

                Graphics g = picCanvas.CreateGraphics();
                Pen pen = new Pen(Color.Black, 1);
                g.DrawPolygon(pen, newFigure.ToArray());
                uploadLabel(newFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            figura.Clear();
            picCanvas.Refresh();
            drawPanel();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Graphics g = picCanvas.CreateGraphics();

            Pen pen = new Pen(Color.Red, 1);
            g.DrawRectangle(pen, coordinates.X, coordinates.Y, 4, 4);
            figura.Add(coordinates);
        }
    }
}
