
namespace MqTroco.Data
{
    public class Caixa
    {
        public Caixa()
        {
        }

        public int Id { get; set; }
        public List<Moeda> Moedas { get; set; } = new List<Moeda>();


    }
}
