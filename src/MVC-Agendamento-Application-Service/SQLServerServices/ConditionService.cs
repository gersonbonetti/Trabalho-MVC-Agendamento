using Register.Domain.Contracts.Repositories;
using Register.Domain.Contracts.Services;
using Register.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Application_Service.Services
{
    public class ConditionService : IConditionService
    {
        private readonly IConditionRepository _repository;
        public ConditionService(IConditionRepository repository) 
        {
            this._repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var condition = await _repository.GetById(id);
            return await _repository.Delete(condition);
        }

        public List<ConditionDTO> FindAll() {
            throw new NotImplementedException();
        }

        public Task<ConditionDTO> FindById(int id) {
            throw new NotImplementedException();
        }

        public async Task<List<ConditionDTO>> GetAll()
        {
            return _repository.GetAll().Select(c => new ConditionDTO()
            {
                id = c.Id,
                name = c.Name,
            }).ToList();
        }

        public async Task<ConditionDTO> GetById(int? id)
        {
            var cond = new ConditionDTO();
            return cond.maptoDTO(await _repository.GetById(id));
        }

        public async Task<int> Save(ConditionDTO entity)
        {
            if(entity.id > 0)
            {
                return await _repository.Update(entity.mapToEntity());
            }
            else
            {
                return await _repository.Save(entity.mapToEntity());
            }
            
        }
    }
}
