namespace BlazorApp1.Shared;

public class Solution
{
    public string Path { get; set; }
    public string Name { get; set; }
    public string SettingsPath { get; set; }
    public Status Status { get; set; }

}
public enum Status
{ 
Stopped,
Loading, Started
}

