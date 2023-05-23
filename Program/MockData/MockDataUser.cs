using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTTSite.Models;
using Microsoft.AspNetCore.Identity;

namespace CTTSite.MockData
{
    // Made by Christian 
    public class MockDataUser
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();
        private static List<User> users = new List<User>()
        {
            new User("chilterntalkingtherapies@gmail.com", passwordHasher.HashPassword(null, "Admin!88"), true, true),
            new User("testStaff@email.com",  passwordHasher.HashPassword(null,"Test1234"), false, true),
            new User("testClient@email.com",  passwordHasher.HashPassword(null,"Test1234"), false, false)
        };

        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
