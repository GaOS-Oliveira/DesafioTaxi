using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTaxi
{
    public class Corrida
    {
        public string CorridaID { get; set; }
        public string EndInicio { get; set; }
        public string EndFim { get; set; }
        public string Valor { get; set; }
        public enum Metodos
        {
            CartaoCredito,
            CartaoDebito,
            Dinheiro,
            Paypal,
            ApplePay,
            Pix
        }
        public Metodos MetodoPag { get; set; }

        public Corrida(string _inicio, string _fim)
        {
            Guid guid = Guid.NewGuid();
            CorridaID = guid.ToString();

            EndInicio = _inicio;
            EndFim = _fim;
            GerarValor(EndInicio, EndFim);
        }

        public string CancelarCorrida (Corrida _corrida)
        {
            _corrida = null;
            return "\nCorrida cancelada com sucesso.";
        }

        public List<string> GetInfo(Corrida _corrida)
        {
            Console.WriteLine("\nInformações da Corrida:");
            List<string> props = new List<string>();
            foreach (var prop in _corrida.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(_corrida, null));
                string property = prop.Name + " = " + prop.GetValue(_corrida, null);
                props.Add(property);
            }
            return props;
        }

        public string GerarValor(string localInicio, string localFim)
        {
            Random random = new Random();
            double valor = random.NextDouble() * (100 - 1) + 1;
            double valor_round = Math.Round(valor, 2);
            Valor = valor_round.ToString();
            return $"Valor da Corrida: R${valor}";
        }
    }
}
