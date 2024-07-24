namespace ViewModelApplication.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}