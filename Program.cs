using System;

class Caculator
{
    static void Main()
    {
        title();
        Console.Write("-> ");
        int choose = Convert.ToInt32(Console.ReadLine());

        switch (choose)
        {
            case 1:
                Console.WriteLine("Digit dois numeros para cerem mutiplicados");
                Console.Write("Primeiro numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("segundo numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                mutiplicar(num, num1);
                break;
                
            case 2:
                Console.WriteLine("Digit dois numeros para cerem divididos");
                Console.Write("Primeiro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("segundo numero: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                divir(num2, num3);
                break;
                            
            case 3:
                Console.WriteLine("Digit dois numeros para cerem somados");
                Console.Write("Primeiro numero: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                Console.Write("segundo numero: ");
                int num5 = Convert.ToInt32(Console.ReadLine());
                somar(num4, num5);
                break;
                            
            case 4:
                Console.WriteLine("Digit dois numeros para cerem subtraidos");
                Console.Write("Primeiro numero: ");
                int num6 = Convert.ToInt32(Console.ReadLine());
                Console.Write("segundo numero: ");
                int num7 = Convert.ToInt32(Console.ReadLine());
                subtrair(num6, num7);
                break;

            default:
                Console.WriteLine("Opção invalida, selecione uma opção valida");
                break;
        }
        
    }

    static void title()
    {
        Console.WriteLine("======Caculator=====");
        Console.WriteLine("= 1 -> Mutiplicar  =");
        Console.WriteLine("= 2 -> Dividir     =");
        Console.WriteLine("= 3 -> somar       =");
        Console.WriteLine("= 4 -> subtrair    =");
        Console.WriteLine("====================");
    }

    static void mutiplicar(int num, int num1)
    {
        int resp = num * num1;
        Console.WriteLine("Resultado: " + resp);
    }
    static void divir(int num, int num1)
    {
        try
        {
            int resp = num / num1;
            Console.WriteLine("Resultado: " + resp);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Houve uma indeterminancia.");
        }
    }
    static void somar(int num, int num1)
    {
        int resp = num + num1;
        Console.WriteLine("Resultado: " + resp);
    }
    static void subtrair(int num, int num1)
    {
        int resp = num - num1;
        Console.WriteLine("Resultado: " + resp);
    }
}