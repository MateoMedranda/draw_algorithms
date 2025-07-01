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
        List<Point> listaRastro = new List<Point>();
        private Bitmap buffer;
        private Graphics g;
        private Pen pen = new Pen(Color.Red, 1);
        private Pen pen1 = new Pen(Color.Blue, 3);
        private Pen pen2 = new Pen(Color.Green, 3);
        private Pen pen3 = new Pen(Color.Purple, 1);
        private Pen pen4 = new Pen(Color.Magenta, 1);
        private Pen pen5 = new Pen(Color.OrangeRed, 3);
        private Pen pen6 = new Pen(Color.SteelBlue, 3);
        private Pen pen7 = new Pen(Color.Green, 1);
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
        private bool traceOn = false;
        private float timeControl = 0.005f;

        public FormBezier()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            buffer = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(buffer);
            picCanvas.Image = buffer;
        }

        private Point calculatePointLines(Point point1, Point point2, float time)
        {
            int a = point2.X - point1.X;
            int b = point2.Y - point1.Y;

            float x = point1.X + a * time;
            float y = point1.Y + b * time;

            return new Point((int)x, (int)y);
        }

        private bool isMouseOutside(Point e)
        {
            return e.X >= picCanvas.Width || e.Y >= picCanvas.Height || e.X <= 0 || e.Y <= 0;
        }

        private void graficateTrace()
        {
            foreach (Point point in listaRastro)
            {
                g.FillEllipse(Brushes.Gray, point.X - 2, point.Y - 2, 4, 4);
            }
        }

        private void drawPoints(int n)
        {
            g.Clear(picCanvas.BackColor);
            for (int i = 0; i < n; i++)
            {
                g.DrawEllipse(pen, listaPuntos[i].X - 5, listaPuntos[i].Y - 5, 10, 10);
                g.DrawEllipse(pen1, listaPuntos[i].X - 2, listaPuntos[i].Y - 2, 4, 4);
            }

            picCanvas.Image = buffer;
        }

        private void drawLines(int n)
        {
            for (int i = 0; i < listaPuntos.Count; i++)
            {
                if (i + 1 != listaPuntos.Count)
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

        private void render()
        {
            g.Clear(picCanvas.BackColor);
            Point point = new Point(0, 0);
            if (isLinear)
            {
                drawPoints(2);
                drawLines(2);

                if (animationOn)
                {
                    point = bezier.Linear(listaPuntos[0], listaPuntos[1], time);
                    g.DrawEllipse(pen2, point.X - 2, point.Y - 2, 4, 4);
                }

                if (curveOn)
                {
                    bezier.LinearDraw(listaPuntos[0], listaPuntos[1], g);
                }

            }

            if (isCuadratic)
            {
                drawPoints(3);
                drawLines(3);

                if (animationOn)
                {
                    Point pline1 = calculatePointLines(listaPuntos[0], listaPuntos[1], time);
                    Point pline2 = calculatePointLines(listaPuntos[1], listaPuntos[2], time);
                    g.DrawEllipse(pen5, pline1.X - 2, pline1.Y - 2, 4, 4);
                    g.DrawEllipse(pen5, pline2.X - 2, pline2.Y - 2, 4, 4);
                    g.DrawLine(pen4, pline1, pline2);

                    point = bezier.Cuadratic(listaPuntos[0], listaPuntos[1], listaPuntos[2], time);
                    g.DrawEllipse(pen2, point.X - 2, point.Y - 2, 4, 4);
                }
                
                if (curveOn)
                {
                    bezier.CuadraticDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], g);
                }
            }

            if (isCubic)
            {
                drawPoints(4);
                drawLines(4);

                if (animationOn)
                {
                    Point pline1 = calculatePointLines(listaPuntos[0], listaPuntos[1], time);
                    Point pline2 = calculatePointLines(listaPuntos[1], listaPuntos[2], time);
                    Point pline3 = calculatePointLines(listaPuntos[2], listaPuntos[3], time);
                    g.DrawEllipse(pen5, pline1.X - 2, pline1.Y - 2, 4, 4);
                    g.DrawEllipse(pen5, pline2.X - 2, pline2.Y - 2, 4, 4);
                    g.DrawEllipse(pen5, pline3.X - 2, pline3.Y - 2, 4, 4);
                    g.DrawLine(pen4, pline1, pline2);
                    g.DrawLine(pen4, pline2, pline3);

                    Point pline12 = calculatePointLines(pline1, pline2, time);
                    Point pline23 = calculatePointLines(pline2, pline3, time);
                    g.DrawEllipse(pen6, pline12.X - 2, pline12.Y - 2, 4, 4);
                    g.DrawEllipse(pen6, pline23.X - 2, pline23.Y - 2, 4, 4);
                    g.DrawLine(pen7, pline12, pline23);

                    point = bezier.Cubic(listaPuntos[0], listaPuntos[1], listaPuntos[2], listaPuntos[3], time);
                    g.DrawEllipse(pen2, point.X - 2, point.Y - 2, 4, 4);
                }

                if (curveOn)
                {
                    bezier.CubicDraw(listaPuntos[0], listaPuntos[1], listaPuntos[2], listaPuntos[3], g);
                }
            }

            if (traceOn)
            {
                listaRastro.Add(point);
                graficateTrace();
            }

            picCanvas.Image = buffer;

        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            if (!animationOn)
            {
                
                animationOn = true;
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 16;
                timer.Tick += (s, e) =>
                {
                    if (sube)
                    {
                        time += timeControl;
                        if (time >= 1)
                        {
                            sube = false;
                        }
                    }
                    else
                    {
                        time -= timeControl;
                        if (time <= 0)
                        {
                            sube = true;
                        }
                    }

                    render();
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
            if (traceOn)
            {
                traceOn = false;
                listaRastro.Clear();
            }
            else
            {
                traceOn = true;
            }
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
            for (int i = 0; i < listaPuntos.Count; i++)
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
                if (!isMouseOutside(e.Location))
                {
                    listaPuntos[indexPointSelected] = e.Location;
                    render();
                }
            }
        }


    }
}
