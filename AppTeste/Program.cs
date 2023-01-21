using System;
using static System.Net.WebRequestMethods;

namespace DiscordLinkGerador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINKS INICIAIS
            string linkservidor = "https://discord.com/channels/";
            string linkperfil = "https://discord.com/users/";
        //CODE
        Start:
            Console.Clear();
            Console.Title = "Gerador de links discord em geral! - Made by Aligg";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("________  .__                              .___\r\n\\______ \\ |__| ______ ____  ___________  __| _/\r\n |    |  \\|  |/  ___// ___\\/  _ \\_  __ \\/ __ | \r\n |    `   \\  |\\___ \\\\  \\__(  <_> )  | \\/ /_/ | \r\n/_______  /__/____  >\\___  >____/|__|  \\____ | \r\n        \\/        \\/     \\/                 \\/ ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione a opção que deseja usar:");
            Console.WriteLine();
            Console.WriteLine("1. Gerar link de servidor");
            Console.WriteLine("2. Gerar link de perfil");
            Console.WriteLine("3. Sair do sistema");
            Console.WriteLine();
            Console.Write("Escolha:");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.Clear();
                Console.WriteLine("Digite o ID do servidor em que deseja entrar:");
                Console.Write("ID:");
                string idservidor = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Seu link foi gerado: {linkservidor}" + $"{idservidor}");
                Thread.Sleep(15000);
                goto Start;
            }
            if (answer == "2")
            {
                Console.Clear();
                Console.WriteLine("Digite o ID do perfil em que deseja conversar:");
                Console.Write("ID:");
                string idperfil = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Seu link foi gerado: {linkperfil}" + $"{idperfil}");
                Thread.Sleep(15000);
                goto Start;
            }
            if (answer == "3")
            {
                Console.Clear();
                goto Start;
            }


        }
    }
}
