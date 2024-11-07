// Views/MainPage.xaml.cs
using CounterApp.ViewModels;

namespace CounterApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
