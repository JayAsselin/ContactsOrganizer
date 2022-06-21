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
    public partial class ListContactsPage : ContentPage
    {
        public ContactListViewModel contactListViewModel;
        public ListContactsPage()
        {
            InitializeComponent();
            this.contactListViewModel = new ContactListViewModel();
            this.BindingContext = contactListViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = null;
            this.BindingContext = this.contactListViewModel;
        }
    }
}