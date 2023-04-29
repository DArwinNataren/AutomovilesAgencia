/*Intituto Tecnologico Superior de Cintalapa
 * Programacion Orientada a Objetos
 * Profesor: Jorge Ivan Bermudez Rodriguez
 * Alumno: Darwin Amaury Nataren Arellano
 * Pratica: Herencia Tarea
 * Unidad: 3
 */
using System;
namespace Agencia_Automoviles
{

    public class  MENU:Agencia
    {
        public void C() {
            Console.WriteLine("Que auto comprara: Escriba el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la condicion: ");
            string condicion = Console.ReadLine();
            Agencia agencia = new Agencia(nombre, precio, condicion);
            agencia.Comprar();
        }
        public void V()
        {
            Console.WriteLine("Que auto comprara: Escriba el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la condicion: ");
            string condicion = Console.ReadLine();
            Agencia agencia = new Agencia(nombre, precio, condicion);
            agencia.Vender();
        }
        public void A()
        {
            Console.WriteLine("Que auto comprara: Escriba el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la condicion: ");
            string condicion = Console.ReadLine();
            Agencia agencia = new Agencia(nombre, precio, condicion);
            agencia.Alquilar();
        }
    }
}
