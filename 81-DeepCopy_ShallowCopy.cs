using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    struct Vector
    {
        public int X;
        public int Y;
    }

    class Point
    {
        public int X;
        public int Y;
    }
     /*구조체와 클래스의 차이점
    Vector v1;
        
    v1.X = 5;
    v1.Y = 10;
    
    Vector v2 = v1; 값 형식의 대입

    Point pt1 = new Point();
    pt1.X = 6;
    pt1.Y = 12;

    Point pt2 = pt1; 참조 형식의 대입
    */
}
