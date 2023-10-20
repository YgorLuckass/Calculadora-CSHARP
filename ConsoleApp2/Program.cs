using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair");
        

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1": 
                Somar();
            break;
            
            case "2":
                Subtrair();
            break;
            
            case "3":
                Mutliplicar(); 
            break;
            
            case "4":
                Dividir();
            break;

            case "5":
                Resto();
            break;    

            case "6":
                Potenciacao();
            break;

            case "0":
            break;
                default:
            Menu();
                break;
            
        }

    }

    public static void Somar()
    {
        double valor1, valor2;
        Console.Write("Entre com o valor 1: ");
        valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Entre com o valor 2: ");
        valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Soma = {0}", (valor1 + valor2).ToString("F2",CultureInfo.InvariantCulture));
        Console.ReadLine();
        Menu();
    }

    public static void Subtrair()
    {
        double valor1, valor2;

        Console.Write("Entre com o valor 1: ");
        valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Entre com o valor 2: ");
        valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Subtração = {0}", (valor1 - valor2).ToString("F2",CultureInfo.InvariantCulture));
        Console.ReadLine();
        Menu();
    }

    public static void Mutliplicar()
    {
        double valor1, valor2;

        Console.Write("Entre com o valor 1: ");
        valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Entre com o valor 2: ");
        valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Multiplicação = {0} ",(valor1 * valor2).ToString("F2",CultureInfo.InvariantCulture));
        Console.ReadLine();
        Menu();
    }

    public static void Dividir()
    {
        double valor1, valor2;
        Console.Write("Entre com o divisor: ");
        valor1 = double.Parse(Console.ReadLine());
        Console.Write("Entre com o dividendo: ");
        valor2 = double.Parse(Console.ReadLine());

        if (valor2 != 0)
        {
            Console.WriteLine("Divisão = {0}", (valor1 / valor2).ToString("F2",CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero! ");
        }

        Console.ReadLine();
        Menu();

    }

    public static void Resto()
    {
        double valor1, valor2;

        Console.Write("Entre com o dividendo: ");
        valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Entre com o divisor: ");
        valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        if (valor2 != 0)
        {
            Console.WriteLine("Resto da divisão = {0}", (valor1% valor2).ToString("F2",CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero");
        }

        Console.ReadLine();
        Menu();
    }

    public static void Potenciacao()
    {
        double valor1, valor2;

        Console.Write("Entre com a base: ");
        valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Entre com o expoente: ");
        valor2  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Potenciação = {0}", (Math.Pow(valor1, valor2)).ToString("F2",CultureInfo.InvariantCulture));
        Console.ReadLine();
        Menu();
    } 
}   



   


