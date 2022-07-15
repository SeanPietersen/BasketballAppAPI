namespace BasketballApp.Domain
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
        public ICollection<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
