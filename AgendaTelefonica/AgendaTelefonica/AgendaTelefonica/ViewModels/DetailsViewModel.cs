
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AgendaTelefonica.Models;
using AgendaTelefonica.IRepository;
using Xamarin.Forms;

namespace AgendaTelefonica.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {

        private readonly IContactRepository _contactRepository;
        private IEnumerable<Contact> _contacts;



        public string ContactTelephone { get; set; }

        public string ContactName { get; set; }





        public IEnumerable<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    Contacts = await _contactRepository.GetContactAsync();

                });
            }
        }
        public DetailsViewModel(IContactRepository contactRepository)

        {
            _contactRepository = contactRepository;


        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var contact = new Contact
                    {
                        Name = ContactName,
                        Tel = ContactTelephone,
                    };
                    await _contactRepository.AddContactAsync(contact);
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
