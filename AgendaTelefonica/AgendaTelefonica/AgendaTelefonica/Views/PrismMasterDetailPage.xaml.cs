using System.Reflection;
using Xamarin.Forms;

namespace AgendaTelefonica.Views
{
    public partial class PrismMasterDetailPage : MasterDetailPage
    {
        public PrismMasterDetailPage()
        {
            InitializeComponent();
           
            //start MainPage
            this.Detail = new NavigationPage(new MainPage());
        }
    }
}