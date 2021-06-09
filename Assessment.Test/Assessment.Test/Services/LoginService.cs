using Assessment.Test.Models;
using Assessment.Test.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Test.Services
{
    public class LoginService : ILoginService
    {
        List<UserModel> userList = new List<UserModel>();

        public LoginService()
        {
            userList.Add(new UserModel { userName = "user1", password = "12345" });
            userList.Add(new UserModel { userName = "user2", password = "54321" });
        }
        public bool login(string userName, string password)
        {
            foreach (var user in userList)
            {
                if (userName == user.userName & password == user.password)
                {
                    return true;
                }                                                
            }
            return false;
        }
    }
}
