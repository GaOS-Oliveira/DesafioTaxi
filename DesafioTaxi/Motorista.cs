using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTaxi
{
    public class Motorista : Usuario
    {
        public string carro { get; set; }
        public string ContaReceb { get; set; }

        public Motorista(string _name, string _email, string _password, string _phone, Carro carro, string contaReceb)
        {
            this.carro = carro.modelo;
            ContaReceb = contaReceb;
            this.userName = _name;
            this.userEmail = _email;
            this.userPassword = _password;
            this.userPhone = _phone;
        }

        public bool AceitarCorrida(Corrida _corrida)
        {
            Console.Write($"\nCorrida para \"{_corrida.EndFim}\"\nNo valor de: R${_corrida.Valor}\n" +
                "Deseja aceitar a corrida? ");
            string resposta = Console.ReadLine().ToLower();
            if(resposta == "sim")
            {
                Console.WriteLine("Você aceitou a corrida.");
                return true;
            }
            else if (resposta == "não" || resposta == "nao")
            {
                Console.WriteLine("Você recusou a corrida");
                return false;
            }
            else
            {
                Console.WriteLine("Valor Inválido!");
                return false;
            }
        }

        public bool ConfirmarPagamento(Corrida _corrida)
        {
            Random random = new Random();
            bool confirmado = random.NextDouble() > 0.5; // Variável para testes
            if (confirmado)
            {
                Console.WriteLine("\nPagamento Confirmado!");
                return true;
            }
            else
            {
                Console.WriteLine("\nAguardando passageiro pagar.");
                return false;
            }
        }

        public string AvaliarPassageiro(Passageiro _passageiro)
        {
            Console.Write("\nAvalie o passageiro [0-5]: ");
            var nota = Console.ReadLine();
            Console.WriteLine($"Você avaliou o motorista {_passageiro.userName} com a nota: {nota}");
            return nota;
        }
    }
}
