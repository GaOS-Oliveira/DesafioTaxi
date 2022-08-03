using DesafioTaxi;

GetInfoUser();

void GetInfoUser()
{
    Console.Write("Qual o tipo de usuário?\n");
    Console.Write("Passageiro [1]\nMotorista[2]\nDigite uma opção: ");
    string option = Console.ReadLine().ToString();
    if (option == "1")
    {
        Console.Write("Digite o seu nome: ");
        string _name = Console.ReadLine();
        Console.Write("Digite o seu email: ");
        string _email = Console.ReadLine();
        Console.Write("Digite a sua senha: ");
        string _password = Console.ReadLine();
        Console.Write("Digite o seu número de telefone: ");
        string _phone = Console.ReadLine();

        Passageiro temp_user = new Passageiro(_name, _email, _password, _phone);

        Console.Write("Deseja pedir um taxi? [sim/não] ");
        string resposta = Console.ReadLine().ToString().ToLower();
        if (resposta == "sim")
        {
            Console.Write("Digite o endereço de partida: ");
            string _inicio = Console.ReadLine();
            Console.Write("Digite o endereço de destino: ");
            string _fim = Console.ReadLine();
            Corrida corrida = temp_user.ChamarCorrida(_inicio, _fim);
            corrida.GetInfo(corrida);

            // Motorista de Exemplo
            Carro car = new Carro("BRA2O22", "Chevrolet Onix", "Vermelho", "-23.562245, -46.655411");
            Motorista motorista1 = new Motorista("João Andrade", "example@gmail.com", "123456@", "55 11 991234567", car, "123 12345-6");
            temp_user.AvaliarMotorista(motorista1);
        }
        else
        {
            Console.WriteLine("Tudo bem! Tenha um bom dia!");
        }
    }
    else if (option == "2")
    {
        Console.Write("Digite o seu nome: ");
        string _name = Console.ReadLine();
        Console.Write("Digite o seu email: ");
        string _email = Console.ReadLine();
        Console.Write("Digite a sua senha: ");
        string _password = Console.ReadLine();
        Console.Write("Digite o seu número de telefone: ");
        string _phone = Console.ReadLine();

        Console.WriteLine("Registre seu carro: ");
        Console.Write("Digite a placa do carro: ");
        string _placa = Console.ReadLine();
        Console.Write("Digite o modelo do carro: ");
        string _modelo = Console.ReadLine();
        Console.Write("Digite a cor do carro: ");
        string _cor = Console.ReadLine();

        Carro temp_car = new Carro(_placa, _modelo, _cor, "-23.562245, -46.655411");
        Motorista temp_user = new Motorista(_name, _email, _password, _phone, temp_car, "123 12345-6");

        // Corrida de Exemplo
        Corrida corr = new Corrida("Praça Ramos de Azevedo - República, São Paulo", "Av. Paulista, 1578");
        // Passageiro de Exemplo
        Passageiro temp_passageiro = new Passageiro("Leonardo Oliveira", "example2022@gmail.com", "123456", "+55 (11) 99123-4567");

        temp_user.AceitarCorrida(corr);
        temp_user.AvaliarPassageiro(temp_passageiro);
    }
    else
    {
        Console.WriteLine("Opção Inválida!");
    }

}
// Informações do Passageiro:
Passageiro passageiro1 = new Passageiro("Leonardo Oliveira", "example2022@gmail.com", "123456", "+55 (11) 99123-4567");
List<string> InfoUser1 = passageiro1.GetInfo(passageiro1);

// Informações de um veículo:
Carro car = new Carro("BRA2O22", "Chevrolet Onix", "Vermelho", "-23.562245, -46.655411");
List<string> InfoCarro = car.GetInfo(car);

// Informações do Motorista:
Motorista motorista1 = new Motorista("João Andrade", "example@gmail.com", "123456@", "55 11 991234567", car, "123 12345-6");
List<string> InfoUser2 = motorista1.GetInfo(motorista1);

// Informações de uma corrida:
Corrida corr = new Corrida("Praça Ramos de Azevedo - República, São Paulo", "Av. Paulista, 1578");
List<string> InformacoesCorrida = corr.GetInfo(corr);

var corrida1 = passageiro1.ChamarCorrida("Praça Ramos de Azevedo - República, São Paulo", "Av. Paulista, 1578");
passageiro1.AvaliarMotorista(motorista1);

motorista1.AceitarCorrida(corrida1);
motorista1.AvaliarPassageiro(passageiro1);
motorista1.ConfirmarPagamento(corrida1);

passageiro1.Alterar(passageiro1, Usuario.Properties.nome, "Leonardo Oliveira dos Santos");