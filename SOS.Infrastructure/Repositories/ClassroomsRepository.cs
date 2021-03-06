using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SOS.Infrastructure.Context;
using SOS.Infrastructure.Model;

namespace SOS.Infrastructure.Repositories
{
    public class ClassroomsRepository : IClassroomsRepository
    {
        private readonly SOSContext _sosContext;

        public ClassroomsRepository(SOSContext sosContext)
        {
            _sosContext = sosContext;
        }

        public async Task TrueDelete(Classroom classroom)
        {
            var classroomToDelete = await _sosContext.Classroom.SingleOrDefaultAsync(x => x.Id == classroom.Id);
            if (classroomToDelete != null)
                // Sprawdzić czy sala nie jest używana przez lekcje!!!
            {
                _sosContext.Classroom.Remove(classroomToDelete);
                await _sosContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Classroom>> GetAll()
        {
            return await _sosContext.Classroom.ToListAsync();
        }

        public async Task<Classroom> GetById(long id)
        {
            return await _sosContext.Classroom.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task Add(Classroom classroom)
        {
            classroom.DateOfCreation = DateTime.Now;
            await _sosContext.Classroom.FirstAsync();
            await _sosContext.Classroom.AddAsync(classroom);
            await _sosContext.SaveChangesAsync();
        }

        public async Task Update(Classroom classroom)
        {
            var classroomToUpdate = await _sosContext.Classroom.SingleOrDefaultAsync(x => x.Id == classroom.Id);
            if (classroomToUpdate != null)
            {
                classroomToUpdate.Name = classroom.Name;
                classroomToUpdate.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }
        }

        public async Task Delete(long id)
        {
            var classroomToDelete = await _sosContext.Classroom.SingleOrDefaultAsync(x => x.Id == id);
            if (classroomToDelete != null)
            {
                classroomToDelete.Available = false;
                classroomToDelete.DateOfUpdate = DateTime.Now;
                await _sosContext.SaveChangesAsync();
            }
        }
    }
}