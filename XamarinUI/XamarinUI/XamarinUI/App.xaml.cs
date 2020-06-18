using Xamarin.Forms;
using XamarinUI.Pages;
using XamarinUI.Pages.Test;

namespace XamarinUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new TestListView();
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
