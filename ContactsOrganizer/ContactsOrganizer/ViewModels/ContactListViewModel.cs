using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ContactsOrganizer.ViewModels
{
    public class ContactListViewModel
    {
        public ObservableCollection<Contact> ContactList => new ObservableCollection<Contact>(ContactDBcontext.GetAll().OrderBy(n => n.Fname));
    }
}
