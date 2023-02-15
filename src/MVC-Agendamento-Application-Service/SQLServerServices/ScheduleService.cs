using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Application_Service.SQLServerServices
{
	public class ScheduleService : IScheduleService {
		private readonly IScheduleRepository _repository;

		public ScheduleService(IScheduleRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			var entity = await _repository.FindById(id);
			return await _repository.Delete(entity);
		}

		public List<ScheduleDTO> FindAll()
		{
			return _repository.FindAll()
							  .Select(c => new ScheduleDTO()
							  {
								  id = c.Id,
								  patientId = c.PatientId,
								  doctorId = c.DoctorId,
								  date = c.Date,
								  confirmedQuery = c.ConfirmedQuery,
								  statusId = c.StatusId,
							  }).ToList();
		}

		public async Task<ScheduleDTO> FindById(int id)
		{
			var dto = new ScheduleDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

        public List<ScheduleDTO> GetAll() {
            throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
        }

        public Task<ScheduleDTO> GetById(int id) {
            throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
        }

        public Task<int> Save(ScheduleDTO dto)
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
