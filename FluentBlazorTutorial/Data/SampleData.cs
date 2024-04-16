using FluentBlazorTutorial.Model;

namespace FluentBlazorTutorial.Data;

public class SampleData
{
	
	public static List<Player> Players = new List<Player>
	{
		new Player
		{
			Name = "Alpha Doe",
			Country = "Australia",
			Placement = new List<int?> { 1, 2, 4, 12}
		},
		new Player
		{
			Name = "Beta Smith",
			Country = "Japan",
			Placement = new List<int?> { 12, null, 6, null }
		},
		new Player
		{
			Name = "Charlie Brown",
			Country = "Australia",
			Placement = new List<int?> { 9, 29, 8, null }
		},
		new Player
		{
			Name = "Delta Epsilon",
			Country = "Greece",
			Placement = new List<int?> { 3, null, 7, 21 }
		},
		new Player
		{
			Name = "Jane Doe",
			Country = "Australia",
			Placement = new List<int?> { 21, 12, null, null }
		},
		new Player
		{
			Name = "John Smith",
			Country = "United States of America",
			Placement = new List<int?> { 7, 16, 2, 3 }
		},
		new Player
		{
			Name = "Ron Pearl",
			Country = "United States of America",
			Placement = new List<int?> { 8, 1, null, 10}
		}
	};
}