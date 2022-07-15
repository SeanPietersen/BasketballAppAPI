namespace BasketballApp.Domain
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double PlayerHeight { get; set; }
        public double PlayerWeight { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
    }
}
