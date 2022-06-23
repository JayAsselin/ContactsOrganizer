using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ContactsOrganizer.Models
{
    public class Contact
    {
        private string _lname;
        private string _fname;
        private string _initials;
        private string _workEmail;
        private string _privateEmail;
        private string _workPhone;
        private string _privatePhone;

        private Regex regNom = new Regex(@"^[A-Z][A-Za-z]{1,15}$");
        private Regex regInit = new Regex(@"^[A-Z]{2}");
        private Regex regTelephone = new Regex(@"^\(\d{3}\)\s\d{3}\-\d{4}$");
        private Regex regCourriel = new Regex(@"^([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22))*\x40([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d))*$");

        public int Id { get; set; }
        public string Lname { get => _lname; 
            set 
            { 
                if(regNom.IsMatch(value))
                    _lname = value;
                else
                    App.Current.MainPage.DisplayAlert("Attention","Le nom doit commencer par une majuscules suivies de 2 à 15 minuscules","Ok");
            } }
        public string Fname { get => _fname; 
            set 
            { 
                if(regNom.IsMatch(value))
                    _fname = value;
                else
                    App.Current.MainPage.DisplayAlert("Attention", "Le prenom doit commencer par une majuscules suivies de 2 à 15 minuscules", "Ok");
            } }
        public string Initials { get => _initials; 
            set 
            { 
                if(regInit.IsMatch(value))
                    _initials = value; 
                else
                    App.Current.MainPage.DisplayAlert("Attention", "Les initials doivent etre 2 lettres majuscules", "Ok");
            } }
        public string Photo { get; set; }
        public string WorkEmail { get => _workEmail; 
            set 
            { 
                if(regCourriel.IsMatch(value))
                    _workEmail = value;
                else
                    App.Current.MainPage.DisplayAlert("Attention", "Le courriel doit être sous un format valide ex: nomcourriel@fournisseur.com", "Ok");
            } }
        public string PrivateEmail { get => _privateEmail; 
            set 
            { 
                if(regCourriel.IsMatch(value))
                    _privateEmail = value;
                else
                    App.Current.MainPage.DisplayAlert("Attention", "Le courriel doit être sous un format valide ex: nomcourriel@fournisseur.com ou ca", "Ok");
            } }
        public string WorkPhone { get => _workPhone; 
            set 
            { 
                if(regTelephone.IsMatch(value))
                    _workPhone = value;  
                else
                    App.Current.MainPage.DisplayAlert("Attention","Le numéro de téléphone doit être sous ce format ex: (555) 555-5555","Ok");
            } }
        public string PrivatePhone { get => _privatePhone; 
            set 
            { 
                if(regTelephone.IsMatch(value))
                    _privatePhone = value; 
                else
                    App.Current.MainPage.DisplayAlert("Attentio","Le numéro de téléphone doit être sous ce format ex: (555) 555-5555","Ok");
            } }
    }
}
