using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class DDA
    {
        private Point Pi;
        private Point Pf;
        private int deltaX;
        private int deltaY;
        private int k;
        private float m;
        private float xIncrement;
        private float yIncrement;
        private Graphics mGraph;
        private Pen mPen;
        private int cont;
        private string contString = "";
        private string XString = "";
        private string YString = "";
        private Label NLabel;
        private Label XLabel;
        private Label YLabel;

        public DDA()
        {
            Pi = new Point(0, 0);
            Pf = new Point(0, 0);
            deltaX = 0;
            deltaY = 0;
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

        public void CalculatePoints()
        {
            float xk = Pi.X;
            float yk = Pi.Y;
            plotInitialPoints();

            for (int i = 0; i < k; i++) 
            {
                plotPoint(new Point((int)Math.Round(xk), (int)Math.Round(yk)));
                CreateStringPoints((int)Math.Round(xk), (int)Math.Round(yk));
                if (m <= 1)
                {
                    yk =( yk + m);
                    xk++;
                }else if (m > 1)
                {
                    xk = (xk + 1/m);
                    yk++;
                }
            }
        }

        public void plotPoint(Point point)
        {
            mPen = new Pen(Color.Green, 2);
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
            YString += (-y) + "\n";
            NLabel.Text = contString;
            XLabel.Text = XString;
            YLabel.Text = YString;
        }
    }
}
