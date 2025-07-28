

using System.Security.Cryptography.X509Certificates;

class Carro
{
    public string Fabricante;
    public string Modelo;
    public int Ano;
    public int QuantidadePortas;
    public int Velocidade = 0;


    public void informacoesDoCarro()
    {
        Console.WriteLine($"Nome do fabricante: {Fabricante}");
        Console.WriteLine($"Modelo do carro: {Modelo}");
        Console.WriteLine($"Ano do carro: {Ano}");
        Console.WriteLine($"Quantidade de portas do carro: {QuantidadePortas} portas");
    }
    public void Acelerar()
    {
        Console.WriteLine("Acelerando....");

        if (Velocidade < 100)
        {
            Velocidade = Velocidade += 100;
            Console.WriteLine($"Velocidade atual: {Velocidade} km/h");
        }
        else
        {
            Console.WriteLine("Velocidade máxima atingida!");
        }
    }
    public void Frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade -= 20;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"Velocidade atual:{Velocidade} km/h");
        }
        else
        {
            Console.WriteLine("O carro já está parado.");
        }

        }
    public void Buzinar()
    {
        Console.WriteLine("Buzinando...");
        Console.WriteLine("Bi Bi");

    }
}