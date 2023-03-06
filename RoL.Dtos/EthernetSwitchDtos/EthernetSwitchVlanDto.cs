namespace RoL.Dtos.EthernetSwitchDtos;

public class EthernetSwitchVlanDto
{
    public DateTime CreatedAt { get; set; } = new();
    public string EthernetSwitchId { get; set; } = "";
    public string Id { get; set; } = "";
    public List<string> TaggedPorts { get; set; } = new();
    public List<string> UntaggedPorts { get; set; } = new();
    public DateTime UpdatedAt { get; set; } = new();
    public int VlanId { get; set; } = 0;
}