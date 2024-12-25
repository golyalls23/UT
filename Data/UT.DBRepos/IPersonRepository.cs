using Microsoft.EntityFrameworkCore;
using UT.Domain.Models;

namespace UT.Repos;

public interface IPersonRepository
{
    Task<List<Person>> GetPeople();
}
