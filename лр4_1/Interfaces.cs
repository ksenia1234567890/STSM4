using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4_1
{

    // Сохраняет треугольники с список

    interface ITriangleProvider
    {
        List<Triangle> Triangles { get; }
        void SaveTriangles(Triangle triangle);
    }

    // Выводит список с треугольниками

    interface ITriangleService
    {
        List<Triangle> RightTriangles(List<Triangle> notcorrect);
    }
}
