using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public partial class Motorbike
    {
        private ModelEnum model;
        private float price;
        private float volume_tank;
        private int speed;
        private int Pengine;

        public static int amount_of_wheels;
        public static string country_of_regisration;

        static Motorbike()
        {
            amount_of_wheels = 2;
            country_of_regisration = "Belarus";
        }

        public Motorbike()
        {
            model = ModelEnum.Jawa;
            price = 5000;
            volume_tank = 18.5f;
            speed = 190;
            Pengine = 62;
        }

        public Motorbike(ModelEnum model)
        {
            this.model = model;

        }
        public Motorbike(ModelEnum model, float price)
        {
            this.model = model;
            this.price = price;
        }

        public Motorbike(ModelEnum model, float price, float volume_tank)
        {
            this.model = model;
            this.price = price;
            this.volume_tank = volume_tank;
        }

        public Motorbike(ModelEnum model, float price, float volume_tank, int speed, int Pengine)
        {
            this.model = model;
            this.price = price;
            this.volume_tank = volume_tank;
            this.speed = speed;
            this.Pengine = Pengine;
        }


        public void SetModel(ModelEnum mod) { model = mod; }
        public ModelEnum GetModel() { return model; }

        public void SetPrice(float price1) { price = price1; }
        public float GetPrice() { return price; }

        public void SetVolum_tank(float volume) { volume_tank = volume; }
        public float GetVolum_tank() { return volume_tank; }

        public void SetSpeed(int sp) { speed = sp; }
        public int GetSpeed() { return speed; }

        public void SetPengine(int p) { Pengine = p; }
        public int GetPengine() { return Pengine; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.model.ToString());
            sb.AppendLine(this.price.ToString());
            sb.AppendLine(this.volume_tank.ToString());
            sb.AppendLine(this.speed.ToString());
            sb.AppendLine(this.Pengine.ToString());
            return sb.ToString();
        }

        public void Hello()
        {
            Console.WriteLine("Hello! I have a motorbike with next characteristics" +
                " (Model, price, tank volume, speed, engine power):\n" + ToString());
        }

        partial void Move(float speed);

        public float Travel_time(float s)
        {
            Move(speed);
            return s / speed;
        }


        public void Sell_bike()
        {
            Console.WriteLine("This motorbike costs " + price + " euro.\n");
        }

        public bool CompareModels(Motorbike m)
        {
            if (model == m.model) return true;
            else return false;
        }



    }
}
