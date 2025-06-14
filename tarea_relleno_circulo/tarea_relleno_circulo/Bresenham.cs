using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Bresenham
    {
        private Point Pi;
        private Point Pf;
        private int deltaX;
        private int deltaY;
        private int doubleDeltaX;
        private int doubleDeltaY;
        private float m;
        private int k;
        private int p;
        private int cont;
        private Graphics mGraph;
        private Pen mPen;
        private string contString = "";
        private string XString = "";
        private string YString = "";
        private Label NLabel;
        private Label XLabel;
        private Label YLabel;

        public Bresenham()
        {
            Pi = new Point(0, 0);
            Pf = new Point(0, 0);
            deltaX = 0;
            deltaY = 0;
            doubleDeltaX = 0;
            doubleDeltaY = 0;
            cont = 0;
        }

        public void ReadData(Point point1, Point point2, PictureBox picCanvas, Label N, Label X, Label Y)
        {
            Pi = point1;
            Pf = point2;
            mGraph = picCanvas.CreateGraphics();
            cont = 0;
            NLabel = N;
            XLabel = X;
            YLabel = Y;

        }

        public void CalculateConstant()
        {
            deltaX = Pf.X - Pi.X;
            deltaY = Pf.Y - Pi.Y;
            doubleDeltaX = 2 * deltaX;
            doubleDeltaY = 2 * deltaY;
        }

        public void CalculatePendient()
        {
            m = (float)deltaY / (float)deltaX;
        }

        public void CalculateKValor()
        {
            if (Math.Abs(deltaX) > Math.Abs(deltaY))
            {
                k = Math.Abs(deltaX);
            }
            else
            {
                k = Math.Abs(deltaY);
            }
        }

        public void CalculatePValor()
        {
            if (Math.Abs(m) > 0 && Math.Abs(m) < 1)
            {
                p = doubleDeltaY - deltaX;
            }
            else if (Math.Abs(m) > 1)
            {
                p = doubleDeltaX - deltaY;
            }
        }

        public void CalculatePoints()
        {
            plotInitialPoints();
            int xk = Pi.X;
            int yk = Pi.Y;

            int pk = p;

            for (int i = 0; i <= k; i++)
            {
                plotPoint(new Point(xk, yk));
                CreateStringPoints(xk, yk);
                if (Math.Abs(m) > 0 && Math.Abs(m) < 1)
                {
                    if (pk < 0)
                    {
                        pk = pk + 2 * deltaY;
                    }
                    else if (pk > 0)
                    {
                        pk = pk + doubleDeltaY - doubleDeltaX;
                        yk++;
                    }
                    xk++;
                }
                else if (Math.Abs(m) > 1)
                {
                    if (pk < 0)
                    {
                        pk = pk + 2 * deltaX;
                    }
                    else if (pk > 0)
                    {
                        pk = pk + doubleDeltaX - doubleDeltaY;
                        xk++;
                    }
                    yk++;
                }
            }
        }


        public void plotPoint(Point point)
        {
            mPen = new Pen(Color.Blue, 2);
            mGraph.DrawRectangle(mPen, point.X, -point.Y, 1, 1);
        }

        public void plotInitialPoints()
        {
            mPen = new Pen(Color.Red, 2);
            mGraph.DrawRectangle(mPen, Pf.X, -Pf.Y, 6, 6);
            mGraph.DrawRectangle(mPen, Pi.X, -Pi.Y, 6, 6);
        }

        private void CreateStringPoints(int x, int y)
        {
            cont++;
            contString += cont + "\n";
            XString += x + "\n";
            YString += y + "\n";
            NLabel.Text = contString;
            XLabel.Text = XString;
            YLabel.Text = YString;
        }


    }

}
