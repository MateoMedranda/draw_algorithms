using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Circunferencia
    {
        private PictureBox picCanvas;
        private int xc;
        private int yc;
        private int r;
        private int cont = 0;
        private string contString = "";
        private string XString = "";
        private string YString = "";
        private HashSet<Point> visited = new HashSet<Point>();
        private Label NLabel;
        private Label XLabel;
        private Label YLabel;

        public Circunferencia()
        {
            xc = 0;
            yc = 0;
            r = 0;
        }

        public void readData(Point center, int radio, PictureBox Canvas, Label N, Label X, Label Y )
        {
            xc = center.X; yc = center.Y; r = radio;
            picCanvas = Canvas;
            NLabel = N;
            XLabel = X;
            YLabel = Y;
            cont = 0;
            contString = "";
            XString = "";
            YString = "";
        }


        public void DrawCircleMidPoint()
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            PlotCirclePoints(x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                PlotCirclePoints(x, y);
            }
        }

        private void PlotCirclePoints(int x, int y)
        {
            plotPoint(xc + x, yc + y);
            plotPoint(xc - x, yc + y);
            plotPoint(xc + x, yc - y);
            plotPoint(xc - x, yc - y);
            plotPoint(xc + y, yc + x);
            plotPoint(xc - y, yc + x);
            plotPoint(xc + y, yc - x);
            plotPoint(xc - y, yc - x);
        }

        private void plotPoint(int x, int y)
        {
            visited.Add(new Point(x, y));
            picCanvas.Invoke(new Action(() =>
            {
                CreateStringPoints(x, y);
                picCanvas.CreateGraphics().FillRectangle(Brushes.Black, x, y, 1, 1);

            }));
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

        public HashSet<Point> getBorderPoints()
        {
            return visited;
        }
    }
}
