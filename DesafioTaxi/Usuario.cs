using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTaxi
{
    public abstract class Usuario
    {
        public string userID { get; set; }
        public string? userName { get; set; }
        protected string? userEmail { get; set; }
        protected string? userPassword { get; set; }
        protected string? userPhone { get; set; }
        public double userRate { get; set; } = 0;

        public Usuario()
        {
            Guid guid = Guid.NewGuid();
            userID = guid.ToString();

            Random random = new Random();
            double valor = random.NextDouble() * (5 - 0) + 0;
            double valor_round = Math.Round(valor, 1);
            userRate = valor_round;
        }

        public enum Properties
        {
            nome,
            email,
            senha,
            númeroTelefone
        }
        public bool Alterar(Usuario _user, Properties _prop, string _newInfo)
        {
            switch (_prop)
            {
                case Properties.nome:
                    _user.userName = _newInfo;
                    Console.WriteLine("\nNome de Usuário alterado com sucesso!");
                    return true;
                case Properties.email:
                    _user.userEmail = _newInfo;
                    Console.WriteLine("\nEmail do Usuário alterado com sucesso!");
                    return true;
                case Properties.senha:
                    _user.userPassword = _newInfo;
                    Console.WriteLine("\nSenha do Usuário alterado com sucesso!");
                    return true;
                case Properties.númeroTelefone:
                    _user.userPhone = _newInfo;
                    Console.WriteLine("\nNúmero de telefone do Usuário alterado com sucesso!");
                    return true;
                default:
                    Console.WriteLine("\nPropriedade Inválida.");
                    return false;
            }
        }

        public List<string> GetInfo(Usuario _user)
        {
            Console.WriteLine("\nInformações do Usuário:");
            List<string> props = new List<string>();
            foreach (var prop in _user.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(_user, null));
                string property = prop.Name + " = " + prop.GetValue(_user, null);
                props.Add(property);
            }
            return props;
        }
    }
}
