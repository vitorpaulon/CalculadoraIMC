using System;

public class Program
{

    public static void Main(String[] args)
    {


        Console.WriteLine("Digite a altura da pessoa: ");
        float altura = float.Parse(Console.ReadLine()); // leitura e conversao de tipos

        Console.WriteLine("Digite o peso da pessoa: ");
        float peso = float.Parse(Console.ReadLine()); // leitura e conversao de tipos

        float IMC = peso / (altura * altura); // calculo do IMC

        Console.WriteLine("Seu IMC e: " + IMC + "\n");// \n pula linha

        Console.WriteLine("IMC menor que 18.5 significa abaixo do peso;");
        Console.WriteLine("IMC entre 18.5 e 24.9 significa peso normal");
        Console.WriteLine("IMC entre 25 e 29.9 significa sobrepeso");
        Console.WriteLine("IMC entre 30 e 34.9 significa obesidade I");
        Console.WriteLine("IMC entre 35 e 40 significa obesidade II e III");

    }
}