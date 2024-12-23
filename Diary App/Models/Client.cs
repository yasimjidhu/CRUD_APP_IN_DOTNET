namespace Diary_App.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ItemClient>? ItemClients { get; set; }

    }
}
