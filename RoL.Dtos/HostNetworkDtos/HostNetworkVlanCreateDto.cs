namespace RoL.Dtos.HostNetworkDtos;

public class HostNetworkVlanCreateDto
{
    /// <summary>
    /// Addresses list
    /// </summary>
    public List<string> Addresses { get; set; }
    /// <summary>
    /// Parent interface name
    /// </summary>
    public string Parent { get; set; }
    /// <summary>
    /// Vlan id
    /// </summary>
    public int VlanId { get; set; }
}