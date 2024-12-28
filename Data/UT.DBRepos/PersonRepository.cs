using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.AppConfig;
using UT.Domain.Models;

namespace UT.Repos;

public class PersonRepository : IPersonRepository
{
    private readonly AdventureWorks2022Context _adventureWorks2022Context;

    public PersonRepository(AdventureWorks2022Context adventureWorks2022Context)
    {
        _adventureWorks2022Context = adventureWorks2022Context;
    }
    public async Task<List<Person>> GetPeople()
    {
        var people = await Task.Run(() =>_adventureWorks2022Context
                                            .People
                                                .Include(p => p.Password)
                                            .Take(10));
        return [.. people];
    }
}