using System.Threading.Tasks;

namespace PubgNet.Example
{
    class Program
    {
        static void Main() => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            PubgNetClient client = new PubgNetClient("your-api-key");
            var players = await client.GetPlayersByUsernames(new string[]{"shroud"});
        }
    }
}
