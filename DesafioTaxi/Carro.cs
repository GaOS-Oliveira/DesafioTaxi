using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTaxi
{
    public class Carro
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string localizacao { get; set; }

        public Carro(string placa, string modelo, string cor, string localizacao)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.localizacao = localizacao;
        }

        public List<string> GetInfo(Carro _carro)
        {
            Console.WriteLine("\nInformações do Carro:");
            List<string> props = new List<string>();
            foreach (var prop in _carro.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(_carro, null));
                string property = prop.Name + " = " + prop.GetValue(_carro, null);
                props.Add(property);
            }
            return props;
        }
    }
}
