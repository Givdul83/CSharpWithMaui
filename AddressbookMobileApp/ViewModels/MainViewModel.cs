using AppLibrary.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AddressbookMobileApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IContactService _contactService;

    public MainViewModel(IContactService contactService)
    {
        _contactService = contactService;
    }

}
