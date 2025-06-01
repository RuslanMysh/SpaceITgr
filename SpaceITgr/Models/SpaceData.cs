using System.Collections.Generic;

namespace SpaceITgr.Models
{
	public static class SpaceData
	{
		public static Dictionary<int, Planet> Planets = new Dictionary<int, Planet>()
		{
			{173, new Planet(9000000000, "Planet173", "Andromeda", true, PlanetType.Earth_Type, "Земля", new DateTime(2199, 06, 8, 11, 30, 00))},
			{1731, new Planet(100000, "Satellite1731", "Andromeda", true, PlanetType.Satellite, "Луна", new DateTime(2199, 06, 8, 12, 00, 00))},
			{175, new Planet(340000000, "Planet175", "Andromeda", false, PlanetType.Earth_Type, "Марс", DateTime.Now)},
		};

		public static Dictionary<string, Quest> Quests = new Dictionary<string, Quest>()
		{
			{"p1", new Quest("Первый квест", "Блаблаблабла", new DateTime(2199, 05, 31, 11, 30, 00), QuestType.Current) },
			{"s1", new Quest("Помощь учёному", "Блаблаблабла", new DateTime(2199, 06, 01, 14, 25, 00), QuestType.Current) }
		};

		public static List<Item> Inventory = new List<Item>()
		{
			{new Item("Предмет", 1, 1) }
		};

		public static Dictionary<string, Locality> Locations = new Dictionary<string, Locality>()
        {
			{"c1", new Locality("Город173_1", 50000000, 1, LocalityType.CapitalCity)},
			{"v1", new Locality("НП173_199", 1000, 1, LocalityType.Village)},
			{"s1", new Locality("М173_281", 0, 1, LocalityType.Surface)}
		};
	}
}
