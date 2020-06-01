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
    public partial class BasicMVVM : ContentPage
    {
        public BasicMVVM()
        {
            InitializeComponent();
        }
    }
}