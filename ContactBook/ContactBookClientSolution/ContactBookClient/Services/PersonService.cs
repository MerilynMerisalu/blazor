using ContactBookClient.Entities;
using System.Net.Http.Json;

namespace ContactBookClient.Services
{
    public interface IPerson
    {
        Task DeletePersonByIdAsync(Guid personId);
        Task<IEnumerable<Person?>>? GetPeopleAsync();
        Task<Person?> GetPersonByIdAsync(Guid personId);
    }
    public class PersonService(HttpClient client) : IPerson
    {
        private string _address => client.BaseAddress + "people/";

        public async Task DeletePersonByIdAsync(Guid personId)
        {
            await client.DeleteFromJsonAsync<Person?>($"{_address}{personId}");
        }

        public async Task<IEnumerable<Person?>>? GetPeopleAsync()
        {
            return await client.GetFromJsonAsync<IEnumerable<Person?>>(_address);
        }

        public async Task<Person?> GetPersonByIdAsync(Guid personId)
        {
            
            return await client.GetFromJsonAsync<Person?>($"{_address}{personId}");
        }
    }
}
