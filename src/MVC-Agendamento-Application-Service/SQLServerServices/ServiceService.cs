using MVC_Agendamento_Domain.DTO;
using MVC_Agendamento_Domain.IRepositories;
using MVC_Agendamento_Domain.IServices;
using MVC_Agendamento_Infra_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVC_Agendamento_Application_Service.SQLServerServices.ServiceService;

namespace MVC_Agendamento_Application_Service.SQLServerServices {
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
                                  
                              }).ToList();
        }
        public async Task<ServiceDTO> FindById(int id) {
            var dto = new ServiceDTO();
            return dto.mapToDTO(await _repository.FindById(id));
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
