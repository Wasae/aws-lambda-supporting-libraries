using apollo_Auto_Mappers;
using apollo_Business_Entities.Models;
using apollo_DTO.Request;
using apollo_DTO.Response;
using apollo_Repositories.Repositories;
using apollo_Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Mediator
{
    public class UserMediator
    {
        //private dynamic _mediator = typeof(IUserRepository);
        private IUserRepository _mediator = new UserService();

        public async Task Delete(int id)
        {
            await _mediator.Delete(id);
        }
        public async Task<IEnumerable<UserResponseDTO>> GetAll(int pageindex, int recordcount)
        {
            return Mappers.mapper.Map<IEnumerable<UserResponseDTO>> (GetAll(pageindex, recordcount));
        }
        public async Task<UserResponseDTO> GetById(int id)
        {
            var d = await _mediator.GetById(id);
            return Mappers.mapper.Map<UserResponseDTO>(d);
        }
        public async Task Save(UserRequestDTO o)
        {
            await _mediator.Save(Mappers.mapper.Map<mst_user>(o));
        }
        public async Task Sometask()
        {
            throw new NotImplementedException();
        }
        public async Task Update(UserRequestDTO o)
        {
            await _mediator.Update(Mappers.mapper.Map<mst_user>(o));
        }
    }
}
