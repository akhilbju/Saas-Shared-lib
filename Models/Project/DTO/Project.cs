using System;
using System.Collections.Generic;

public record class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<User> TeamMembers { get; set; } = new List<User>();
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedById { get; set; }
    public User CreatedBy { get; set; } 
}