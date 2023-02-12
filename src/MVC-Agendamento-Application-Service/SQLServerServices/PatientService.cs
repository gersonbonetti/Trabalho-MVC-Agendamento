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
	public class PatientService : IPatientService
	{

		private readonly IPatientRepository _repository;
		public PatientService(IPatientRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<PatientDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new PatientDTO()
							  {
								  id = c.Id,
								  personId = c.PersonId

							  }).ToList();
		}

		public async Task<PatientDTO> FindById(int id)
		{
			var dto = new PatientDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<PatientDTO> GetAll()
		{
			throw new NotImplementedException(); 
		}

		public Task<PatientDTO> GetById(int id)
		{
			throw new NotImplementedException(); 
		}

		public Task<int> Save(PatientDTO dto)
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
