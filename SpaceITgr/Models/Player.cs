namespace SpaceITgr.Models
{
	public class Player
	{
		public string DaysOfStay { get; set; }
		public string Species { get; set; }

		List<Planet> PlanetsKnowledgeList = new List<Planet>();

		public Player(string DaysOfStay, string Species)
		{
			this.DaysOfStay = DaysOfStay;
			this.Species = Species;
		}

		public void AddPlanet(Planet planet)
		{
			PlanetsKnowledgeList.Add(planet);
		}
	}
	
}
