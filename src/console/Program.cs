namespace console
{
    using System;
    using domain.Entidades;
    using domain.Interfaces;
    using ioc;
    using Microsoft.Extensions.DependencyInjection;
    using services;

    public class Program
    {
        private static IDividerService _dividerService;

        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = NativeInjectorBootstrapper.GetProvider(serviceCollection);

            _dividerService = serviceProvider.GetService<IDividerService>();

            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                mostrarMenu = Menu();
            }
        }

        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opçao:");
            Console.WriteLine("1) Calcular divisores que compoem um numero");
            Console.WriteLine("2) Calcular divisores primos que compoem um numero.");
            Console.WriteLine("3) Sair");
            Console.Write("\r\nDigite o numero da opcao desejada: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"\r\nOpcao selecionada 'Calcular divisores que compoem um numero'");
                    CalculateDividers(false);
                    return true;
                case "2":
                    Console.WriteLine($"\r\nOpcao selecionada 'Calcular divisores primos que compoem um numero'.");
                    CalculateDividers(true);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }

        }

        public static string CheckUserEntry()
        {
            Console.WriteLine("\r\nDigite o numero para realizar o calculo: ");
            return Console.ReadLine();
        }

        public static void PrintResult(string message)
        {
            Console.WriteLine($"\r\n{message}");
            Console.Write("\r\nPressione Enter para retornar ao menu inicial: ");
            Console.ReadLine();
        }

        public static void CalculateDividers(bool prime)
        {
            try
            {
                var entry = CheckUserEntry();
                if (!int.TryParse(entry, out int number) || number <= 0)
                {
                    PrintResult($"Valor digitado nao valido. O valor foi: {number}");
                    return;
                }

                Divider divider = new Divider
                {
                    Number = number,
                    Prime = prime,
                };

                var result = _dividerService.CalculateDivider(divider);
                if (result.Ok)
                {
                    PrintResult($"O resultado obtido foi: {string.Join(",", result.Dividers)}");
                }
                else
                {
                    PrintResult($"{result.Error}");
                }
            }
            catch (Exception ex)
            {
                PrintResult($"Ocorreu um erro: {ex.Message} ");                
            }
        }

    }
}