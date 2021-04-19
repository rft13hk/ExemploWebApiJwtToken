using System.Collections.Generic;
using System.Linq;
using Shop.Models;

namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var user = new List<User>();

             user.Add(new User() {Id = 1, UserName = "batman", Password= "batman", Role="manager" });
             user.Add(new User() {Id = 1, UserName = "robin", Password= "robin", Role="employee" });

            return user.Where( w => w.UserName.ToLower() == username.ToLower() && w.Password == password).FirstOrDefault();
        }
    }
} 