using System;
namespace Exercise
{
    public class dog
    {
        public dog()
        {

        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            return "The dog is eating";
        }

        public string Play()
        {
            return "The dog is playing";
        }

        public string ChaseTail()
        {
            return "The dog is now chasing its tail";
        }
    }
}
