using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace AgendaTelefonica.ViewModels
{
    public class PrismMasterDetailPageViewModel : BindableBase
    {
        private INavigationService _navigationService;
        public DelegateCommand btnAbout { get; set; }
        public PrismMasterDetailPageViewModel(INavigationService navigationService)
           
        {
            _navigationService = navigationService;
          
            btnAbout = new DelegateCommand(NavigateCommandAbout);
        }

        private void NavigateCommandAbout()
        {
            //TODO: navigate for views AddContact
            _navigationService.NavigateAsync("NavigationPage/About");
        }

    }
}
