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
    public partial class ziele : ContentPage
    {
        public ziele()
        {
            InitializeComponent();
            var MinutenList = new List<string>();
            MinutenList.Add("1");
            MinutenList.Add("2");
            MinutenList.Add("3");
            MinutenList.Add("4");
            MinutenList.Add("5");
            MinutenList.Add("6");
            
            test.ItemsSource = MinutenList;
            
        }
    }
}