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
            Page page = Activator.CreateInstance(typeof(HomeView)) as Page;
            page.BindingContext = DependencyService.Get<HomeViewModel>();
            MainPage = page;
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
