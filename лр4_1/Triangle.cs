using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4_1
{
    public class Triangle : ITriangleProvider, ITriangleService
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

        // Проверяет треугольники и добавляет в список правильные

        public List<Triangle> RightTriangles(List<Triangle> notcorrect)
        {
            // Список с правильными треугольниками

            List<Triangle> correct_triangles = new List<Triangle>(); 

            // Цикл перебирает треугольники в списке со всеми треугольниками

            for (int i = 0; i < notcorrect.Count; i++)
            {

                // Если стороны треугольника прошли проверку, они добавляются в список

                if (Checking(notcorrect[i].a, notcorrect[i].b, notcorrect[i].c) == true)
                {
                     correct_triangles.Add(notcorrect[i]);
                }
            }
            return correct_triangles;
        }

        // Проверка сторон треугольника

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

        // Метод Площадь треугольника

        public double Square()
        {
                double p = (a + b + c) / 2;
                double ch = p * (p - a) * (p - b) * (p - c);
                double s = Math.Sqrt(ch);
                return Math.Round(s);
        }

        // Метод: определение вида треугольника:прямо-, остро- или тупоугольный
        public string TypeTriangle()
        {
            double max = Math.Max((Math.Max(a, b)), c);
            double min = Math.Min((Math.Min(a, b)), c);
            double ave = (a + b + c) - max - min;
            double max_s = Math.Pow(max, 2);
            double min_s = Math.Pow(min, 2);
            double ave_s = Math.Pow(ave, 2);
            if (max_s == ave_s + min_s)
            {
                return "Прямоугольный";
            }
            if (max_s > ave_s + min_s)
            {
                return "Тупоугольный";
            }
            if (max_s < ave_s + min_s)
            {
                return "Остроугольный";
            }
            return "";
        }

        // Метод: определение вида треугольника: равнобедренный, разно- или равносторонний
        public string KindTriangle()
        {
           
            // Разносторонний

            if(a!=b && a!=c && c!=b)
            {
                return "Разносторонний";
            }

            // Равнобедренный

            if((a==b && a!=c )|| (b==c && b!=a) || (c==a && c!=b))
            {
                return "Равнобедренный";
            }

            // Равносторонний треугольник

            if (a == b && a == c)
            {
                return "Равносторонний";
            }

            // Если ни одно из условий не выполняется

            return "";
        }

    }
}

