using System;
using System.Collections.Generic;

namespace cicdaspnetcoredemo.data
{
    public interface IUserService
    {
        public List<User> GetUsers();
    }
}
