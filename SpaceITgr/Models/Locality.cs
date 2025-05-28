namespace SpaceITgr.Models
{
	public class Locality
	{
		public string Name { get; set; }
		public int Population { get; set; }
		public int QuestCount { get; set; }
		QuestType QuestType { get; set; }

		public Locality(string Name, int Population, int QuestCount, QuestType QuestType)
		{
			this.Name = Name;
			this.Population = Population;
			this.QuestCount = QuestCount;
			this.QuestType = QuestType;
		}
	}
	public enum QuestType
	{
		Completed,
		Failed,
		Active
	}
}
