using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier
{
    public interface IContactService
    {
        void AddContact(string name, string email);
        List<Contact> GetAllContacts();
    }

    internal class ContactService : IContactService
    {
        private readonly IContactRepository repository;

        public ContactService(IContactRepository repository)
        {
            this.repository = repository;
        }

        public void AddContact(string name, string email)
        {
            var contact = new Contact { Name = name, Email = email };
            repository.AddContact(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return repository.GetAllContacts();
        }
    }
}
