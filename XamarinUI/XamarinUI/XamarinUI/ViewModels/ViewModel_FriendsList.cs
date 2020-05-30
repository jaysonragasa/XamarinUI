using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamarinUI.Models;

namespace XamarinUI.ViewModels
{
    public class ViewModel_FriendsList
    {
        #region events

        #endregion

        #region vars
        Random _r = new Random(DateTime.Now.Millisecond);
        #endregion

        #region properties
        public ObservableCollection<Model_UserDetail> FriendsLists { get; set; } = new ObservableCollection<Model_UserDetail>();
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_FriendsList()
        {
            InitCommands();

            /*
			// used only in UWP & WPF
			// or anything that supports design time updates
			if(base.IsInDesignMode)
			{
				DesignData();
			}
			else
			{
				RuntimeData();
			}
			*/
        }
        #endregion

        #region command methods

        #endregion

        #region methods
        void InitCommands()
        {

        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public async Task RefreshData()
        {
            string[] nicknames = "Lil Girl|Lulu|Amor|Dum Dum|Stitch|First Mate|Tomcat|Butterfinger|Joker|Sunny|Elf|Mistress|Tiny|Master|Pintsize|Tank|Bean|Cloud|Pixie|Chicken Legs|Music Man|Doc|Little Bear|Einstein|Rainbow|Punk|Diesel|Lil Mama|Betty Boop|Buckeye".Split('|');
            string[] moods = "Energetic|Stupid|Silly|Sad|Overwhelmed|Determined|Envious|Lost|Content|Depressed|Proud|Motivated|Amazed|conscious|Annoyed|Suspicious|Tense|Irritated|Excited|Disdain|Angry|Trapped|Bored|Anxious|Relieved|Worried|Frustrated|Nervous|Insecure|Eager|Terrified|Happy|Inadequate|Jealous|Foolish|Ashamed|Satisfied|Self|Scared|Uncomfortable|Hurt|Joy|Comfortable|Grieving|Embarrassed|Disgusted|Loving|Lonely|Bitter".Split('|');

            this.FriendsLists.Clear();
            for (int i = 0; i < nicknames.Length; i++)
            {
                this.FriendsLists.Add(new Model_UserDetail()
                {
                    ProfilePicture = $"https://randomuser.me/api/portraits/{(_r.Next(0, 50) > 25 ? "men" : "women")}/{_r.Next(1, 8)}.jpg",
                    Nickname = nicknames[i],
                    IsOnline = _r.Next(0, 50) > 25 ? true : false,
                    Mood = moods[_r.Next(1, 50)]
                });
            }
        }
        #endregion
    }
}