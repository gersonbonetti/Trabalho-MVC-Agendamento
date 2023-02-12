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
	public class PersonService : IPersonService
	{

		private readonly IPersonRepository _repository;
		public PersonService(IPersonRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<PersonDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new PersonDTO()
							  {
								  id = c.Id,
								  name = c.Name,
								  age = c.Age,
								  cpf = c.CPF
							  }).ToList();
		}

		public async Task<PersonDTO> FindById(int id)
		{
			var dto = new PersonDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public List<PersonDTO> GetAll()
		{
			throw new NotImplementedException(); 
		}

		public Task<PersonDTO> GetById(int id)
		{
			throw new NotImplementedException(); 
		}

		public Task<int> Save(PersonDTO dto)
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
