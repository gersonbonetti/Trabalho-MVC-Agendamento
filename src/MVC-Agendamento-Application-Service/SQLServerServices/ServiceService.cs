using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Application_Service.SQLServerServices
{
    public class ServiceService : IServiceService {

        private readonly IServiceRepository _repository;

        public ServiceService(IServiceRepository repository) {
            _repository = repository;
        }

        public async Task<int> Delete(int id) {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<ServiceDTO> FindAll() {
            return _repository.FindAll()
                              .Select(c => new ServiceDTO() {
                                  id = c.Id,
                                  scheduleId = c.ScheduleId,
                                  patientId = c.PatientId,
                                  doctorId = c.DoctorId,
                                  patient = new Patient()
                                  {
                                      Id = c.Patient.Id,
                                      Person = new Person()
                                      {
                                          Id = c.Patient.Person.Id,
                                          Name = c.Patient.Person.Name
                                      }
                                  },
                                  doctor = new Doctor()
                                  {
                                      Id = c.Doctor.Id,
                                      Person = new Person()
                                      {
                                          Id = c.Doctor.Person.Id,
                                          Name = c.Doctor.Person.Name
                                      }
                                  },
                                  serviceNumber = c.ServiceNumber,
                                  status = new Status()
                                  {
                                      Id = c.Status.Id,
                                      Name = c.Status.Name
                                  },
                                  evaluation = c.Evaluation,
                                  medicalRecord = c.MedicalRecord,
                                  date = c.Date
                              }).ToList();
        }

        public async Task<ServiceDTO> FindById(int id) {
            var dto = new ServiceDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public List<ServiceDTO> GetAll() {
            throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
        }

        public Task<ServiceDTO> GetById(int id) {
            throw new NotImplementedException(); //To pensando em criar um novo  IBaseService
        }

        public Task<int> Save(ServiceDTO dto) {
            if (dto.id > 0) {
                return _repository.Update(dto.mapToEntity());
            }
            else {
                return _repository.Save(dto.mapToEntity());
            }
        }
    }
}
