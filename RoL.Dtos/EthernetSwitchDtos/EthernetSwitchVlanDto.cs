namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchVlanDto
{
    public DateTime CreatedAt { get; set; }
    public string EthernetSwitchID { get; set; }
    public string Id { get; set; }
    public List<string> TaggedPorts { get; set; }
    public List<string> UntaggedPorts { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int VlanId { get; set; }
}