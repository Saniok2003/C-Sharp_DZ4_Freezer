using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DZ_4
{
    class Freezer
    {
        private double width;
        private double height;
        private double weight;
        private bool isOpen;
        private readonly int id;
        public int Id => id;
        private static int count;
        public static int GetCount()
        { return count; }
        public double GetHeight()
        { return this.height; }
        public void SetHeight(double value)
        {
            if (value >= 0)
                this.height = value;
            else
                this.height = 0;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public void SetWidth(double value)
        {
            if (value >= 0)
                this.width = value;
            else
                this.width = 0;
        }

        public static string Name { get; set; }
        static Freezer()
        {
            Name = "Atlant";
            count = 1000;
        }
        public Freezer()
        {
            width = 0;
            height = 0;
            weight = 0;
            isOpen = false;
            id = count++;
        }
        public Freezer(double w, double h, double we, bool isOpen)
        {
            this.width = w >= 0.1 ? w : 0;
            this.height = h >= 0.1 ? h : 0;
            this.isOpen = isOpen;
            this.weight = we;
            id = count++;
        }
        public Freezer(double w, double h) : this(w, h, 0, false)
        { }
        public void SetIsOpen(bool d)
        {
            isOpen = d;
        }
        public void Show()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~Show()\nRoute name: {Name}\nSize: {width} : {height}\nWeight: {weight}\nId: {id}\n" + $"{(isOpen ? "Opened" : "Closed")}");
        }
        public override string ToString()
        {
            return $"~~~~~~~~~~~~~~ToString()\nRoute name: {Name}\nSize: {width} : {height}\nWeight: {weight}\nId: {id}\n{(isOpen ? "Opened" : "Closed")}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Freezer f1 = new Freezer(140, 230, 78, false);
            f1.Show();
            Freezer f2 = new Freezer(150, 220, 70, false);
            Console.WriteLine(f2.ToString());
            Freezer f3 = new Freezer(175, 210, 80, true);
            f3.Show();
            Freezer f4 = new Freezer(180, 240, 105, false);
            Console.WriteLine(f4.ToString());
            Freezer f5 = new Freezer(120, 160, 60, true);
            Console.WriteLine(f5.ToString());

        }
    }
}
