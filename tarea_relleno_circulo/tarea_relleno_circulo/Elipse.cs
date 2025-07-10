using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Elipse
    {
        private PictureBox picCanvas;
        private int xc;
        private int yc;
        private int rx;
        private int ry;
        private int cont = 0;
        private string contString = "";
        private string XString = "";
        private string YString = "";
        private HashSet<Point> visited = new HashSet<Point>();
        private Label NLabel;
        private Label XLabel;
        private Label YLabel;

        public Elipse()
        {
            xc = 0;
            yc = 0;
            rx = 0;
            ry = 0;
        }

        public void readData(Point center, int radioX, int radioY, PictureBox Canvas, Label N, Label X, Label Y)
        {
            xc = center.X; yc = center.Y; rx = radioX; ry = radioY;
            picCanvas = Canvas;
            NLabel = N;
            XLabel = X;
            YLabel = Y;
            cont = 0;
            contString = "";
            XString = "";
            YString = "";
        }

        public void DrawEllipseMidPoint()
        {
            int x = 0;
            int y = ry;

            // Region 1
            double p1 = ry * ry - rx * rx * ry + 0.25 * rx * rx;
            double dx = 2 * ry * ry * x;
            double dy = 2 * rx * rx * y;

            while (dx < dy)
            {
                PlotEllipsePoints(x, y);
                x++;
                dx += 2 * ry * ry;
                if (p1 < 0)
                {
                    p1 += dx + ry * ry;
                }
                else
                {
                    y--;
                    dy -= 2 * rx * rx;
                    p1 += dx - dy + ry * ry;
                }
            }

            // Region 2
            double p2 = ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry;

            while (y >= 0)
            {
                PlotEllipsePoints(x, y);
                y--;
                dy -= 2 * rx * rx;
                if (p2 > 0)
                {
                    p2 += rx * rx - dy;
                }
                else
                {
                    x++;
                    dx += 2 * ry * ry;
                    p2 += dx - dy + rx * rx;
                }
            }
        }

        private void PlotEllipsePoints(int x, int y)
        {
            plotPoint(xc + x, yc + y);
            plotPoint(xc - x, yc + y);
            plotPoint(xc + x, yc - y);
            plotPoint(xc - x, yc - y);
        }

        private void plotPoint(int x, int y)
        {
            Point p = new Point(x, y);
            if (!visited.Contains(p))
            {
                visited.Add(p);
                picCanvas.Invoke(new Action(() =>
                {
                    CreateStringPoints(x, y);
                    picCanvas.CreateGraphics().FillRectangle(Brushes.Black, x, y, 1, 1);
                }));
            }
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
