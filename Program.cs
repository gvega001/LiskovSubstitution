using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        public static int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle+" has area" +Area(rectangle));

            Square square = new Square();

            square.Width = 4;
            Console.WriteLine($"{square} has are {Area(square)}");
        }
    }
}
