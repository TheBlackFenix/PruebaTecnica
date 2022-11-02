using ConsoleApp1.Models;
using PruebaTecnica.Logica;
using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
    
        Logica logica = new Logica();
        List<Persona> Lista = new List<Persona>();
        bool run = true;
        while (run)
        {
            Console.WriteLine("*** Menu ***");
            Console.WriteLine("1. Insertar Persona ");
            Console.WriteLine("2. Listar Persona");
            var opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    logica.InsertPersona(Lista);
                    break;
                case "2":
                    logica.ListarPersonas(Lista);
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;

            }


            Console.WriteLine("Desea Continuar Y/N");
            string cont = Console.ReadLine().ToLower();
            switch (cont)
            {
                case "y":
                    run=true;
                    break;
                case "n":
                    Console.WriteLine("Gracias por Usar el servicio");
                    run = false;
                    break;
                default:
                    run = true;
                    break;
            }
        }
    }
}