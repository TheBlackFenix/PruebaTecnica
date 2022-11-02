using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Logica
{
    public class Logica
    {
        public void InsertPersona(List<Persona> Lista)
        {
            Persona persona = new Persona();
            DatosContacto contacto = new DatosContacto();
            var context = new ValidationContext(persona, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            Console.WriteLine("Ingrese Documento de Cliente");
            persona.Documento = Console.ReadLine();
            Console.WriteLine("Ingrese Nombres de Cliente");
            persona.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese Apellidos de Cliente");
            persona.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese FechaNacimiento de Cliente");
            persona.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("*** Datos Contacto ***");
            Console.WriteLine("Telefono");
            contacto.Telefono = Console.ReadLine();
            Console.WriteLine("Telefono 2");
            contacto.Telefono2 = Console.ReadLine();
            Console.WriteLine("Email");
            contacto.CorreoElectronico = Console.ReadLine();
            Console.WriteLine("Telefono 2");
            contacto.CorreoElectronico2 = Console.ReadLine();
            Console.WriteLine("Direccion");
            contacto.Direccion = Console.ReadLine();
            Console.WriteLine("Direccion Alternativa");
            contacto.Direccion2 = Console.ReadLine();

            persona.DatosContacto = contacto;
            var context2 = new ValidationContext(contacto, serviceProvider: null, items: null);
            var isValid = Validator.TryValidateObject(persona, context, results, true);
            var isValidContacto = Validator.TryValidateObject(contacto, context2, results, true);

            if (!isValid || !isValidContacto)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            else
            {
                bool unico = true;
                foreach(var person in Lista)
                {
                    if(person.Documento == persona.Documento)
                    {
                        Console.WriteLine("El Cliente ya se encuentra registrado");
                        unico = false;
                    }
                }
                if (unico)
                {
                    Lista.Add(persona);
                    Console.WriteLine("*** Registro Exitoso ***");
                }
            }
        }
        public void ListarPersonas(List<Persona> Lista)
        {
            int registro = 0;
            foreach(var persona in Lista)
            {
                Console.WriteLine($"{registro} - Documento: {persona.Documento} - Nombre: {persona.Nombres} {persona.Apellidos} - Fecha Nacimiento: {persona.FechaNacimiento}");
            }
        }
    }
}
