namespace probne2.DTO;

public class ActionDTO
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool NeedSpecialEquipment { get; set; }
    public ICollection<FireTruckDTO> FireTrucks { get; set; }
}