using probne2.DTO;

namespace probne2.Services;

public interface IFireTruckDbService
{
    Task AddFireTruckToActionAsync(int idFireTruck, AddFireTruckToActionDTO dto);
}