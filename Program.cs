namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, result;
            string sinal;
            bool sucesso;
            int tipo;
            Console.WriteLine("Digite um número");
            sucesso = decimal.TryParse(Console.ReadLine(), out num1);
            if (sucesso == false)
            {
                Console.WriteLine("Falha na Execução");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite o segundo número");
            sucesso = decimal.TryParse(Console.ReadLine(), out num2);
            if (sucesso == false)
            {
                Console.WriteLine("Falha na Execução");
                Environment.Exit(0);
            }
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            sucesso = int.TryParse(Console.ReadLine(), out tipo);
            if (sucesso == false)
            {
                Console.WriteLine("Falha na Execução");
                Environment.Exit(0);
            }
            result = 0;
            sinal = "g";
            if (tipo == 1)
            {
                result = num1 + num2;
                sinal = "+";
            }
            if (tipo == 2)
            {
                result = num1 - num2;
                sinal = "-";
            }
            if (tipo == 3)
            {
                result = num1 * num2;
                sinal = "x";
            }
            if (tipo == 4)
            {
                result = num1 / num2;
                sinal = "/";
            }
            Console.WriteLine("O resultado de " + num1 + sinal + num2 + " é " + result);
        }
    }
}
