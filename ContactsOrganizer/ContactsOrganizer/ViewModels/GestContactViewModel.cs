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
        void OnPropertyChanged([CallerMemberName] string propertyChanged = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }
        string id;
        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            id = HttpUtility.UrlDecode(query["Id"]);
            ShowInfo(id);
        }
        private Contact contact;
        private int getId;
        private string getNom;
        private string getPrenom;
        private string getInit;
        private string getPhoto;
        private string getTelWork;
        private string getTelPerso;
        private string getCourrielWork;
        private string getCourrielPerso;
        public Contact Contact { get { return contact; } set { contact = value; OnPropertyChanged(); } }
        public ICommand CmdModify { get;private set; }
        public ICommand CmdDelete { get;private set; }
        public int GetId { get => getId; set { getId = value; OnPropertyChanged(); } }
        public string GetNom { get => getNom; set { getNom = value; OnPropertyChanged(); } }
        public string GetPrenom { get => getPrenom; set { getPrenom = value; OnPropertyChanged(); } }
        public string GetInit { get => getInit; set { getInit = value; OnPropertyChanged(); } }
        public string GetPhoto { get => getPhoto; set{ getPhoto = value; OnPropertyChanged();} }
        public string GetTelWork { get => getTelWork; set { getTelWork = value; OnPropertyChanged();} }
        public string GetTelPerso { get => getTelPerso; set { getTelPerso = value; OnPropertyChanged(); } }
        public string GetCourrielWork { get => getCourrielWork; set { getCourrielWork = value; OnPropertyChanged();} }
        public string GetCourrielPerso { get => getCourrielPerso; set { getCourrielPerso = value; OnPropertyChanged();} }

        public GestContactViewModel()
        {
            this.CmdDelete = new Command(DeleteContact);
            this.CmdModify = new Command(ModifyContact);
        }

        private Contact ShowInfo(string id)
        {
            Contact current = ContactDBcontext.GetAll().Find(c => c.Id == int.Parse(id));
            GetNom = current.Lname;
            GetPrenom = current.Fname;
            GetInit = current.Initials;
            GetPhoto = current.Photo;
            GetTelWork = current.WorkPhone;
            GetTelPerso = current.PrivatePhone;
            GetCourrielWork = current.WorkEmail;
            GetCourrielPerso = current.PrivateEmail;
            return current;
        }

        private async void DeleteContact()
        {
            Contact=ShowInfo(id);
            var alert = await App.Current.MainPage.DisplayAlert("Confirmation", $"Voulez-vous vraiment supprimer {GetPrenom} {GetNom}?", "Oui", "Non");
            if (alert)
            {
                ContactDBcontext.Delete(Contact);
                App.Current.MainPage = new AppShell();
            }
        }

        // Methode fonctionne pas tout a faite comme il faudrait..
        private async void ModifyContact()
        {
            var update = ContactDBcontext.GetAll().Find(c => c.Id == int.Parse(id));
            var alert = await App.Current.MainPage.DisplayAlert("Confirmation", $"Voulez-vous vraiment modifier l'information de {GetPrenom} {GetNom}?", "Oui", "Non");
            if (alert)
            {
                update.Id = GetId;
                update.Lname = GetNom;
                update.Fname = GetPrenom;
                update.Initials = GetInit;
                update.Photo = GetPhoto;
                update.WorkPhone = GetTelWork;
                update.PrivatePhone = GetTelPerso;
                update.WorkEmail = GetCourrielWork;
                update.PrivateEmail = GetCourrielPerso;

                App.Current.MainPage = new AppShell();
            }
        }
    }
}
