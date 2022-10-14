namespace OkePoke.Models
{
    public class Poke
    {
        public int id { get; set; }
        public string name { get; set; }   
        public List<string> abilities { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

    }
}
