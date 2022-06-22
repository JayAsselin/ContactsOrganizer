using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using ContactsOrganizer.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsOrganizer.ViewModels
{
    public class ContactListViewModel
    {
        public ObservableCollection<Contact> Contacts => new ObservableCollection<Contact>(ContactDBcontext.GetAll().OrderBy(n => n.Fname));

        public ICommand CmdNav { get;private set; }
        // Have to figure out how to send the selection to another page..
        

        public ContactListViewModel()
        {
            this.CmdNav = new Command<Contact>(Tapped);
        }

        public async void Tapped(Contact selectedContact)
        {
            //string json = JsonConvert.SerializeObject(selectedContact);
            Routing.RegisterRoute(nameof(GestContactPage), typeof(GestContactPage));
            await Shell.Current.GoToAsync($"{nameof(GestContactPage)}?Id={selectedContact.Id}");
        }

    }
}
