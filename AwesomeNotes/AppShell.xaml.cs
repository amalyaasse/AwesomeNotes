
using AwesomeNotes.Views;
using Xamarin.Forms;

namespace AwesomeNotes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
        }
    }
}
