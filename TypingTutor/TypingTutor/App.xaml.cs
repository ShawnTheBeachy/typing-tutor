using System.Threading.Tasks;
using Template10.Common;
using TypingTutor.Views;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace TypingTutor
{
    [Bindable]
    sealed partial class App : BootStrapper
    {
        // "A beginning is the time for taking the most delicate care that the balances are correct." -Frank Herbert, Dune

        public App()
        {
            InitializeComponent();
        }
        
        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            await NavigationService.NavigateAsync(typeof(MainPage));
        }
    }
}
