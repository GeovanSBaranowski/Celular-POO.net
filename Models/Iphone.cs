using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) :
        base(numero, modelo, imei, memoria)
        {
            
        }
        public override string InstalarAplicativo(string nome)
        {
            return $"Instalando o aplicativo {nome} em seu Iphone";
        }
    }
}