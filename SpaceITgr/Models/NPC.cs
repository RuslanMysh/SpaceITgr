namespace SpaceITgr.Models
{
    public class NPC
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string OwnStory { get; set; }

        public NPC(string Name, string Species, string OwnStory)
        {
            this.Name = Name;
            this.Species = Species;
            this.OwnStory = OwnStory;
        }
    }
}
