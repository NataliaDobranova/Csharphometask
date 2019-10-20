using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public partial class Motorbike
    {


        partial void Move(float speed)
        {
            Console.WriteLine("This bike move with the next speed: " + speed);
        }

    }
}