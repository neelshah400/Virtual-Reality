using System;
using System.Collections.Generic;

namespace EquilateralPolygon
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Square> list = new List<Square>();
            list.Add(new Square(6));
            list.Add(new Square(2.5));
            list.Add(new Square(13));
            list.Add(new Square(1));
            list.Add(new Square(9.5));

            Console.WriteLine("Squares:\n");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("{0}: {1}", i, list[i]);

            Console.WriteLine("\nSum of Perimeters: {0}", SumPerimeters(list));

            var result = LargestSquare(list);
            Console.WriteLine("\nSquare With Largest Area:\n\n{0}: {1}", result.index, result.value);
            
        }

        public static double SumPerimeters(List<Square> list)
        {
            double sum = 0;
            foreach (Square square in list)
                sum += square.Perimeter;
            return sum;
        }

        public static (int index, Square value) LargestSquare(List<Square> list)
        {
            int index = 0;
            Square value = list[index];
            for (int i = 1; i < list.Count; i++)
            {
                Square square = list[i];
                if (square.Area > value.Area)
                {
                    index = i;
                    value = square;
                }
            }
            return (index: index, value: value);
        }

    }
}
