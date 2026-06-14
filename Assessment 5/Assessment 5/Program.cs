using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //question number 5

            Vehicle v1 = new Car("Toyota Supra", 2022);

            Vehicle v2 = new Motorcycle("Yammaha R1", 2021);

            Vehicle v3 = new ElectricScooter("Xiaomi M365", 2024);//upcast


            //question number 6
            v1.StartEngine();
            v2.StartEngine();
            v3.StartEngine();
            Console.WriteLine();

            v1.Move();
          //v1.OppenTrunk();//it doesn't work to work it needs to be downcasted
            v2.Move();
            v3.Move();// this function is not overridedn in the EleScoot
            Console.WriteLine();

            Console.WriteLine(v1.Describe());
            Console.WriteLine(v2.Describe());//this function is ont overriden in the motor
            Console.WriteLine(v3.Describe());// it was hidden with the new keywork
            Console.WriteLine();

            Car car = (Car)v1; //downcast
            car.OppenTrunk();


            //Vehicle v2 = new Motorcycle("Yammaha R1", 2021);
            //Car car1 = v2 as Car; //downcast v2 car

            Car car1 = (Car)v2; //downcast v2 car

            //quetion 9

            Motorcycle m1 = v3 as Motorcycle;// downcast ELScoot to Mote

            //question 10

            if(m1 is  Motorcycle )//this one  check's the type if m1 is a motor or not
            {
                m1.PopWheelie();
            }

        }
    }
}
