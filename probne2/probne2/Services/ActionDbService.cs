using Microsoft.EntityFrameworkCore;
using probne2.DTO;
using probne2.Entities;

namespace probne2.Services;

public class ActionDbService : IActionDbService
{
    private readonly FirewatchContext _context;

    public ActionDbService(FirewatchContext context)
    {
        _context = context;
    }
    
    public async Task<ActionDTO> GetAction(int idAction)
    {
        return await _context.Actions.Include(e => e.FireTruckActions)
            .Where(e => e.IdAction == idAction)
            .Select(e => new ActionDTO
            {
                StartTime = e.StartTime,
                EndTime = e.EndTime,
                NeedSpecialEquipment = e.NeedSpecialEquipment,
                FireTrucks = e.FireTruckActions.Where(x => x.IdAction == idAction)
                    .Select(x => new FireTruckDTO
                    {
                        OperationNumber = x.FireTruck.OperationNumber,
                        SpecialEquipment = x.FireTruck.SpecialEquipment,
                        AssignmentDate = x.AssignmentDate
                    }).OrderByDescending(x => x.AssignmentDate)
                    .ToList()
            }).SingleOrDefaultAsync();
    }
}