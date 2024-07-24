namespace ViewModelApplication.Models
{
    public class SoccerPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PositionID { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public Position Position { get; set; }

    }
}
