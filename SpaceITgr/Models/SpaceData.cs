using System.Collections.Generic;

namespace SpaceITgr.Models
{
	public static class SpaceData
	{
		public static Dictionary<int, Planet> Planets = new Dictionary<int, Planet>()
		{
			{173, new Planet(9000000000, "Planet173", "Andromeda", true, PlanetType.Earth_Type, "Earth", DateTime.Now)},
			{1731, new Planet(100000, "Satellite1731", "Andromeda", true, PlanetType.Satellite, "Moon", DateTime.Now)},
			{175, new Planet(340000000, "Planet175", "Andromeda", true, PlanetType.Earth_Type, "Mars", DateTime.Now)},
		};
	}
}
