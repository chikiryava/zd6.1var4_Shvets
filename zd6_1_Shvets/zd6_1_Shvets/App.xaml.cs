using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_1_Shvets
{
    public partial class App :Application
    {
        public App ()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Start());
            MainPage = new Main("1515","1515");
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
