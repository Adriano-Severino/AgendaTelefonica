using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaTelefonica.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    { 
        private INavigationService _navigationService;
        public DelegateCommand btn_AddContact { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Telephone book";
            btn_AddContact = new DelegateCommand(AddContactViews);
        }

         private void AddContactViews()
        {
            //TODO: navigate for views AddContact
             _navigationService.NavigateAsync("AddContact");
        }
    }
}
