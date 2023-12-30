using MagazineAPI.Application.Interfaces;
using MagazineAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace MagazineAPI.Persistence.Repositories
{
    public class MagazineRepository : IMagazineRepository
    {
        private readonly MagazineDbContext _magazineDbContext;

        public MagazineRepository(MagazineDbContext magazineDbContext )
        {
            _magazineDbContext = magazineDbContext;
        }
        public async Task<Magazine> AddMagazineAsync(Magazine magazine)
        {
            await _magazineDbContext.Magazines.AddAsync(magazine);
            await _magazineDbContext.SaveChangesAsync();
            return magazine;
            
        }
        public async Task<Magazine> GetMagazineById(string id)
        {
           return await _magazineDbContext.Magazines.FindAsync(id);
        }

        public async Task<bool> DeleteMagazine(Magazine magazine)
        {
            _magazineDbContext.Magazines.Remove(magazine);
            await _magazineDbContext.SaveChangesAsync();
            return true;
        } 
        public async Task<List<Magazine>> GetAllMagazines()
        {
            return await _magazineDbContext.Magazines.ToListAsync(); 
        }
       
        public async Task<Magazine> UpdateMagazine(Magazine magazine)
        {
            _magazineDbContext.Magazines.Update(magazine);
            await _magazineDbContext.SaveChangesAsync();
            return magazine;
        }

       

    }
}
