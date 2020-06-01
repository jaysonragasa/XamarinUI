using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUI.Models;

namespace XamarinUI.ViewModels
{
    public class ViewModel_BasicMVVM : INotifyPropertyChanged
    {
        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region vars
        Model_Person _person = new Model_Person();
        #endregion

        #region properties
        public ObservableCollection<Model_Person> PersonCollection { get; set; } = new ObservableCollection<Model_Person>();
        
        public Model_Person PersonDetails
        {
            get => _person;
            set
            {
                _person = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region commands
        public ICommand Command_Save { get; private set; }
        public ICommand Command_Clear { get; private set; }
        #endregion

        #region ctors
        public ViewModel_BasicMVVM()
        {
            InitCommands();
        }
        #endregion

        #region command methods
        void Save()
        {
            //PersonCollection.Add(this.PersonDetails);

            PersonCollection.Add(new Model_Person()
            {
                FirstName = this.PersonDetails.FirstName,
                LastName = this.PersonDetails.LastName
            });

            this.PersonDetails = new Model_Person();
        }

        void Clear()
        {
            this.PersonCollection.Clear();
        }
        #endregion

        #region methods
        void InitCommands()
        {
            if (Command_Save == null) this.Command_Save = new Command(Save);
            if (Command_Clear == null) this.Command_Clear = new Command(Clear);
        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public async Task RefreshData()
        {

        }

        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}