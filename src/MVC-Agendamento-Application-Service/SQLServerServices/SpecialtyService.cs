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
	public class SpecialtyService : ISpecialtyService
	{

		private readonly ISpecialtyRepository _repository;
		public SpecialtyService(ISpecialtyRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<SpecialtyDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new SpecialtyDTO()
							  {
								  id = c.Id,
								  name = c.Name,
							  }).ToList();
		}

		public async Task<SpecialtyDTO> FindById(int id)
		{
			var dto = new SpecialtyDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<SpecialtyDTO> GetAll()
		{
			throw new NotImplementedException(); 
		}

		public Task<SpecialtyDTO> GetById(int id)
		{
			throw new NotImplementedException(); 
		}

		public Task<int> Save(SpecialtyDTO dto)
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
	}
}
