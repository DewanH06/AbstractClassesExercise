using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"This Motorcycle is driving abstractly.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} is a {GetType().BaseType.Name} and drives virtually");
        }
    }
}