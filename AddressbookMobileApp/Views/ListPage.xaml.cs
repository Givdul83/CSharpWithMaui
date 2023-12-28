using AddressbookMobileApp.ViewModels;
using Microsoft.Maui.Controls;
using AppLibrary.Services;
using System.Collections.ObjectModel;
using AppLibrary.Interfaces;
using AppLibrary.Models;
using System.Diagnostics;

namespace AddressbookMobileApp.Views;



public partial class ListPage : ContentPage

{
    private ViewListModel _viewModel;
	

	public ListPage(ViewListModel viewModel, IContactService contactService)
	{
        InitializeComponent();
        _viewModel= viewModel;
		_viewModel.Contacts= new ObservableCollection<IContact>(contactService.GetContactsFromList());

        foreach (var contact in _viewModel.Contacts)
        {
            var nameLabel = new Label
            {
                Text =$"{contact.FirstName} {contact.LastName}",
                FontSize= 20,
                Margin = 20,
               
                FontAttributes = FontAttributes.Bold
                
               
            };

            var emailLabel= new Label
            { 
                Text = $"Email:{contact.Email}",
                Margin = 10,
                FontSize=15,
                FontAttributes= FontAttributes.Italic
            };

            StackLayout_ContactsList.Children.Add(nameLabel);
            StackLayout_ContactsList.Children.Add(emailLabel);

        }




        BindingContext = _viewModel;
	}

    
    

    
}