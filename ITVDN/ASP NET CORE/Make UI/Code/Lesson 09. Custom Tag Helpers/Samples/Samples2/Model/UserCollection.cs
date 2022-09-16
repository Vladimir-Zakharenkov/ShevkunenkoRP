using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperSample.Model
{
    public class UserCollection
    {
        public static List<User> Users { get; set; } = new List<User>();

        static UserCollection()
        {
            Users.Add(new User() { Id = 1, Name = "User 1", Balance = 100.1 });
            Users.Add(new User() { Id = 2, Name = "User 2", Balance = 30.5 });
            Users.Add(new User() { Id = 3, Name = "User 3", Balance = -12.3 });
            Users.Add(new User() { Id = 4, Name = "User 4", Balance = 0.0 });
            Users.Add(new User() { Id = 5, Name = "User 5", Balance = -22.8 });
            Users.Add(new User() { Id = 6, Name = "User 6", Balance = 3.0 });
        }
    }
}
