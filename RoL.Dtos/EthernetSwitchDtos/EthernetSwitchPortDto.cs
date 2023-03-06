namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchPortDto
{
    public DateTime CreatedAt { get; set; } = new();
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public bool PoeEnabled { get; set; } = false;
    public string PoeType { get; set; } = "";
    public int PvId { get; set; } = 0;
    public DateTime UpdatedAt { get; set; } = new();

}