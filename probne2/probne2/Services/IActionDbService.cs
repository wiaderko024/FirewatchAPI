using probne2.DTO;

namespace probne2.Services;

public interface IActionDbService
{
    Task<ActionDTO> GetAction(int idAction);
}