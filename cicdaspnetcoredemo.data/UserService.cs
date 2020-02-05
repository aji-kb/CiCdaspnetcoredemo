using System;
using System.Collections.Generic;

namespace cicdaspnetcoredemo.data
{
    public class UserService : IUserService
    {
        private List<User> users;
        public UserService()
        {
            this.users = new List<User> {
                new User { Name="A", PhoneNumber="100"},
                new User { Name="B", PhoneNumber="200"},
                new User { Name="C", PhoneNumber="300"}
                new User { Name="D", PhoneNumber="400"}
            };
        }

        public List<User> GetUsers()
        {

            return this.users;
        }
    }
}
