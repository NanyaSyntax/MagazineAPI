using MagazineAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAPI.Application.Interfaces
{
    public interface IMagazineRepository
    {
        Task<Magazine> AddMagazineAsync(Magazine magazine);
        Task<Magazine> UpdateMagazine(Magazine magazine);
        Task<bool> DeleteMagazine(Magazine magazine);
        Task<List<Magazine>> GetAllMagazines();
        Task<Magazine> GetMagazineById(string id);
        


    }
}
