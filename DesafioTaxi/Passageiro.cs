using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTaxi
{
    public class Passageiro : Usuario
    {
        protected List<string> cartoes { get; set; }
        protected List<string> carteirasDigitais { get; set; }

        public Passageiro(string _name, string _email, string _password, string _phone)
        {
            this.userName = _name;
            this.userEmail = _email;
            this.userPassword = _password;
            this.userPhone = _phone;
            this.cartoes = new List<string>();
            this.carteirasDigitais = new List<string>();
        }

        public Corrida ChamarCorrida(string _inicio, string _fim)
        {
            Console.WriteLine("\nVocê chamou uma nova corrida!");
            Corrida nova_corrida = new Corrida(_inicio, _fim);
            return nova_corrida;
        }

        public string AvaliarMotorista(Motorista _motorista)
        {
            Console.Write("\nAvalie o motorista [0-5]: ");
            var nota = Console.ReadLine();
            Console.WriteLine($"Você avaliou o motorista {_motorista.userName} com a nota: {nota}");
            return nota;
        }
    }
}
