using AddressBookAPI.DTOs;
using AddressBookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookAPI.Services
{
    public class ContactService : IContactService
    {
        private static List<Contact> contacts = new List<Contact>()
        {
                new Contact() { Id = 1, FirstName = "Jack", LastName = "Jackson", PhoneNumber = "111-111-1111", Address = "111 Main Street, Minneapolis, MN 55001", CreditCardNumber = "123456789"},
                new Contact() { Id = 2, FirstName = "John", LastName = "Johnson", PhoneNumber = "222-222-2222", Address = "222 Main Street, Minneapolis, MN 55001", CreditCardNumber = "123451234"},
                new Contact() { Id = 3, FirstName = "Mary", LastName = "Erickson", PhoneNumber = "333-333-3333", Address = "333 Main Street, Minneapolis, MN 55001", CreditCardNumber = "123456547"}
        };

        public List<ContactDTO> GetAllContacts()
        {
            List<ContactDTO> contactsDTO = new List<ContactDTO>();

            contacts.ForEach(contact =>
            {
                var contactDTO = new ContactDTO();
                contactDTO.Id = contact.Id;
                contactDTO.FirstName = contact.FirstName;
                contactDTO.LastName = contact.LastName;
                contactDTO.PhoneNumber = contact.PhoneNumber;
                contactDTO.Address = contact.Address;

                contactsDTO.Add(contactDTO);
            });
            return contactsDTO;
        }

        public ContactDTO GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(contact => contact.Id == id);

            if (contact != null)
            {
                var contactDTO = new ContactDTO();
                contactDTO.Id = contact.Id;
                contactDTO.FirstName = contact.FirstName;
                contactDTO.LastName = contact.LastName;
                contactDTO.PhoneNumber = contact.PhoneNumber;
                contactDTO.Address = contact.Address;

                return contactDTO;
            }

            return null;
        }

        public ContactDTO CreateContact(ContactDTO newContact)
        {
            var contact = new Contact();
            contact.Id = newContact.Id;
            contact.FirstName = newContact.FirstName;
            contact.LastName = newContact.LastName;
            contact.PhoneNumber = newContact.PhoneNumber;
            contact.Address = newContact.Address;
            contacts.Add(contact);

            var contactDTO = new ContactDTO();
            contactDTO.Id = contact.Id;
            contactDTO.FirstName = contact.FirstName;
            contactDTO.LastName = contact.LastName;
            contactDTO.PhoneNumber = contact.PhoneNumber;
            contactDTO.Address = contact.Address;

            return contactDTO;
        }

        public ContactDTO UpdateContact(ContactDTO updateContact)
        {
            var contact = contacts.FirstOrDefault(contact => contact.Id == updateContact.Id);
            if (contact != null)
            {
                contact.FirstName = updateContact.FirstName;
                contact.LastName = updateContact.LastName;
                contact.PhoneNumber = updateContact.PhoneNumber;
                contact.Address = updateContact.Address;

                var contactDTO = new ContactDTO();
                contactDTO.Id = contact.Id;
                contactDTO.FirstName = contact.FirstName;
                contactDTO.LastName = contact.LastName;
                contactDTO.PhoneNumber = contact.PhoneNumber;
                contactDTO.Address = contact.Address;

                return contactDTO;
            }

            return null;
        }

        public bool DeleteContact(int id)
        {
            var contact = contacts.FirstOrDefault(contact => contact.Id == id);
            if (contact == null)
            {
                return false;
            }

            contacts.Remove(contact);
            return true;
        }

    }
}
