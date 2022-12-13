namespace RoL.Dtos.HostNetworkDtos;

public class HostNetworkBridgeUpdateDto
{
    /// <summary>
    /// Addresses list
    /// </summary>
    public List<string> Addresses { get; set; } =new();
    /// <summary>
    /// Slaves slice of slaves interfaces names
    /// </summary>
    public List<string> Slaves { get; set; } = new();

}