using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Bezier
    {

        public Bezier()
        {

        }

        private void plotPoint(Point point, Graphics g)
        {
            g.FillRectangle(Brushes.Black, point.X, point.Y, 1, 1);
        }

        public Point Linear(Point p0, Point p1, float t)
        {
            float x = (1 - t) * p0.X + t * p1.X;
            float y = (1 - t) * p0.Y + t * p1.Y;
            return new Point((int)x, (int)y);
        }

        public Point Cuadratic(Point p0, Point p1, Point p2, float t)
        {
            float x = (float)Math.Pow((1 - t), 2) * p0.X + 2 * (1 - t) * t * p1.X + (float)Math.Pow(t, 2) * p2.X;
            float y = (float)Math.Pow((1 - t), 2) * p0.Y + 2 * (1 - t) * t * p1.Y + (float)Math.Pow(t, 2) * p2.Y;
            return new Point((int)x, (int)y);
        }

        public Point Cubic(Point p0, Point p1, Point p2, Point p3, float t)
        {
            float x = (float)Math.Pow((1 - t), 3) * p0.X + 3 * (float)Math.Pow((1 - t), 2) * t * p1.X + 3 * (1 - t) * (float)Math.Pow(t, 2) * p2.X + (float)Math.Pow(t, 3) * p3.X;
            float y = (float)Math.Pow((1 - t), 3) * p0.Y + 3 * (float)Math.Pow((1 - t), 2) * t * p1.Y + 3 * (1 - t) * (float)Math.Pow(t, 2) * p2.Y + (float)Math.Pow(t, 3) * p3.Y;
            return new Point((int)x, (int)y);
        }

        public void LinearDraw(Point p0, Point p1, Graphics g)
        {
            for (float i = 0; i < 1; i = i + (float)0.001)
            {
                plotPoint(Linear(p0, p1, i), g);
            }
        }

        public void CuadraticDraw(Point p0, Point p1, Point p2, Graphics g)
        {
            for (float i = 0; i < 1; i = i + (float)0.001)
            {
                plotPoint(Cuadratic(p0, p1, p2, i), g);
            }
        }

        public void CubicDraw(Point p0, Point p1, Point p2, Point p3, Graphics g)
        {
            for (float i = 0; i < 1; i = i + (float)0.001)
            {
                plotPoint(Cubic(p0, p1, p2, p3, i), g);
            }
        }
    }
}
