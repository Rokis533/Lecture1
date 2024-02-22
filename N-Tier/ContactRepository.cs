using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        List<Contact> GetAllContacts();
    }

    public class ContactRepository : IContactRepository
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
    }
}
