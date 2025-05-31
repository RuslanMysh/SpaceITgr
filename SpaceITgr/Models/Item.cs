namespace SpaceITgr.Models
{
	public class Item
	{
		public string Name { get; set; }
		public int Mass {  get; set; }
		public int Count {  get; set; }

		public Item(string Name, int Mass, int Count)
		{
			this.Name = Name;
			this.Mass = Mass;
			this.Count = Count;
		}
	}
	
}
