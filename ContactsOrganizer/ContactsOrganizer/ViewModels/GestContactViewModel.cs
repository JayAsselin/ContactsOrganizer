using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Input;
using System.Xml.Linq;
using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ContactsOrganizer.ViewModels
{
    internal class GestContactViewModel:IQueryAttributable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(name)));
        //}

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            string id = HttpUtility.UrlDecode(query["Id"]);
            ShowInfo(id);
        }
        public int GetId { get; set; }
        public string GetNom { get; set; }
        public string GetPrenom { get; set; }
        public string GetInit { get; set; }
        public string GetPhoto { get; set; }
        public string GetTelWork { get; set; }
        public string GetTelPerso { get; set; }
        public string GetCourrielWork { get; set; }
        public string GetCourrielPerso { get; set; }
        public ICommand CmdModify { get;private set; }
        public ICommand CmdDelete { get;private set; }

        public GestContactViewModel()
        {
            this.CmdDelete = new Command<Contact>(DeleteContact);
        }

        public void ShowInfo(string id)
        {
            Contact current = ContactDBcontext.GetAll().Find(c => c.Id == int.Parse(id));
            GetNom = current.Lname;
            GetPrenom = current.Fname;
            GetInit = current.Initals;
            GetPhoto = current.Photo;
            GetTelWork = current.WorkPhone;
            GetTelPerso = current.PrivatePhone;
            GetCourrielWork = current.WorkEmail;
            GetCourrielPerso = current.PrivateEmail;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetNom)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetPrenom)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetInit)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetPhoto)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetTelWork)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetTelPerso)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetCourrielWork))); 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GetCourrielPerso)));
        }

        public async void DeleteContact(Contact contact)
        {
            var alert = await App.Current.MainPage.DisplayAlert("Confirmation", $"Voulez-vous vraiment supprimer {contact.Fname} {contact.Lname}?", "Oui", "Non");
            if (alert)
            {
                ContactDBcontext.Delete(contact);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Contact)));
            }
        }
    }
}
