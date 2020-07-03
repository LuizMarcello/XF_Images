using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImagemExercicio4();
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
