using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Point
    {
        int x, y;

        public Point(int x, int y )
        {
            this.x = x;
            this.y = y;
        }
    }
    abstract class DrawingObject // 추상 클래스
    {
        public abstract void Draw(); //추상 메서드

        public void Move() { Console.WriteLine("Move");  }
    }

    class Line : DrawingObject
    {
        Point pt1, pt2;
        public Line(Point pt1, Point pt2)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
        }

        public override void Draw()
        {
            Console.WriteLine("Line " + pt1.ToString() + " ~ " + pt2.ToString());
        }
    }
}
