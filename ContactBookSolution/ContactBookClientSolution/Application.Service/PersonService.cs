

using Application.Domain.EF;
using Base.Service;

namespace Application.Service
{
    public interface IPersonService
    {

    }

    public class PersonService : BaseService<Person>, IPersonService
    {
        public PersonService(Person entity, HttpClient client) : base(entity, client)
        {
        }
    }
}
