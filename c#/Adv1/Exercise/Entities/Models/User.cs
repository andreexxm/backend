using System;
using Exercise.Entities.Interfaces;

namespace Exercise.Entities.Models
{
    public abstract class User : IUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(int id, string name, string username, string password)
        {
            ID = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public abstract void PrintInfo();
    }
}
