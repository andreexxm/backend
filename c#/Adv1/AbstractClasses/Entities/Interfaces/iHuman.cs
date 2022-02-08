using System;
namespace AbstractClasses.Entities.Interfaces
{
    public interface iHuman
    {
        //we only put the signature without the access modifier
        string GetInfo();

        void Greet(string name);
    }
}
