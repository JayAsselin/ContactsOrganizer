using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsOrganizer.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Initals { get; set; }
        public string Photo { get; set; }
        public string WorkEmail { get; set; }
        public string PrivateEmail { get; set; }
        public string WorkPhone { get; set; }
        public string PrivatePhone { get; set; }
    }
}
