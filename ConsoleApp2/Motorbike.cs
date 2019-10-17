using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Motorbike
    {
        private ModelEnum model;
        private float price;
        private float volume_tank;
        private int max_speed;
        private int Pengine;



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Pengine.ToString());
            sb.AppendLine(this.max_speed.ToString());
            sb.AppendLine(this.volume_tank.ToString());
            sb.AppendLine(this.price.ToString());
            sb.AppendLine(this.model.ToString());

            return sb.ToString();
        }

        public Motorbike()  {  }



        public void Hello(Motorbike motorbike)
        {
            Console.WriteLine("Hello! I have a motorbike with next characteristics:" + motorbike);
        }
    }
}
