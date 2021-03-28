
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
                Console.WriteLine(car.Id);
                Console.WriteLine(car.ModelYear);


            }

            Console.WriteLine("saygılarımı sunarım");
        }
    }
}
