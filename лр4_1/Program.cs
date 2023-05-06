using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4_1
{
    public class Program
    {
        static void Main()
        {
            // Создание треугольника
            
            Triangle tr1 = new Triangle(3, 2, 3);
            tr1.KindTriangle();
            tr1.TypeTriangle();
            tr1.Square();
            tr1.SaveTriangles(tr1);
            tr1.RightTriangles(tr1.Triangles);

        }
    }
}
