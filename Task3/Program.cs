using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");

            Operator ChrisParollo = new Operator("Aboba", "Biba", "Opera");
            ChrisParollo.Information();

            Rifleman JackDaSilva = new Rifleman("Silva", "Da Silva's", "Tor", 28, "Con");
            JackDaSilva.Information();

            Leader Ozz = new Leader("Ez", "Ezzy", "Squad", 36, "Base");
            Ozz.Information();

            Operatormobil DeSantos = new Operatormobil("Damn", "Yoy", "Holly", "MoM");
            DeSantos.Information();

            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}
