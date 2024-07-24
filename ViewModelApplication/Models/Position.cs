namespace ViewModelApplication.Models
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<SoccerPlayer> SoccerPlayer { get; set; }
    }
}