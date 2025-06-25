using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace tarea_relleno_circulo
{
    public partial class FormBezier : Form
    {
        private bool isDragging = false;
        List<Point> listaPuntos = new List<Point>();
        private Bitmap buffer;
        private Graphics g;
        private Pen pen = new Pen(Color.Red, 1);
        private Pen pen1 = new Pen(Color.Blue, 3);
        private Pen pen2 = new Pen(Color.Green, 3);
        private Pen pen3 = new Pen(Color.Purple, 1);
        private int indexPointSelected;
        private bool isLinear = false;
        private bool isCuadratic = false;
        private bool isCubic = false;
        private Bezier bezier = new Bezier();
        private System.Windows.Forms.Timer timer;
        private float time = 0;
        private bool sube = true;
        private bool animationOn = false;
        private bool curveOn = true;

        public FormBezier()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            
            buffer = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(buffer);
            picCanvas.Image = buffer;
        }

        private void drawPoints(int n)
        {
            g.Clear(picCanvas.BackColor);
            for(int i = 0; i<n; i++)
            {
                g.DrawEllipse(pen, listaPuntos[i].X-5, listaPuntos[i].Y-5, 10, 10);
                g.DrawEllipse(pen1, listaPuntos[i].X-2, listaPuntos[i].Y-2, 4, 4);
            }
            
            picCanvas.Image = buffer;
        }

        private void drawLines(int n)
        {
            for(int i= 0; i < listaPuntos.Count; i++)
            {
                if(i+1 != listaPuntos.Count)
                {
                    g.DrawLine(pen3, listaPuntos[i], listaPuntos[i + 1]);
                }
            }
        }

        private bool isPointSelected(Point c, Point p)
        {
            return (c.X >= p.X - 10 && c.X <= p.X + 10 && c.Y >= p.Y - 10 && c.Y <= p.Y + 10);
        }


        private void btnLinear_Click(object sender, EventArgs e)
        {
            listaPuntos.Clear();
            listaPuntos.Add(new Point(167, 167));
            listaPuntos.Add(new Point(334, 334));
            drawPoints(2);
            drawLines(2);
            bezier.LinearDraw(listaPuntos[0], listaPuntos[1], g);
            isLinear = true;
            isCuadratic = false;
            isCubic = false;
        }

        private void btnCuadratic_Click(object sender, EventArgs e)
        {
            listaPuntos.Clear();
            listaPuntos.Add(new Point(167, 167));
            listaPuntos.Add(new Point(334, 334));
            listaPuntos.Add(new Point(334, 167));
            drawPoints(3);
            drawLines(3);
            bezier.CuadraticDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], g);
            isLinear = false;
            isCuadratic = true;
            isCubic = false;
        }

        private void btnCubic_Click(object sender, EventArgs e)
        {
            listaPuntos.Clear();
            listaPuntos.Add(new Point(167, 167));
            listaPuntos.Add(new Point(334, 334));
            listaPuntos.Add(new Point(334, 167));
            listaPuntos.Add(new Point(167, 334));
            drawPoints(4);
            drawLines(4);
            bezier.CubicDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], listaPuntos[3], g);
            isLinear = false;
            isCuadratic = false;
            isCubic = true;
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            if (!animationOn)
            {
                Point point;
                animationOn = true;
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 16;
                timer.Tick += (s, e) =>
                {
                    if (sube)
                    {
                        time += 0.01f;
                        if(time >= 1)
                        {
                            sube = false;
                        }
                    }
                    else {
                        time -= 0.01f;
                        if(time <= 0)
                        {
                            sube = true;
                        }
                    }

                    if (isLinear)
                    {
                        drawPoints(2);
                        drawLines(2);
                        point = bezier.Linear(listaPuntos[0], listaPuntos[1], time);
                        g.DrawEllipse(pen2,point.X-2,point.Y-2,4,4);
                        if (curveOn)
                        {
                            bezier.LinearDraw(listaPuntos[0], listaPuntos[1], g);
                        }

                    }
                    if (isCuadratic)
                    {
                        drawPoints(3);
                        drawLines(3);
                        point = bezier.Cuadratic(listaPuntos[0], listaPuntos[1],listaPuntos[2], time);
                        g.DrawEllipse(pen2, point.X - 2, point.Y - 2, 4, 4);
                        if (curveOn)
                        {
                            bezier.CuadraticDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], g);
                        }
                    }
                    if (isCubic)
                    {
                        drawPoints(4);
                        drawLines(4);
                        point = bezier.Cubic(listaPuntos[0], listaPuntos[1], listaPuntos[2],listaPuntos[3], time);
                        g.DrawEllipse(pen2, point.X - 2, point.Y - 2, 4, 4);
                        if (curveOn)
                        {
                            bezier.CubicDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], listaPuntos[3], g);
                        }
                    }

                };
                timer.Start();
            }
            else
            {
                timer.Stop();
                animationOn = false;
            }
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {

        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            if (curveOn)
            {
                curveOn = false;
            }
            else
            {
                curveOn = true;
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            for(int i=0; i<listaPuntos.Count; i++)
            {
                if (e.Button == MouseButtons.Left && isPointSelected(e.Location, listaPuntos[i]))
                {
                    indexPointSelected = i;
                    isDragging = true;
                }
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
                listaPuntos[indexPointSelected] = e.Location;
                g.Clear(picCanvas.BackColor);
                
                if (isLinear)
                {
                    drawPoints(2);
                    drawLines(2);
                    if (curveOn)
                    {
                        bezier.LinearDraw(listaPuntos[0], listaPuntos[1], g);
                    }
                 
                }
                if (isCuadratic)
                {
                    drawPoints(3);
                    drawLines(3);
                    if (curveOn)
                    {
                        bezier.CuadraticDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], g);
                    }
                }
                if (isCubic)
                {
                    drawPoints(4);
                    drawLines(4);
                    if (curveOn)
                    {
                        bezier.CubicDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], listaPuntos[3], g);
                    }
                }
 
                picCanvas.Image = buffer;
            }
        }
    }
}
