using MVC_Agendamento_Domain.Contracts.Repository;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Application_Service.SQLServerServices
{
	public class StatusService : IStatusService
	{
		private readonly IStatusRepository _repository;
		public StatusService(IStatusRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<StatusDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new StatusDTO()
							  {
								  id = c.Id,
								  name = c.Name,
							  }).ToList();
		}

		public async Task<StatusDTO> FindById(int id)
		{
			var dto = new StatusDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<StatusDTO> GetAll()
		{
			throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
		}

		public Task<StatusDTO> GetById(int id)
		{
			throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
		}

		public Task<int> Save(StatusDTO dto)
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
