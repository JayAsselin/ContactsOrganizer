using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using ContactsOrganizer.Data;
using ContactsOrganizer.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ContactsOrganizer.ViewModels
{
    [QueryProperty(nameof(JsonInfo), "contact")]
    internal class GestContactViewModel:INotifyPropertyChanged
    {
        private string jsonInfo;

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(name)));
        }

        public string JsonInfo
        {
            get { return jsonInfo; }
            set
            {
                jsonInfo = HttpUtility.UrlDecode(value);
                var current = JsonConvert.DeserializeObject<Contact>(jsonInfo);
                OnPropertyChanged();
                //ShowJson(jsonInfo);
            }
        }
        public string GetNom { get; set; }
        public string GetPrenom { get; set; }
        public string GetInit { get; set; }
        public string GetPhoto { get; set; }
        public string GetTelWork { get; set; }
        public string GetTelPerso { get; set; }
        public string GetCourrielWork { get; set; }
        public string GetCourrielPerso { get; set; }

        public GestContactViewModel()
        {
            
        }

        //public void ShowJson(string getJson)
        //{
        //    var current = JsonConvert.DeserializeObject<Contact>(getJson);
        //    GetNom = current.Lname;
        //    GetPrenom = current.Fname;
        //    GetInit = current.Initals;
        //    GetTelWork = current.WorkPhone;
        //    GetTelPerso = current.PrivatePhone;
        //    GetCourrielWork = current.WorkEmail;
        //    GetCourrielPerso = current.PrivateEmail;
        //}
    }
}
