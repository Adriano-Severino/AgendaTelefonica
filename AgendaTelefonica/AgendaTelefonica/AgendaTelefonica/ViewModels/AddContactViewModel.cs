using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaTelefonica.ViewModels
{
    public class AddContactViewModel : BindableBase
    {

        private string _textToSay = "Add Contact";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; set; }

        public AddContactViewModel()
        {
            SpeakCommand = new DelegateCommand(Speak);
        }

        private void Speak()
        {
            //TODO: call service
        }
    }
}
