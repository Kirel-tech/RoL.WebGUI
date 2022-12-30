namespace RoL.Dtos.HostNetworkDtos;

public class HostNetworkBridgeCreateDto
{
    /// <summary>
    /// Addresses list
    /// </summary>
    public List<string> Addresses { get; set; } = new();
    /// <summary>
    /// Name interface full name
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Slaves slice of slaves interfaces names
    /// </summary>
    public List<string> Slaves { get; set; } = new();
}