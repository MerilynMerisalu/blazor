

using Application.Domain.EF;
using Base.Service;
using System.Net.Sockets;

namespace Application.Service
{
    
    public interface IPersonService
    {
        Task<IEnumerable<Person?>?>GetPeopleAsync();
    }


    public class PersonService : BaseService<Person, Guid>, IPersonService
    {
        public PersonService(HttpClient client) : base(client)
        {
        }

        protected override string EndpointUri => "api/people/";

        public async Task<IEnumerable<Person?>?> GetPeopleAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
