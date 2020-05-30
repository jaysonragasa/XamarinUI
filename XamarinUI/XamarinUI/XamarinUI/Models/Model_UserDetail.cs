using GalaSoft.MvvmLight;

namespace XamarinUI.Models
{
    public class Model_UserDetail : ViewModelBase
    {
        private string _ProfilePicture = string.Empty;
        public string ProfilePicture
        {
            get { return _ProfilePicture; }
            set { Set(nameof(ProfilePicture), ref _ProfilePicture, value); }
        }

        private string _Nickname = string.Empty;
        public string Nickname
        {
            get { return _Nickname; }
            set { Set(nameof(Nickname), ref _Nickname, value); }
        }

        private string _Mood = string.Empty;
        public string Mood
        {
            get { return _Mood; }
            set { Set(nameof(Mood), ref _Mood, value); }
        }

        private bool _IsOnline = false;
        public bool IsOnline
        {
            get { return _IsOnline; }
            set { Set(nameof(IsOnline), ref _IsOnline, value); }
        }
    }
}