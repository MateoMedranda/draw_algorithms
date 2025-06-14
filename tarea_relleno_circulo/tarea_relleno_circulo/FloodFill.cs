using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_relleno_circulo
{
    class FloodFill
    {
        private HashSet<Point> visited = new HashSet<Point>();
        private PictureBox Canvas;

        public FloodFill() { 
            
        }
        
        public void ReadData(PictureBox picCanvas, HashSet<Point> borderC)
        {
            Canvas = picCanvas;
            visited = visited.Union(borderC).ToHashSet();
        }


        public void miFloodFill(int x, int y, int depth = 0)
        {
            if (depth > 10000)
            {
                IterativeFloodFill(x, y);
                return;
            }

            if (!visited.Contains(new Point(x, y)) && (x > 0 && y > 0 && x < Canvas.Width && y < Canvas.Height))
            {
                drawPixel(x, y);
                miFloodFill(x, y + 1, depth + 1);
                miFloodFill(x + 1, y, depth + 1);
                miFloodFill(x, y - 1, depth + 1);
                miFloodFill(x - 1, y, depth + 1);
            }
        }

        public void IterativeFloodFill(int x, int y)
        {
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();

                if (visited.Contains(p) || p.X <= 0 || p.Y <= 0 || p.X >= Canvas.Width || p.Y >= Canvas.Height)
                    continue;

                drawPixel(p.X, p.Y);

                queue.Enqueue(new Point(p.X + 1, p.Y));
                queue.Enqueue(new Point(p.X, p.Y+1));
                queue.Enqueue(new Point(p.X-1, p.Y));
                queue.Enqueue(new Point(p.X, p.Y - 1));
            }
        }




        public void drawPixel(int x, int y) 
        { 
            visited.Add(new Point(x,y));
            
            Canvas.Invoke(new Action(() =>
            {
                Canvas.CreateGraphics().FillRectangle(Brushes.Black, x, y, 1, 1);
            }));
        }

    }
}
