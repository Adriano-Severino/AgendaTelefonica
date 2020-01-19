using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace AgendaTelefonica.ViewModels
{
    public class AddContactViewModel : ViewModelBase
    {

        private string _addName = "Contact name";
        private string _addTelephone = "Enter telephone";
        public string addName
        {
            get { return _addName; }
             
            set { SetProperty(ref _addName, value); }
        }

        public string addTelephone
        {
            get { return _addTelephone; }

            set { SetProperty(ref _addTelephone, value); }
        }

        public DelegateCommand AddContactCommand { get; set; }

        public AddContactViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            AddContactCommand = new DelegateCommand(AddContact);
            Title = "Telephone book contact";
        }

        private void AddContact()
        {
            //TODO: call service
        }
    }
}
