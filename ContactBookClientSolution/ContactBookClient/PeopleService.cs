using ContactBookClient.DTO;
using ContactBookClient.IService;
using System.Net.Http.Json;

namespace ContactBookClient
{
    public class PersonService : IPerson
    {
        private HttpClient _client;

        public PersonService(HttpClient client)
        {
            _client = client;
        }

        
        public async Task<IEnumerable<Person?>> GetPeople()
        {
            return await _client.GetFromJsonAsync<IEnumerable<Person?>>(_client.BaseAddress + "people") ;
        }
    }
}
