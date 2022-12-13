namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchVlanCreateDto
{
    public List<string> TaggedPorts { get; set; }
    public List<string> UntaggedPorts { get; set; }
    public int VlanId { get; set; }
    
}