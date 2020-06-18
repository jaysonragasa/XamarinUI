using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Pages.Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestListView : ContentPage
    {
        public TestListView()
        {
            InitializeComponent();
        }
    }

    public class ViewModel_Test : INotifyPropertyChanged
    {
        Random _r = new Random(DateTime.Now.Millisecond);

        public ObservableCollection<Model_Person> PersonCollection { get; set; } = new ObservableCollection<Model_Person>();

        public bool _hideListView = false;
        public bool HideListView
        {
            get => _hideListView;
            set
            {
                _hideListView = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand Command_PopulateListview { get; private set; }
        public ICommand Command_ClearListView { get; private set; }

        public ViewModel_Test()
        {
            this.Command_PopulateListview = new Command(PopulateListView);
            this.Command_ClearListView = new Command(ClearListView);
        }

        void PopulateListView()
        {
            string[] nicknames = "Lil Girl|Lulu|Amor|Dum Dum|Stitch|First Mate|Tomcat|Butterfinger|Joker|Sunny|Elf|Mistress|Tiny|Master|Pintsize|Tank|Bean|Cloud|Pixie|Chicken Legs|Music Man|Doc|Little Bear|Einstein|Rainbow|Punk|Diesel|Lil Mama|Betty Boop|Buckeye".Split('|');

            this.PersonCollection.Clear();

            for (int i = 0; i < 20; i++)
            {
                this.PersonCollection.Add(new Model_Person()
                {
                    Fullname = nicknames[this._r.Next(0, nicknames.Length - 1)]
                });
            }

            this.HideListView = false;
        }

        void ClearListView()
        {
            this.PersonCollection.Clear();
            this.HideListView = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Model_Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
    }
}