using MagazineAPI.Application.Dto;
using MagazineAPI.Application.Interfaces;
using MagazineAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MagazineAPI.Application.Service
{
    public class MagazineService : IMagazineService
    {
        private readonly IMagazineRepository _repository;

        public MagazineService(IMagazineRepository repository)
        {
            _repository = repository;
        }
        public async Task<MagazineRequestDto> AddMagazine(MagazineRequestDto magazine)
        {
            try
            {
                var newMag = new Magazine()
                {
                    Name = magazine.Name,
                    Title = magazine.Title,
                    Description = magazine.Description,
                };

                await _repository.AddMagazineAsync(newMag);
                //await _repository.SaveChangesAsync();

                var addedMag = new MagazineRequestDto()
                {
                    Name = magazine.Name,
                    Title = magazine.Title,
                    Description = magazine.Description,
                };

                return addedMag;
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException(ex.Message);
            }
        }

        public Task<bool> DeleteMagazineByIdAsync(MagazineRequestDto magazine)
        {
            throw new NotImplementedException();
        }

        //public Task<bool> DeleteMagazineByIdAsync(MagazineRequestDto magazine)
        //{

        //}

        public Task<List<Magazine>> GetAllMagazinesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Magazine> GetMagazineByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<MagazineRequestDto> UpdateMagazineAsync(MagazineRequestDto magazine)
        {
            throw new NotImplementedException();
        }
    }
}
