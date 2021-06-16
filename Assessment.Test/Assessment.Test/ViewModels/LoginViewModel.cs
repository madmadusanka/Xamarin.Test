using Assessment.Test.Models;
using Assessment.Test.ViewModels.Base;
using Assessment.Test.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Assessment.Test.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        

        public Command cmdLogin { get; set; }

        public LoginViewModel()
        {
            cmdLogin = new Command(gotoHomePage);
            userList.Add(new UserModel { userName = "user1", password = "12345" });
            userList.Add(new UserModel { userName = "user2", password = "54321" });
        }

        private void gotoHomePage(object obj)
        {
            if (login(userName,password))
            {
                App.Current.MainPage.Navigation.PushAsync(new StockTransferView());
            }
            else
            {
                LoginMessage = "please enter valid username or password";
                TurnLoginMessage = true;
            }
            
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userName"));
            }
        }

        private string loginMessage;
        public string LoginMessage
        {
            get { return loginMessage; }
            set
            {
                loginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginMessage"));
            }
        }

        private bool turnLoginMessage;
        public bool TurnLoginMessage
        {
            get { return turnLoginMessage; }
            set
            {
                turnLoginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessage"));
            }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("password"));
            }
        }

        List<UserModel> userList = new List<UserModel>();
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
