namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchPortCreateDto
{
    public string Name { get; set; }
    public bool PoeEnabled { get; set; }
    public string PoeType { get; set; }
    public int PvId { get; set; }
}

