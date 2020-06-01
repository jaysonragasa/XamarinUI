using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinUI.Models
{
    public class Model_Person : INotifyPropertyChanged
    {
        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region vars
        string _lastName = string.Empty;
        string _firstName = string.Empty;
        #endregion

        #region properties
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region INotifyPropertyChanged implementation
        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}