using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Contracts.Repositories;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Application_Service.SQLServerServices
{
	public class AddressService : IAddressService
	{

		private readonly IAddressRepository _repository;
		public AddressService(IAddressRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<AddressDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new AddressDTO()
							  {
								  id = c.Id,
								  city = c.City,
								  postalCode = c.PostalCode,
								  district = c.District,
								  street = c.Street,
								  number = c.Number
							  }).ToList();
		}

		public async Task<AddressDTO> FindById(int id)
		{
			var dto = new AddressDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<AddressDTO> GetAll()
		{
			throw new NotImplementedException(); 
		}

		public Task<AddressDTO> GetById(int id)
		{
			throw new NotImplementedException(); 
		}

        public Task<AddressDTO> GetById(int? id) {
            throw new NotImplementedException();
        }

        public Task<int> Save(AddressDTO dto)
		{
			if (dto.id > 0)
			{
				return _repository.Update(dto.mapToEntity());
			}
			else
			{
				return _repository.Save(dto.mapToEntity());
			}
		}

        Task<List<AddressDTO>> IBaseService<AddressDTO>.GetAll() {
            throw new NotImplementedException();
        }
    }
}
