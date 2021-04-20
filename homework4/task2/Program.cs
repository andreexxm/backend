using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Car car1 = new Car("Hyndai", 300, new Driver());

            Car car2 = new Car("Mazda", 200, new Driver());

            Car car3 = new Car("Ferrari", 400, new Driver());

            Car car4 = new Car("Porche", 450, new Driver());

            Car One;
            Car Two;


            Driver driver1 = new Driver("Bob", 5);
            Driver driver2 = new Driver("Jill", 7);
            Driver driver3 = new Driver("Sam", 3);
            Driver driver4 = new Driver("Anne", 10);


            string carChoice1 = Console.ReadLine().ToLower();
            string carChoice2 = Console.ReadLine().ToLower();

            string driverChoice1 = Console.ReadLine().ToLower();
            string driverChoice2 = Console.ReadLine().ToLower();

            if (carChoice1 == carChoice2)
            {
                Console.WriteLine("You have to choose different cars!");
            }
            else if (driverChoice1 == driverChoice2)
            {
                Console.WriteLine("You have to choose different drivers!");
            }
            else
            {
                switch (carChoice1)
                {
                    case "hyndai":
                        {
                            switch (driverChoice1)
                            {
                                case "bob":
                                    car1.Driver = driver1;
                                    break;
                                case "jill":
                                    car1.Driver = driver2;
                                    break;
                                case "sam":
                                    car1.Driver = driver3;
                                    break;
                                case "anne":
                                    car1.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            One = car1;
                        }
                        break;
                    case "mazda":
                        {
                            switch (driverChoice1)
                            {
                                case "bob":
                                    car2.Driver = driver1;
                                    break;
                                case "jill":
                                    car2.Driver = driver2;
                                    break;
                                case "sam":
                                    car2.Driver = driver3;
                                    break;
                                case "anne":
                                    car2.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            One = car2;
                        }
                        break;

                    case "ferrari":
                        {
                            switch (driverChoice1)
                            {
                                case "bob":
                                    car3.Driver = driver1;
                                    break;
                                case "jill":
                                    car3.Driver = driver2;
                                    break;
                                case "sam":
                                    car3.Driver = driver3;
                                    break;
                                case "anne":
                                    car3.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            One = car3;
                        }
                        break;

                    case "porche":
                        {
                            switch (driverChoice1)
                            {
                                case "bob":
                                    car4.Driver = driver1;
                                    break;
                                case "jill":
                                    car4.Driver = driver2;
                                    break;
                                case "sam":
                                    car4.Driver = driver3;
                                    break;
                                case "anne":
                                    car4.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            One = car4;
                        }
                        break;

                    default:
                        Console.WriteLine("Why didnt u just follow the simple instructions? go back and pick a car again");
                        break;
                }

                switch (carChoice2)
                {
                    case "hyndai":
                        {
                            switch (driverChoice2)
                            {
                                case "bob":
                                    car1.Driver = driver1;
                                    break;
                                case "jill":
                                    car1.Driver = driver2;
                                    break;
                                case "sam":
                                    car1.Driver = driver3;
                                    break;
                                case "anne":
                                    car1.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            Two = car1;
                        }
                        break;
                    case "mazda":
                        {
                            switch (driverChoice2)
                            {
                                case "bob":
                                    car2.Driver = driver1;
                                    break;
                                case "jill":
                                    car2.Driver = driver2;
                                    break;
                                case "sam":
                                    car2.Driver = driver3;
                                    break;
                                case "anne":
                                    car2.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            Two = car2;
                        }
                        break;

                    case "ferrari":
                        {
                            switch (driverChoice2)
                            {
                                case "bob":
                                    car3.Driver = driver1;
                                    break;
                                case "jill":
                                    car3.Driver = driver2;
                                    break;
                                case "sam":
                                    car3.Driver = driver3;
                                    break;
                                case "anne":
                                    car3.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                            Two = car3;
                        }
                        break;

                    case "porche":
                        {
                            switch (driverChoice2)
                            {
                                case "bob":
                                    car4.Driver = driver1;
                                    break;
                                case "jill":
                                    car4.Driver = driver2;
                                    break;
                                case "sam":
                                    car4.Driver = driver3;
                                    break;
                                case "anne":
                                    car4.Driver = driver4;
                                    break;
                                default:
                                    Console.WriteLine("Buddy, u fucked up somewhere");
                                    break;
                            }
                             Two = car4;
                        }
                        break;

                    default:
                        Console.WriteLine("Why didnt u just follow the simple instructions? go back and pick a car again");
                        break;
                }

            }

            Console.WriteLine($"{Car.RaceCars(One, Two)}");

        }

        //Classes

        public class Driver
        {
            public string DriverName { get; set; }
            public int Skill { get; set; }

            public Driver ()
            {
            }
            public Driver(string name, int skill)
            {
                DriverName = name;
                Skill = skill;
            }
        }



        public class Car
        {
            public string Model { get; set; }
            public int Speed { get; set; }
            public Driver Driver { get; set; }

            public Car()
            {
            }

            public Car(string model, int speed, Driver driver)
            {
                Model = model;
                Speed = speed;
                Driver = driver;
            }



            private int CalculateSpeed()
            {
                int carSpeed = Speed * Driver.Skill;
                return carSpeed;
            }



            public void RaceCars(Car one, Car two)
            {
                if (one.CalculateSpeed() > two.CalculateSpeed())
                {
                    Console.WriteLine("Car 1 is faster");
                }
                else if (one.CalculateSpeed() < two.CalculateSpeed())
                {
                    Console.WriteLine("Car 2 is faster");
                }
                else
                {
                    Console.WriteLine("Both cars have the same speed");
                }
            }
        }
    }
}
