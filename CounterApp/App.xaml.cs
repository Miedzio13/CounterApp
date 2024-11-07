// App.xaml.cs
using CounterApp.Views;

namespace CounterApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }
}
