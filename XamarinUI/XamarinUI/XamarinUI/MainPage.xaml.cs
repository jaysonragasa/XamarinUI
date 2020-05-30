using System.ComponentModel;
using Xamarin.Forms;
using XamarinUI.ViewModels;

namespace XamarinUI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ((ViewModelLocator)this.BindingContext).FriendsList.RefreshData();
        }
    }
}
