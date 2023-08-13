using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Мыларщиков";
            string secondName = "Илья";

            Console.WriteLine($"Имя: {name}\nФамилия: {secondName}");

            (name, secondName) = (secondName, name);

            Console.WriteLine($"Имя: {name}\nФамилия: {secondName}");
        }
    }
}
