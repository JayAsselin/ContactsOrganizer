using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using ContactsOrganizer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsOrganizer.ViewModels
{
    internal class AddContactViewModel:INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string AddNom { get; set; }
        public string AddPrenom { get; set; }
        public string AddInit { get; set; }
        public string AddTelWork { get; set; }
        public string AddTelPerso { get; set; }
        public string AddCourrielWork { get; set; }
        public string AddCourrielPerso { get; set; }
        public int NewId { get; set; }
        public ICommand CmdAdd { get; private set; }

        public AddContactViewModel()
        {
            this.CmdAdd = new Command(AddContact);
            this.NewId = ContactDBcontext.GetMaxId() + 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void AddContact()
        {
            Contact newContact = new Contact()
            {
                Id = this.Id,
                Lname = this.AddNom,
                Fname = this.AddPrenom,
                Initals = this.AddInit,
                Photo = "https://upload.wikimedia.org/wikipedia/commons/8/89/Portrait_Placeholder.png",
                WorkEmail = this.AddCourrielWork,
                PrivateEmail = this.AddCourrielPerso,
                WorkPhone = this.AddTelWork,
                PrivatePhone = this.AddTelPerso
            };
            ContactDBcontext.Add(newContact);
            this.NewId = ContactDBcontext.GetMaxId() + 1;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewId)));
            await Application.Current.MainPage.DisplayAlert("Info", $"Le contact {this.AddPrenom} {this.AddNom} a ete ajouter avec succes!", "Ok");
            App.Current.MainPage = new AppShell();
        }
    }
}
