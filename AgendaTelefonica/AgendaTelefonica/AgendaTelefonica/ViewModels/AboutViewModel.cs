using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace AgendaTelefonica.ViewModels
{
    public class AboutViewModel :  ViewModelBase
    {
       
        private INavigationService _navigationService;
        public DelegateCommand btnBack { get; set; }
     
        public AboutViewModel(INavigationService navigationService)
             : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "About telephone book";
            btnBack = new DelegateCommand(Back);
        }

        private void Back()
        {
            //TODO: navigate for views PrismMasterDetailPage
            _navigationService.NavigateAsync("/NavigationPage/PrismMasterDetailPage");
        }
    }
}
