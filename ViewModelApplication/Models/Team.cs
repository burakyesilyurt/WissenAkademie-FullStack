namespace ViewModelApplication.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public ICollection<SoccerPlayer> SoccerPlayer { get; set; }
    }
}