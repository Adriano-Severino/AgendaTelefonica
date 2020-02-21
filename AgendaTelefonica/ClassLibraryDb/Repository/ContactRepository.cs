using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaTelefonica.IRepository;
using AgendaTelefonica.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryDb.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ContactRepository(string dbPath)
        {
            _databaseContext = new DatabaseContext(dbPath);
        }
        public async Task<bool> AddContactAsync(Contact contact)
        {
            try
            {
                var listening = await _databaseContext.Contact.AddAsync(contact);
                await _databaseContext.SaveChangesAsync();

                //if added successfully return true
                var add = listening.State == EntityState.Added;
                return add;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Contact>> GetContactAsync()
        {
            try
            {
                var contact = await _databaseContext.Contact.ToListAsync();
                return contact;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Contact> GetContactIdAsync(int id)
        {
            try
            {
                var contact = await _databaseContext.Contact.FindAsync(id);
                return contact;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Contact>> QueryContactAsync(Func<Contact, bool> attribute)
        {
            try
            {
                var contact = _databaseContext.Contact.Where(attribute);
                return contact.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> RemoveContactAsync(int id)
        {
            try
            {
                var contact = await _databaseContext.Contact.FindAsync(id);
                var listening = _databaseContext.Remove(contact);

                await _databaseContext.SaveChangesAsync();

                //if deleted successfully return true
                var isDeleted = listening.State == EntityState.Deleted;
                return isDeleted;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> UpdateContacAsync(Contact contact)
        {
            try
            {
                var listening = _databaseContext.Update(contact);
                await _databaseContext.SaveChangesAsync();

                //if update successfully return true
                var isModifield = listening.State == EntityState.Modified;

                return isModifield;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
