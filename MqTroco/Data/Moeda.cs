﻿
namespace MqTroco.Data
{
    public class Moeda
    {
        public Moeda(string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Qtd { get; set; }

    }
}
