using Microsoft.EntityFrameworkCore;
using probne2.DTO;
using probne2.Entities;

namespace probne2.Services;

public class FireTruckDbService : IFireTruckDbService
{
    private readonly FirewatchContext _context;

    public FireTruckDbService(FirewatchContext context)
    {
        _context = context;
    }
    
    public async Task AddFireTruckToActionAsync(int idFireTruck, AddFireTruckToActionDTO dto)
    {
        if (_context.FireTruckActions.Count(e => e.IdAction == dto.IdAction) >= 3)
        {
            throw new Exception("Do akcji mogą być przypisane maksymalnie 3 wozy strazackie");
        }

        var fireTruck = await _context.FireTrucks.SingleOrDefaultAsync(e => e.IdFiretruck == idFireTruck);
        var action = await _context.Actions.SingleOrDefaultAsync(e => e.IdAction == dto.IdAction);

        if (action.NeedSpecialEquipment && !fireTruck.SpecialEquipment)
        {
            throw new Exception(
                "Ta akcja wymaga specjalnego wyposazenia a ten woz go nie ma. Nie mozna dodac wozu do akcji");
        }

        if (DateTime.Now > action.EndTime)
        {
            throw new Exception("Ta akcja się ju skończyła");
        }

        await _context.FireTruckActions.AddAsync(new FireTruckAction
        {
            IdFiretruck = idFireTruck,
            IdAction = dto.IdAction,
            AssignmentDate = DateTime.Now
        });

        await _context.SaveChangesAsync();
    }
}