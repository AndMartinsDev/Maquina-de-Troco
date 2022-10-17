namespace MqTroco.Data
{
    public class Caixa
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public List<Moeda> Moedas { get; set; } = new List<Moeda>();


        public Caixa(string userName)
        {
            UserName = userName;
        }
    }
}
