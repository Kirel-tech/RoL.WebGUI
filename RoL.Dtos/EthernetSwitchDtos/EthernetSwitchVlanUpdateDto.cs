namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchVlanUpdateDto
{
    public List<string> TaggedPorts { get; set; }
    public List<string> UntaggedPorts { get; set; }
}