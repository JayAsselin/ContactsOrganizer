using ContactsOrganizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsOrganizer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjouterContactPage : ContentPage
    {
        private AddContactViewModel addContactViewModel;
        public AjouterContactPage()
        {
            InitializeComponent();
            this.addContactViewModel = new AddContactViewModel();
            this.BindingContext = addContactViewModel;
        }

    }
}