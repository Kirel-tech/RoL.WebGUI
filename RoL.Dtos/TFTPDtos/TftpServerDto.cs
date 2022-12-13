﻿namespace RoL.Dtos.TFTPDtos;

public class TftpServerDto
{
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Enabled { get; set; }
    public string Id { get; set; }
    public string Port { get; set; }
    public string State { get; set; }
    public DateTime UpdatedAt { get; set; }
}