using ContactBookClient.Entities;
using System.Net.Http.Json;

namespace ContactBookClient.Services
{
    public interface IPerson
    {
        Task<IEnumerable<Person?>>? GetPeopleAsync();
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
            Console.WriteLine(_address);
            return await _client.GetFromJsonAsync<IEnumerable<Person?>>(_address);
        }
    }
}
