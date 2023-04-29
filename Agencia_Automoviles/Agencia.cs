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
    public class Agencia
    {
        public string Nombre;
        public string Condicion;
        public double Precio;
        public string _Nombre
        {
            get => Nombre; set => Nombre = value;
        }
        public string _Condicion
        {
            get => Condicion; set => Condicion = value;
        }
        public double _precio
        {
            get => Precio; set => Precio = value;
        }
        //Metodos
        public void Registrar() 
        {
            Console.WriteLine("HOla");
        }
        public void Comprar()
        {
            Console.WriteLine(Nombre + " ha sido comprado por el precio: $" + Precio + " en la condicion: " + Condicion);
        }
        public void Vender()
        {
            Console.WriteLine(Nombre+ " ha sido vendido por el precio: $" + Precio+" en la condicion: "+Condicion);
        }
        public void Alquilar()
        {
            Console.WriteLine(Nombre + " ha sido alquilado por el precio: $" + Precio + " en la condicion: " + Condicion);
        }

        public void VerDatos()
        {
            Console.WriteLine(Nombre + "\n" + Precio + "\n" + Condicion + "\n");
        }
        //Constructor con parametros
        public Agencia(string nombre, double precio, string condicion)
        {
            Nombre = nombre;
            Precio = precio;
            Condicion = condicion;
        }
        //Constructor por defecto vacio
        public Agencia() { }

    }

}
