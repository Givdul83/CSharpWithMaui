using AddressbookMobileApp.Views;
using Microsoft.Maui.Controls;

namespace AddressbookMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ListPage), typeof(ListPage));
            Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
            Routing.RegisterRoute(nameof(RemovePage), typeof(RemovePage));
            Routing.RegisterRoute(nameof(UpdatePage), typeof(UpdatePage));
            Routing.RegisterRoute(nameof(ExitPage), typeof(ExitPage));
        }
    }
}
