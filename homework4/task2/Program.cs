using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Hyndai", 300);
            car1.Model = "Hyndai";
            car1.Speed = 300;

            Car car2 = new Car();
            car2.Model = "Mazda";
            car2.Speed = 240;

            Car car3 = new Car();
            car3.Model = "Ferrari";
            car3.Speed = 400;

            Car car4 = new Car();
            car4.Model = "Porche";
            car4.Speed = 450;

            Driver driver1 = new Driver("Bob", 5);
            Driver driver2 = new Driver("Jill", 7);
            Driver driver3 = new Driver("Sam", 3);
            Driver driver4 = new Driver("Anne", 10);


            string carChoice1 = Console.ReadLine();
            string carChoice2 = Console.ReadLine();

            string driverChoice1 = Console.ReadLine();
            string driverChoice2 = Console.ReadLine();

            if (carChoice1 == carChoice2)
            {
                Console.WriteLine("You have to choose different cars!");
            } else if (driverChoice1 == driverChoice2)
            {
                Console.WriteLine("You have to choose different drivers!");
            } else
            {
                switch (carChoice1)
            }

            }


        }

        public class Driver
        {
            public string DriverName { get; set; }
            public int Skill { get; set; }

            public Driver(string name, int skill)
            {
                DriverName = name;
                Skill = skill;
            }
        }



        public class Car : Driver
        {
            public string Model { get; set; }
            public int Speed { get; set; }
            public string Driver { get; set; }

            public Car(string model, int speed, string driver)
            {
                Model = model;
                Speed = speed;
                Driver = driver;
            }



            private int CalculateSpeed()
            {
                int carSpeed = Speed * Skill;
                return carSpeed;
            }

            public string RaceCars(string one, string two)
            {

            }


        }

        //https://github.com/sedc-codecademy/skwd9-net-05-oopcsharp/blob/main/G4/Class05/Homework.md

    }
}
