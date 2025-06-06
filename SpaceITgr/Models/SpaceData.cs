using System.Collections.Generic;

namespace SpaceITgr.Models
{
	public static class SpaceData
	{
		public static Dictionary<int, Planet> Planets = new Dictionary<int, Planet>()
		{
			{173, new Planet(9000000000, "Planet173", "Andromeda", true, PlanetType.Earth_Type, "Земля", new DateTime(2199, 06, 8, 11, 30, 00), 173)},
			{1731, new Planet(100000, "Satellite1731", "Andromeda", true, PlanetType.Satellite, "Луна", new DateTime(2199, 06, 8, 12, 00, 00), 1731)},
			{175, new Planet(340000000, "Planet175", "Andromeda", false, PlanetType.Earth_Type, "Марс", new DateTime(2199, 06, 8, 21, 00, 00), 175)},
            {001, new Planet(1, "Planet001", "independency", false, PlanetType.Dwarf_Planets, "Маск", new DateTime(2200, 06, 8, 11, 30, 00), 001)}
        };

		public static List<Quest> Quests = new List<Quest>()
		{

		};

		public static List<Item> Inventory = new List<Item>()
		{

		};

		public static Dictionary<string, Locality> Locations = new Dictionary<string, Locality>()
        {
			{"c1", new Locality("Город173_1", 50000000, 1, LocalityType.CapitalCity, "city1")},
			{"v1", new Locality("НП173_199", 1000, 1, LocalityType.Village, "village1")},
			{"s1", new Locality("М173_281", 0, 1, LocalityType.Surface, "surface1")},
            {"c2", new Locality("Город175_2", 10000000, 1, LocalityType.CapitalCity, "city2")},
            {"v2", new Locality("НП175_105", 100, 1, LocalityType.Village, "village2")},
            {"s2", new Locality("М175_304", 0, 1, LocalityType.Surface, "surface2")},
			{"c3", new Locality("Город1731_3", 25000000, 1, LocalityType.CapitalCity, "city3")},
            {"v3", new Locality("НП1731_134", 1000, 1, LocalityType.Village, "village3")},
            {"s3", new Locality("М1731_527", 0, 1, LocalityType.Surface, "surface3")},
            {"c4", new Locality("ТРОН", 1, 1, LocalityType.CapitalCity, "city4")},
            {"v4", new Locality("СТАТУЯ 1С", 0, 1, LocalityType.Village, "village4")},
            {"s4", new Locality("ГОРЫ", 0, 1, LocalityType.Surface, "surface4")}
        };
	}
}
