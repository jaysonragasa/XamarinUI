
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUI.ViewModels;

namespace XamarinUI.Pages.CollectionView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnlineFriendsList : ContentPage
    {
        public OnlineFriendsList()
        {
            InitializeComponent();
        }

        protected override async void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            await ((ViewModelLocator)this.BindingContext).FriendsList.RefreshData();
        }
    }
}