using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SOS.Infrastructure.Context;
using SOS.Infrastructure.Model;


namespace SOS.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly SOSContext _sosContext;

        public UsersRepository(SOSContext sosContext)
        {
            _sosContext = sosContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await _sosContext.User.ToListAsync();
            users.ForEach(x => { _sosContext.Entry(x).Reference(y => y.Role).LoadAsync();});
            return users;
        }

        public async Task<User> GetById(long id)
        {
            var user = await _sosContext.User.Where(x => x.Id == id).SingleOrDefaultAsync();
            await _sosContext.Entry(user).Reference(x => x.Role).LoadAsync();
            return user;
        }

        public async Task Add(User user)
        {
            user.DateOfCreation = DateTime.Now;
            await _sosContext.User.FirstAsync();
            await _sosContext.User.AddAsync(user);
            await _sosContext.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            var userToUpdate = await _sosContext.User.SingleOrDefaultAsync(x => x.Id == id);
            if (userToUpdate != null)
            {
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }

        }

        public Task TrueDelete(User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(long id)
        {
            var userToDelete = await _sosContext.User.SingleOrDefaultAsync(x => x.Id == id);
            if (userToDelete != null)
            {
                userToDelete.Available = false;
                userToDelete.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }
        }
    }
}