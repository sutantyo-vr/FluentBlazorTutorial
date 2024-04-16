namespace FluentBlazorTutorial.Model;

public class Player
{
	public required string Name { get; set; }
	public required string Country { get; set; }
	public required List<int?> Placement { get; set; }
	
}