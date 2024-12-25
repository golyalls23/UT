using UT.Domain.Models;
using UT.Repos;

namespace UT.API.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<List<Person>> GetPeople()
    {
        return await _personRepository.GetPeople();
    }
}