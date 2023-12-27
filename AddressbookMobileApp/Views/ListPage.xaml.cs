using AddressbookMobileApp.ViewModels;
using Microsoft.Maui.Controls;
using AppLibrary.Services;
namespace AddressbookMobileApp.Views;



public partial class ListPage : ContentPage
{
	
	public ListPage(ViewListModel viewModel)
	{
		InitializeComponent();
		
		BindingContext= viewModel;
	}


}