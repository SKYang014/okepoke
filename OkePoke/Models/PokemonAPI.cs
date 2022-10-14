namespace OkePoke.Models
{
    public class PokeResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> abilities { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
    public class PokemonAPI
    {
        public static HttpClient _web = null;
        public static HttpClient GetHttpClient()
        {
            if (_web == null)
            {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
            }

            return _web;
        }
        public static async Task<Poke> FindPoke(int pokeId)
        {
            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync($"/{pokeId}");
            PokeResponse resp = await connection.Content.ReadAsAsync<PokeResponse>();

            Poke myPoke = new Poke();
            myPoke.id = resp.id;
            myPoke.name = resp.name;
            myPoke.abilities = new List<string>();
            myPoke.height = resp.height;
            myPoke.weight = resp.weight;
            return myPoke;
        }
    }
}
