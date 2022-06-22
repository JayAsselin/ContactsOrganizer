using ContactsOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ContactsOrganizer.Data
{
    internal class ContactDBcontext
    {
        private static List<Contact> ContactList = new List<Contact>()
        {
            new Contact
            {
                Id = 1,
                Lname = "Asselin",
                Fname = "Jerome",
                Initals = "JA",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone = "(819) 328-8630",
                PrivatePhone = "(819) 328-8860",
                WorkEmail = "jayWork@gmail.com",
                PrivateEmail = "jay@gmail.com"
            },
            new Contact
            {
                Id = 2,
                Lname = "Brisson",
                Fname = "Lisa",
                Initals = "LB",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(819) 918-9825",
                PrivatePhone="(819) 918-9345",
                WorkEmail="lisaCouture@hotmail.com",
                PrivateEmail="lisa@hotmail.com"
            },
            new Contact
            {
                Id = 3,
                Lname = "Courcy",
                Fname = "Dominic",
                Initals = "DC",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(514) 123-9885",
                PrivatePhone="(514) 123-9485",
                WorkEmail="doCo@gmail.com",
                PrivateEmail="do@gmail.com"
            },
            new Contact
            {   
                Id = 4,
                Lname = "Lesage",
                Fname = "JR",
                Initals = "JL",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(206) 830-1027",
                PrivatePhone="(819) 918-9230",
                WorkEmail="jrl@hotmail.com",
                PrivateEmail="jrl@hotmail.com"
            },
            new Contact
            {   
                Id = 5,
                Lname = "Duquette",
                Fname = "Yves",
                Initals = "YD",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(506) 932-9334",
                PrivatePhone="(819) 345-0293",
                WorkEmail="duke@hotmail.com",
                PrivateEmail="duke@hotmail.com"
            },
            new Contact
            {   
                Id = 6,
                Lname = "Reidy",
                Fname = "Aylwin",
                Initals = "AR",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(608) 381-3725",
                PrivatePhone="(660) 973-9511",
                WorkEmail="torblais@diaperstack.com",
                PrivateEmail="keefe-deemer@acusage.net"
            },
            new Contact
            {
                Id = 7,
                Lname = "LeGrand",
                Fname = "Matz",
                Initals = "ML",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(414) 407-8791",
                PrivatePhone="(819) 823-5678",
                WorkEmail="matzLG@hotmail.com",
                PrivateEmail="matz@hotmail.com"
            },
            new Contact
            {
                Id = 8,
                Lname = "Dukes",
                Fname = "Geary",
                Initals = "GD",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(902) 450-8178",
                PrivatePhone="(867) 319-2682",
                WorkEmail="fi.abdall@consolidated-farm-research.net",
                PrivateEmail="pet_mcg@diaperstack.com"
            },
            new Contact
            {
                Id = 9,
                Lname = "Lan",
                Fname = "Michel",
                Initals = "ML",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(307) 382-3450",
                PrivatePhone="(248) 222-9228",
                WorkEmail="olwen.tho@egl-inc.info",
                PrivateEmail="eu.bl@diaperstack.com"
            },
            new Contact
            {
                Id = 10,
                Lname = "Yocum",
                Fname = "Levin",
                Initals = "LY",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(605) 756-7014",
                PrivatePhone="(226) 223-0208",
                WorkEmail="mitc-linder@consolidated-farm-research.net",
                PrivateEmail="ke-baca@egl-inc.info"
            },
            new Contact
            {
                Id = 11,
                Lname = "Bohannon",
                Fname = "Levin",
                Initals = "LB",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(416) 684-3961",
                PrivatePhone="(701) 378-8463",
                WorkEmail="endoci_lovat@arketmay.com",
                PrivateEmail="stan-cri@autozone-inc.info"
            },
            new Contact
            {
                Id = 12,
                Lname = "Yocum",
                Fname = "Noam",
                Initals = "NY",
                Photo = "https://st3.depositphotos.com/9998432/13335/v/600/depositphotos_133351986-stock-illustration-default-placeholder-man-and-woman.jpg",
                WorkPhone="(248) 810-0262",
                PrivatePhone="(506) 366-6210",
                WorkEmail="lynnet.bre@consolidated-farm-research.net",
                PrivateEmail="jeann.heu@careful-organics.org"
            },
            new Contact
            {
                Id = 13,
                Lname = "Whitworth",
                Fname = "Radhika",
                Initals = "RW",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(902) 493-7006",
                PrivatePhone="(906) 442-9816",
                WorkEmail="kenn-br@diaperstack.com",
                PrivateEmail="mi_blais@diaperstack.com"
            },
            new Contact
            {
                Id = 14,
                Lname = "Neel",
                Fname = "Fabiana",
                Initals = "FN",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(580) 633-1267",
                PrivatePhone="(947) 503-4145",
                WorkEmail="siby.atherto@arvinmeritor.info",
                PrivateEmail="re.suar@arvinmeritor.info"
            },
            new Contact
            {
                Id = 15,
                Lname = "Whitworth",
                Fname = "Ysolde",
                Initals = "YW",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(302) 224-2098",
                PrivatePhone="(709) 815-0629",
                WorkEmail="narciss_basquez@autozone-inc.info",
                PrivateEmail="gail-wy@progressenergyinc.info"
            },
            new Contact
            {
                Id = 16,
                Lname = "Borst",
                Fname = "Fabiana",
                Initals = "FB",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(615) 684-6143",
                PrivatePhone="(810) 783-7697",
                WorkEmail="ma.hendri@arvinmeritor.info",
                PrivateEmail="ewar.am@diaperstack.com"
            },
            new Contact
            {
                Id = 17,
                Lname = "Soza",
                Fname = "Woorin",
                Initals = "WS",
                Photo = "https://st2.depositphotos.com/9998432/48435/v/450/depositphotos_484354132-stock-illustration-default-avatar-photo-placeholder-grey.jpg?forcejpeg=true",
                WorkPhone="(306) 633-0426",
                PrivatePhone="(843) 809-7709",
                WorkEmail="belitsuare@diaperstack.com",
                PrivateEmail="tadi.hendri@arvinmeritor.info"
            }
        };

        public static List<Contact> GetAll()
        {
            return ContactDBcontext.ContactList;
        }
        public static void Add(Contact contact)
        {
            ContactDBcontext.ContactList.Add(contact);
        }
        public static void Delete(Contact contact)
        {
            ContactDBcontext.ContactList.Remove(ContactDBcontext.ContactList.First(element => element.Id == contact.Id));
        }
        public static int GetMaxId()
        {
            int maxId = ContactDBcontext.ContactList.Max(c => Convert.ToInt32(c.Id));
            return maxId;
        }
    }
}
