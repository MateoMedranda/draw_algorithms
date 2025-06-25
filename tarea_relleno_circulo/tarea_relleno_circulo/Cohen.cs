using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class Cohen
    {
        private Point pointMax;
        private Point pointMin;
        private int codePoint1;
        private int codePoint2;
        private Point point1;
        private Point point2;
        const int INSIDE = 0;
        const int LEFT = 1;
        const int RIGHT = 2;
        const int BOTTOM = 4;
        const int TOP = 8;

        public Cohen()
        {

        }

        public void readData(Point point1S, Point point2S, Point pointma, Point pointmi)
        {
            pointMax = pointma;
            pointMin = pointmi;
            point1 = point1S;
            point2 = point2S;
        }

        private int calculateCode(Point point)
        {
            int code = INSIDE;

            if (point.X < pointMin.X)
            {
                code |= LEFT;
            }
            else if (point.X > pointMax.X)
            {
                code |= RIGHT;
            }

            if (point.Y < pointMin.Y)
            {
                code |= BOTTOM;
            }
            else if (point.Y > pointMax.Y)
            {
                code |= TOP;
            }
            return code;
        }

        private void calculatePointsCode()
        {
            codePoint1 = calculateCode(point1);
            codePoint2 = calculateCode(point2);
        }

        private bool AceptTrivialCase()
        {
            return codePoint1 == 0 && codePoint2 == 0;
        }

        private bool RejectTrivialCase()
        {
            int codeAND = codePoint1 & codePoint2;
            if (codeAND == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Point calculateIntersection(Point pointA, Point pointB, int codeOut)
        {
            int dx = pointB.X - pointA.X;
            int dy = pointB.Y - pointA.Y;
            float m = (float)dy / (float)dx;


            Point intersection = new Point();

            if ((codeOut & TOP) != 0)
            {
                intersection.X = (int)((pointMax.Y - pointA.Y) / m) + pointA.X;
                intersection.Y = pointMax.Y;
            }
            else if ((codeOut & BOTTOM) != 0)
            {
                intersection.X = (int)((pointMin.Y - pointA.Y) / m) + pointA.X;
                intersection.Y = pointMin.Y;
            }
            else if ((codeOut & RIGHT) != 0)
            {
                intersection.Y = (int)(m * (pointMax.X - pointA.X) + pointA.Y);
                intersection.X = pointMax.X;
            }
            else if ((codeOut & LEFT) != 0)
            {
                intersection.Y = (int)(m * (pointMin.X - pointA.X) + pointA.Y);
                intersection.X = pointMin.X;
            }

            return intersection;
        }

        public List<Point> calculateNewPoints()
        {
            List<Point> newPoints = new List<Point>();
            Point pointI;


            calculatePointsCode();

            bool accept = false;

            while (true)
            {
                if (AceptTrivialCase())
                {
                    accept = true;
                    break;
                }
                else if (RejectTrivialCase())
                {
                    point1 = new Point(0, 0);
                    point2 = new Point(0, 0);
                    break;
                }
                else
                {
                    int codeOut;

                    if (codePoint1 != 0)
                    {
                        codeOut = codePoint1;
                    }
                    else
                    {
                        codeOut = codePoint2;
                    }

                    pointI = calculateIntersection(point1, point2, codeOut);

                    if (codeOut == codePoint1)
                    {
                        point1 = pointI;
                        codePoint1 = calculateCode(point1);
                    }
                    else
                    {
                        point2 = pointI;
                        codePoint2 = calculateCode(point2);
                    }
                }
            }
            newPoints.Add(point1);
            newPoints.Add(point2);
            return newPoints;
        }
    }
}
