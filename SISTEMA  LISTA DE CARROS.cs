using System;
using System.Collections.Generic;
using System.Linq;

class Program
{   //Aqui crio uma lista de carros 
    static List<(string Marca, string Modelo, int Ano, string Potencia, string Cilindrada, string Combustivel)> carros = new List<(string, string, int, string, string, string)>();

    //Loop para escolher a opção desejada abaixo
    static void Main(string[] args)
    {   
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar carro");
            Console.WriteLine("2 - Exibir carros");
            Console.WriteLine("3 - Remover carro");
            Console.WriteLine("4 - Buscar carro");
            Console.WriteLine("5 - Editar carro");
            Console.WriteLine("6 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarCarro();
                    break;
                case "2":
                    ExibirCarros();
                    break;
                case "3":
                    RemoverCarro();
                    break;
                case "4":
                    BuscarCarro();
                    break;
                case "5":
                    EditarCarro();
                    break;
                case "6":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
    //Aqui irá adicionar o carro que queira na lista
    static void AdicionarCarro()
    {
        Console.Write("Marca: ");
        string Marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string Modelo = Console.ReadLine();
        Console.Write("Ano: ");
        int Ano = int.Parse(Console.ReadLine());
        Console.Write("Potência: ");
        string Potencia = Console.ReadLine();
        Console.Write("Cilindrada: ");
        string Cilindrada = Console.ReadLine();
        Console.Write("Combustível: ");
        string Combustivel = Console.ReadLine();

        carros.Add((Marca, Modelo, Ano, Potencia, Cilindrada, Combustivel));
        Console.WriteLine("Carro adicionado com sucesso.");
    }
    //Exibirá o carro que adicionou na lista
    static void ExibirCarros()
    {
        foreach (var carro in carros)
        {
            Console.WriteLine ( $"Marca: {carro.Marca}\n Modelo: {carro.Modelo}\n Ano: {carro.Ano}\n Potencia: {carro.Potencia}\n Cilindrada: {carro.Cilindrada}\n Combustível: {carro.Combustivel}");
        }
    }
    //Removerá o carro que deseja da lista
    static void RemoverCarro()
    {
        Console.Write("Digite o modelo ou a marca do carro que deseja remover: ");
        string entrada = Console.ReadLine();
        var carro = carros.FirstOrDefault(c => c.Modelo == entrada || c.Marca == entrada);

        if (carro != default)
        {
            carros.Remove(carro);
            Console.WriteLine("Carro removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.");
        }
    }
    //Faz uma busca na lista do modelo ou marca que deseja encontrar
    static void BuscarCarro()
    {
        Console.Write("Digite o modelo ou a marca do carro a buscar: ");
        string entrada = Console.ReadLine();
        var carro = carros.FirstOrDefault(c => c.Modelo == entrada || c.Marca == entrada);

        if (carro != default)
        {
            Console.WriteLine( $"Marca: {carro.Marca}\n Modelo: {carro.Modelo}\n Ano: {carro.Ano}\n Potencia: {carro.Potencia}\n Cilindrada: {carro.Cilindrada}\n Combustível: {carro.Combustivel}");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.");
        }
    }
    //Muda as informações da lista,do carro que queira trocar 
    static void EditarCarro()
    {
        Console.Write("Digite o modelo do carro a editar: ");
        string modelo = Console.ReadLine();
        var carro = carros.FirstOrDefault(c => c.Modelo == modelo);

        if (carro != default)
        {
            Console.Write("Nova marca: ");
            string novaMarca = Console.ReadLine();
            Console.Write("Novo modelo: ");
            string novoModelo = Console.ReadLine();
            Console.Write("Novo ano: ");
            int novoAno = int.Parse(Console.ReadLine());
            Console.Write("Nova potência: ");
            string novaPotencia = Console.ReadLine();
            Console.Write("Nova cilindrada: ");
            string novaCilindrada = Console.ReadLine();
            Console.Write("Novo combustível: ");
            string novoCombustivel = Console.ReadLine();

            carros[carros.IndexOf(carro)] = (novaMarca, novoModelo, novoAno, novaPotencia, novaCilindrada, novoCombustivel);
            Console.WriteLine("Carro atualizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.");
        }
    }
}
