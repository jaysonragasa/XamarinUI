using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Breadcrumbs : ContentPage
    {
        public Breadcrumbs()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            
        }

        protected override void OnAppearing()
        {
            string[] name = { "Breakfast", "Lunch", "Dinner" };
            string[] styl = { "111", "111", "111" };
            int maxcol = (name.Length * 2) - 1;
            int sel = 1;

            string indicators = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                indicators += i <= sel ? styl[i] : "000";
            }

            Grid g = new Grid();
            for (int i = 0; i < maxcol; i++)
            {
                g.ColumnDefinitions.Add(new ColumnDefinition() { Width = i % 2 == 0 ? GridLength.Auto : GridLength.Star }); 
            }
        }
    }
}