namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchPortDto
{
    public DateTime CreatedAt { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public bool PoeEnabled { get; set; }
    public string PoeType { get; set; }
    public int PvId { get; set; }
    public DateTime UpdatedAt { get; set; }
    
}