using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor x = new Editor("1234");

            Console.WriteLine(x.SetDot());
            Console.WriteLine(x.DoEdit(4));
            Console.WriteLine(x.SetDot());
            Console.WriteLine(x.ChangeSign());
            Console.WriteLine(x.AddDigit(12));
        }
    }
}
