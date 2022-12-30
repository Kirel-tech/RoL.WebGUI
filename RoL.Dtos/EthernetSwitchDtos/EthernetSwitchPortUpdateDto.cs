namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchPortUpdateDto
{
    public string Name { get; set; }
    public bool PoeEnabled { get; set; }
    public string PoeType { get; set; }
    public int PvId { get; set; }
}