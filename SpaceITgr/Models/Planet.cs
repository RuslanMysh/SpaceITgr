namespace SpaceITgr.Models
{
	public class Planet
	{
		public long Population { get; set; }
		public string CodeName { get; set; }
		public string LocalName { get; set; }
		public DateTime CurrentTime { get; set; }
		public string Belongs { get; set; }
		public bool StudiedByPlayer { get; set; }
        public PlanetType PlanetType { get; set; }
		public int ID { get; set; }

		public Planet(long Population, string CodeName, string Belongs, bool StudiedByPlayer, PlanetType PlanetType, string LocalName, DateTime CurrentTime, int ID)
		{
			this.Population = Population;
			this.CodeName = CodeName;
			this.Belongs = Belongs;
			this.StudiedByPlayer = StudiedByPlayer;
			this.PlanetType = PlanetType;
			this.LocalName = LocalName;
			this.CurrentTime = CurrentTime;
			this.ID = ID;
		}
	}

	public enum PlanetType
	{
		Earth_Type,
		Gas_Giants,
		Dwarf_Planets,
		Satellite
	}
}
