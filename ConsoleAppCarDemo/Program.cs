using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCarDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car Ford = new Car(22);
            Ford.Model = 10;
            Car BMW = Ford;
            BMW.Display_Model();
            Ford.Display_Model();
        }
    }

    class Car
    {
        public int Model;
        public Car(int a)
        {
            Model = a;
        }
        public void Display_Model()
        {
            Console.WriteLine(Model);
            Console.ReadKey();
        }
    }

}
