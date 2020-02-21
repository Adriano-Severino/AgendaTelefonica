using AgendaTelefonica.IRepository;
using AgendaTelefonica.ViewModels;
using AgendaTelefonica.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaTelefonica
{
    public partial class App : Application
    {
        public App(IContactRepository ContactRepository)
        {
            InitializeComponent();

            MainPage = new Details()
            {
                BindingContext = new DetailsViewModel(ContactRepository)
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
