using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeNotes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Locked : ContentPage
    {
        public Locked()
        {
            InitializeComponent();
        }

         void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me Again";
        }
    }
}