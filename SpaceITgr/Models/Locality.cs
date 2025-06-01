namespace SpaceITgr.Models
{
	public class Locality
	{
		public string Name { get; set; }
		public int Population { get; set; }
		public int QuestCount { get; set; }
        public LocalityType LocalityType { get; set; }
		public string Route { get; set; }

		public Locality(string Name, int Population, int QuestCount, LocalityType LocalityType, string Route)
		{
			this.Name = Name;
			this.Population = Population;
			this.QuestCount = QuestCount;
			this.LocalityType = LocalityType;
			this.Route = Route;
		}
	}
	public enum LocalityType
    {
		CapitalCity,
		Village,
		Surface
	}
}
