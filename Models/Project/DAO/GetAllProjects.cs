using System.Collections.Generic;

public record class GetAllProjects
{
    public int Count { get; set; }
    public List<Project> Projects { get; set; } = new List<Project>();
}