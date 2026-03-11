using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; } = string.Empty;
        private string Modelo { get; set; } = string.Empty;
        private string IMEI { get; set; } = string.Empty;
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Iniciando chamada...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Ligacao aceita");
        }

        public abstract string InstalarAplicativo(string nome);

    }
}