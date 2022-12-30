namespace RoL.Dtos.HostNetworkDtos;

public class HostNetworkVlanDto
{
    /// <summary>
    /// Addresses list
    /// </summary>
    public List<string> Addresses { get; set; }
    /// <summary>
    /// Name interface full nam
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Parent interface name
    /// </summary>
    public string Parent { get; set; }
    /// <summary>
    /// Id of the vlan
    /// </summary>
    public int VlanId { get; set; }
}