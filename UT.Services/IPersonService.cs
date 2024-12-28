using UT.API.Models;
using UT.Domain.Models;

namespace UT.API.Services;

public interface IPersonService
{
    Task<List<PersonDTO>> GetPeople();
}
