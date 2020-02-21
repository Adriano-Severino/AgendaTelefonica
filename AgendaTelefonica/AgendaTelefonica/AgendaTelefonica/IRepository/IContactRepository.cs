using AgendaTelefonica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica.IRepository
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetContactAsync();

        Task<Contact> GetContactIdAsync(int id);
        Task<bool> AddContactAsync(Contact contact);
        Task<bool> UpdateContacAsync(Contact contact);
        Task<bool> RemoveContactAsync(int id);

        Task<IEnumerable<Contact>> QueryContactAsync(Func<Contact, bool> attribute);
    }
}
