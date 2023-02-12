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
	public class DoctorService : IDoctorService
	{
		private readonly IDoctorRepository _repository;
		public DoctorService(IDoctorRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<DoctorDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new DoctorDTO()
							  {
								  id = c.Id,
								  specialtyId = c.SpecialtyId,
								  cnpj = c.CNPJ,
								  crm = c.CRM,
								  personId = c.PersonId
							  }).ToList();
		}

		public async Task<DoctorDTO> FindById(int id)
		{
			var dto = new DoctorDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<DoctorDTO> GetAll()
		{
			throw new NotImplementedException(); 
		}

		public Task<DoctorDTO> GetById(int id)
		{
			throw new NotImplementedException(); 
		}

		public Task<int> Save(DoctorDTO dto)
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
