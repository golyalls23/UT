using UT.API.Models;
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
    public async Task<List<PersonDTO>> GetPeople()
    {
        var people = await _personRepository.GetPeople();
        var peopleDtos = new List<PersonDTO>();
        foreach (var person in people)
        {
            peopleDtos.Add(new PersonDTO() { 
                RowGuid = person.Rowguid,
                FirstName = person.FirstName, 
                LastName = person.LastName, 
                MiddleName = person.MiddleName ?? string.Empty, 
                Title = person.Title ?? string.Empty
            });
        }
        return peopleDtos;

    }
}