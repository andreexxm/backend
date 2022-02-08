using System;
namespace GenericsExercise1.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void PrintInfo()
        {
           switch (Size)
            {
                case "xs":
                    Console.WriteLine("Where's the fishy");
                    break;
                case "s":
                    Console.WriteLine("Tiny baby");
                    break;
                case "m":
                    Console.WriteLine("I'm right here betchhh");
                    break;
                case "l":
                    Console.WriteLine("Fluffy fish");
                    break;
                case "xl":
                    Console.WriteLine("ohhh he's a big boyy");
                    break;
                default:
                    break;

            }
        }
    }
}
