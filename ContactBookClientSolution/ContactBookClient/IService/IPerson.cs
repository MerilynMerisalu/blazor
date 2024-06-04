using ContactBookClient.DTO;

namespace ContactBookClient.IService
{
    public interface IPerson
    {
       Task<IEnumerable<Person?>> GetPeople();
       Task<Person?> GetPersonById(int id);
    }
}
