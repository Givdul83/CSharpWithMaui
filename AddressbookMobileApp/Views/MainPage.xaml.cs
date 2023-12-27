using AddressbookMobileApp.ViewModels;
using AddressbookMobileApp.Views;
using Microsoft.Maui.Controls;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AddressbookMobileApp
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            BindingContext = _viewModel;
        
        
            
        }

        private async void Btn_ShowList_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ListPage");
        }

        private async void Btn_Search_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SearchPage");
        }

        private async void Btn_Add_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AddPage");
        }

        private async void Btn_Remove_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("RemovePage");
        }

        private async void Btn_Update_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("UpdatePage");
        }

        private async void Btn_Quit_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ExitPage");
        }
    }

}
