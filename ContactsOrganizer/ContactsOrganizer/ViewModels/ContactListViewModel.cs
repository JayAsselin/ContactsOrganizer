using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using ContactsOrganizer.Views;
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
        public ObservableCollection<Contact> ContactList => new ObservableCollection<Contact>(ContactDBcontext.GetAll().OrderBy(n => n.Fname));

        public ICommand CmdNav { get;private set; }
        // Have to figure out how to send the selection to another page..
        

        public ContactListViewModel()
        {
        this.CmdNav = new Command(() =>
        {
            var selectedItem = CollectionView.SelectedItemProperty;
            if (selectedItem != null)
            {
                App.Current.MainPage.Navigation.PushAsync(new GestContactPage());
                selectedItem = null;
            }
        });
        }

    }
}
