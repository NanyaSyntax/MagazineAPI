using MagazineAPI.Application.Dto;
using MagazineAPI.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAPI.Application.Interfaces
{
    public interface IMagazineService
    {
        Task<MagazineRequestDto> AddMagazine(MagazineRequestDto magazine);
        //Task<bool> DeleteMagazineByIdAsync(MagazineRequestDto magazine);
        //Task<MagazineRequestDto> UpdateMagazineAsync(MagazineRequestDto magazine);
        //Task<Magazine> GetMagazineByIdAsync(String id);
        //Task<List<Magazine>> GetAllMagazinesAsync();
    }
}
