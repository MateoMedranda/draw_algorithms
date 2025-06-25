using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Sutherland_Hodgman
    {
        private List<Point> polygon;
        private Point pointMax;
        private Point pointMin;

        public void readData(List<Point> Ipolygon, Point IpointMax, Point IpointMin)
        {
            polygon = Ipolygon;
            pointMin = IpointMin;
            pointMax = IpointMax;
        }

        private bool isPointInside(Point point)
        {
            return (point.X >= pointMin.X && point.X <= pointMax.X) &&
                   (point.Y >= pointMin.Y && point.Y <= pointMax.Y);
        }

        private Point calculateIntersection(Point pointA, Point pointB)
        {
            int dx = pointB.X - pointA.X;
            int dy = pointB.Y - pointA.Y;

            if (dx == 0 && dy == 0)
                return pointA;

            Point intersection = new Point();

            if (dx != 0)
            {
                float m = (float)dy / dx;

                float y_at_xmin = m * (pointMin.X - pointA.X) + pointA.Y;
                if (y_at_xmin >= pointMin.Y && y_at_xmin <= pointMax.Y &&
                    ((pointA.X < pointMin.X && pointB.X > pointMin.X) || (pointB.X < pointMin.X && pointA.X > pointMin.X)))
                    return new Point(pointMin.X, (int)y_at_xmin);

                float y_at_xmax = m * (pointMax.X - pointA.X) + pointA.Y;
                if (y_at_xmax >= pointMin.Y && y_at_xmax <= pointMax.Y &&
                    ((pointA.X < pointMax.X && pointB.X > pointMax.X) || (pointB.X < pointMax.X && pointA.X > pointMax.X)))
                    return new Point(pointMax.X, (int)y_at_xmax);
            }

            if (dy != 0)
            {
                float m_inv = (float)dx / dy;

                float x_at_ymin = m_inv * (pointMin.Y - pointA.Y) + pointA.X;
                if (x_at_ymin >= pointMin.X && x_at_ymin <= pointMax.X &&
                    ((pointA.Y < pointMin.Y && pointB.Y > pointMin.Y) || (pointB.Y < pointMin.Y && pointA.Y > pointMin.Y)))
                    return new Point((int)x_at_ymin, pointMin.Y);

                float x_at_ymax = m_inv * (pointMax.Y - pointA.Y) + pointA.X;
                if (x_at_ymax >= pointMin.X && x_at_ymax <= pointMax.X &&
                    ((pointA.Y < pointMax.Y && pointB.Y > pointMax.Y) || (pointB.Y < pointMax.Y && pointA.Y > pointMax.Y)))
                    return new Point((int)x_at_ymax, pointMax.Y);
            }

            return intersection;
        }

        public List<Point> calculatePoints()
        {
            List<Point> newList = new List<Point>();

            for (int i = 0; i < polygon.Count; i++)
            {
                Point current = polygon[i];
                Point next = polygon[(i + 1) % polygon.Count];

                bool currentInside = isPointInside(current);
                bool nextInside = isPointInside(next);

                if (!currentInside && !nextInside)
                    continue;

                if (currentInside && nextInside)
                    newList.Add(next);

                if (currentInside && !nextInside)
                {
                    Point pk = calculateIntersection(current, next);
                    newList.Add(pk);
                }

                if (!currentInside && nextInside)
                {
                    Point pk = calculateIntersection(current, next);
                    newList.Add(pk);
                    newList.Add(next);
                }
            }

            return newList;
        }
    }
}
