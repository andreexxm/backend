using System;
using System.Threading;

namespace EventsExercise.Entities
{
    public delegate void AnnouceMarkDelegate(string name, int mark);

    public class Trainer
    {
        public event AnnouceMarkDelegate EventHandler;

        public void Announce(string name, int mark)
        {
            Console.WriteLine($"Student {name} got a mark {mark}");

            EventHandler?.Invoke(name, mark);
            Thread.Sleep(5000);
        }
    }
}
