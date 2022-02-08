using System;
namespace AbstractClasses.Entities.Interfaces
{
    public interface ITester
    {
        int BugsFoud { get; set; }
        void TestFeature(string feature);
    }
}
