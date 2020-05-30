using GalaSoft.MvvmLight.Ioc;

namespace XamarinUI.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModel_FriendsList FriendsList => SimpleIoc.Default.GetInstance<ViewModel_FriendsList>();

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel_FriendsList>();
        }
    }
}