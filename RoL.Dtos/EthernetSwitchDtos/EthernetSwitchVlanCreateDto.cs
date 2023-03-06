namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchVlanCreateDto
{
    public List<string> TaggedPorts { get; set; } = new();
    public List<string> UntaggedPorts { get; set; } = new();
    public int VlanId { get; set; }

}