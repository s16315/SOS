using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SOS.Infrastructure.Context;
using SOS.Infrastructure.Model;

namespace SOS.Infrastructure.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        private readonly SOSContext _sosContext;

        public RolesRepository(SOSContext sosContext)
        {
            _sosContext = sosContext;
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return await _sosContext.Role.ToListAsync();
        }


        public async Task<Role> GetById(long id)
        {
            return await _sosContext.Role.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public Task TrueDelete(Role entity)
        {
            throw new NotImplementedException();
        }

        public async Task Add(Role role)
        {
            role.DateOfCreation = DateTime.Now;
            await _sosContext.Role.FirstAsync();
            await _sosContext.Role.AddAsync(role);
            await _sosContext.SaveChangesAsync();
        }

        public async Task Update(Role role)
        {
            var roleToUpdate = await _sosContext.Role.SingleOrDefaultAsync(x => x.Id == role.Id);
            if (roleToUpdate != null)
            {
                roleToUpdate.Name = role.Name;
                roleToUpdate.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }
        }

        public async Task Delete(long id)
        {
            var roleToDelete = await _sosContext.Role.SingleOrDefaultAsync(x => x.Id == id);
            if (roleToDelete != null)
            {
                roleToDelete.Available = false;
                roleToDelete.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }
        }
    }
}