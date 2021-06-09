using Assessment.Test.Services;
using Assessment.Test.Services.Interfaces;
using Assessment.Test.ViewModels;
using Assessment.Test.Views;
using Assessment.Test.Views.Base;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assessment.Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Page page = Activator.CreateInstance(typeof(LoginView)) as Page;
            page.BindingContext = DependencyService.Get<LoginViewModel>();
            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
