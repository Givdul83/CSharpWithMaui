using AddressbookMobileApp.ViewModels;
using AppLibrary.Interfaces;
using System.Collections.ObjectModel;
using AppLibrary.Services;

namespace AddressbookMobileApp.Views;

public partial class SearchPage : ContentPage
{
    private SearchViewModel _viewModel; 
	public SearchPage(SearchViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
	}

    private void Button_Search_Clicked(object sender, EventArgs e)
    {
        var emailEntry = this.FindByName<Entry>("Entry_Email");
        _viewModel.SearchContacts(emailEntry.Text);

        var foundContactLabel = this.FindByName<Label>("Found_Contact");

        if(_viewModel.Contacts.Any())
        {
            var contact= _viewModel.Contacts.FirstOrDefault();
            var contactInfo = $"Found Contact: \n" +
                             $"Name: {contact.FirstName} {contact.LastName}\n" +
                             $"Email: {contact.Email}\n" +
                             $"Phone: {contact.PhoneNumber}\n" +
                             $"Address: {contact.StreetAddress}\n"+
                             $"Postal code:{contact.PostalCode}  {contact.City}";


            foundContactLabel.Text = contactInfo;
        }
        else
        {
            _viewModel.Contacts.Clear();
            var contactNotFound = "Contact not Found";
            foundContactLabel.Text= contactNotFound; 
        }
    }
}