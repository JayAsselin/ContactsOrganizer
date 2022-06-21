using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using ContactsOrganizer.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsOrganizer.ViewModels
{
    internal class AddContactViewModel
    {
        public string AddNom { get; set; }
        public string AddPrenom { get; set; }
        public string AddInit { get; set; }
        public string AddTelWork { get; set; }
        public string AddTelPerso { get; set; }
        public string AddCourrielWork { get; set; }
        public string AddCourrielPerso { get; set; }
        public ICommand CmdAdd { get; private set; }

        public AddContactViewModel()
        {
            this.CmdAdd = new Command(AddContact);
        }

        public async void AddContact()
        {
            string photo = "https://www.plasticoncomposites.com/img/team-placeholder.png";
            Contact newContact = new Contact()
            {
                Lname = this.AddNom,
                Fname = this.AddPrenom,
                Initals = this.AddInit,
                Photo = photo,
                WorkEmail = this.AddCourrielWork,
                PrivateEmail = this.AddCourrielPerso,
                WorkPhone = this.AddTelWork,
                PrivatePhone = this.AddTelPerso
            };
            ContactDBcontext.Add(newContact);
            await Application.Current.MainPage.DisplayAlert("Info", $"Le contact {this.AddPrenom} {this.AddNom} a ete ajouter avec succes!", "Ok");
            App.Current.MainPage = new AppShell();
        }
    }
}
