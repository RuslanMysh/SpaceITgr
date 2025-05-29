namespace SpaceITgr.Models
{
	public class Locality
	{
		public string Name { get; set; }
		public int Population { get; set; }
		public int QuestCount { get; set; }
        LocalityType LocalityType { get; set; }

		public Locality(string Name, int Population, int QuestCount, LocalityType QuestType)
		{
			this.Name = Name;
			this.Population = Population;
			this.QuestCount = QuestCount;
			this.LocalityType = LocalityType;
		}
	}
	public enum LocalityType
    {
		CapitalCity,
		Village,
		Surface
	}
}
