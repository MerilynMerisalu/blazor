using ContactBookClient.Entities;
using System.Net.Http.Json;

namespace ContactBookClient.Services
{
    public interface IPerson
    {
        Task<IEnumerable<Person?>>? GetPeopleAsync();
        Task<Person?> GetPersonByIdAsync(Guid PersonId);
    }
    public class PersonService : IPerson
    {
        private HttpClient _client;
        private string _address => _client.BaseAddress.ToString() + "people/";
        public PersonService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Person?>>? GetPeopleAsync()
        {
            return await _client.GetFromJsonAsync<IEnumerable<Person?>>(_address);
        }

        public async Task<Person?> GetPersonByIdAsync(Guid personId)
        {
            
            return await _client.GetFromJsonAsync<Person?>($"{_address}{personId}");
        }
    }
}
