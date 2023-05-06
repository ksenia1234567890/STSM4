using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4_1
{
    // Добавляет значения в список с треугольниками

    interface ITriangleProvider
    {
        List<Triangle> Triangles { get; }
        void SaveTriangles(Triangle triangle);
    }

    // Выводит список с треугольниками: работает как представления в sql

    interface ITriangleService
    {
        List<Triangle> RigthTriangles(List<Triangle> correct);
    }
    public class Triangle: ITriangleProvider, ITriangleService
    {
        // Стороны треугольника
        
        public double a, b, c;
        

        // Конструктор принимает три стороны треугольника

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        
        // Свойство: список треугольников

        public List<Triangle> Triangles
        {
            get
            {
                return Triangles;
            }
        }

        // Сохраняет все треугольники

        public void SaveTriangles(Triangle triangle)
        {
            Triangles.Add(triangle);
        }

        // Проверяет треугольники

       public List<Triangle> RigthTriangles(List <Triangle> notcorrect)
        {
            for(int i =0; i<notcorrect.Count;i++)
            {
                
                // Если стороны треугольника прошли проверку, они добавляются в список
                
                if (Checking(notcorrect[i].a, notcorrect[i].b, notcorrect[i].c)==true)
                {
                    RightTriangles.Add(notcorrect[i]);
                }
                
            }
            
            

        }

        // Проверка треугольника

        public bool Checking(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if ((a >= b + c) || (b >= a + c) || (c >= b + a))
            {
                return false;
            }
            return true;
        }

    }

}
