using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstLine = new FirstString();
            firstLine.Print("blue string");
            String secondLine = new SecondString();
            secondLine.Print("yellow string");
        }
    }

    class String
    {
        public virtual void Print(string argument)
        {
            Console.WriteLine(argument);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

    class FirstString : String
    {
        public override void Print(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(argument);
        }
    }

    class SecondString : String
    {
        public override void Print(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print(argument);
        }
    }

}

