/*Intituto Tecnologico Superior de Cintalapa
 * Programacion Orientada a Objetos
 * Profesor: Jorge Ivan Bermudez Rodriguez
 * Alumno: Darwin Amaury Nataren Arellano
 * Pratica: Herencia Tarea
 * Unidad: 3
 */
using System;
using System.Collections.Generic;
namespace Agencia_Automoviles
{
    public class Inventario : Agencia
    {
        public void Maz()
        {
            List<Agencia> modelosMazda = new List<Agencia>();
            modelosMazda.Add(new Agencia("Mazda CX-5", 32000.0, "Nuevo"));
            modelosMazda.Add(new Agencia("Mazda 3", 25000.0, "Seminuevo"));
            modelosMazda.Add(new Agencia("Mazda CX-9", 40000.0, "Nuevo"));
            modelosMazda.Add(new Agencia("Mazda MX-5", 28000.0, "Usado"));
            modelosMazda.Add(new Agencia("Mazda CX-3", 28000.0, "Seminuevo"));
            foreach (Agencia modelo in modelosMazda)
            {
                Console.WriteLine("Nombre: {0}, Precio: {1:C}, Condición: {2}", modelo.Nombre, modelo.Precio, modelo.Condicion);
            }
        }
        public void Mer()
        {
            List<Agencia> modelosMercedes = new List<Agencia>();
            modelosMercedes.Add(new Agencia("Mercedes-Benz Clase A", 35000.0, "Nuevo"));
            modelosMercedes.Add(new Agencia("Mercedes-Benz Clase C", 42000.0, "Seminuevo"));
            modelosMercedes.Add(new Agencia("Mercedes-Benz GLA", 38000.0, "Nuevo"));
            modelosMercedes.Add(new Agencia("Mercedes-Benz Clase E", 54000.0, "Usado"));
            modelosMercedes.Add(new Agencia("Mercedes-Benz GLC", 47000.0, "Seminuevo"));
            foreach (Agencia modelo in modelosMercedes)
            {
                Console.WriteLine("Nombre: {0}, Precio: {1:C}, Condición: {2}", modelo.Nombre, modelo.Precio, modelo.Condicion);
            }
        }
        public void Che()
        {
            List<Agencia> ModelosChevrolet = new List<Agencia>();
            ModelosChevrolet.Add(new Agencia("Chevrolet Spark", 12000.0, "Nuevo"));
            ModelosChevrolet.Add(new Agencia("Chevrolet Aveo", 15000.0, "Seminuevo"));
            ModelosChevrolet.Add(new Agencia("Chevrolet Trax", 22000.0, "Nuevo"));
            ModelosChevrolet.Add(new Agencia("Chevrolet Malibu", 28000.0, "Usado"));
            ModelosChevrolet.Add(new Agencia("Chevrolet Equinox", 32000.0, "Seminuevo"));
            foreach (Agencia modelo in ModelosChevrolet)
            {
                Console.WriteLine("Nombre: {0}, Precio: {1:C}, Condición: {2}", modelo.Nombre, modelo.Precio, modelo.Condicion);
            }
        }
        public void Ren()
        {
            Dictionary<string, Agencia> modelosRenault = new Dictionary<string, Agencia>();
            modelosRenault.Add("Renault Duster", new Agencia("Renault Duster", 25000.0, "Nuevo"));
            modelosRenault.Add("Renault Logan", new Agencia("Renault Logan", 16000.0, "Seminuevo"));
            modelosRenault.Add("Renault Sandero", new Agencia("Renault Sandero", 19000.0, "Nuevo"));
            modelosRenault.Add("Renault Kwid", new Agencia("Renault Kwid", 13000.0, "Usado"));
            modelosRenault.Add("Renault Captur", new Agencia("Renault Captur", 32000.0, "Seminuevo"));
            foreach (KeyValuePair<string, Agencia> modelo in modelosRenault)
            {
                Console.WriteLine("Nombre: {0}, Precio: {1:C}, Condición: {2}", modelo.Value.Nombre, modelo.Value.Precio, modelo.Value.Condicion);
            }
        }
        public void Vol()
        {
            Dictionary<string, Agencia> modelosVolkswagen = new Dictionary<string, Agencia>();
            modelosVolkswagen.Add("Volkswagen Golf", new Agencia("Volkswagen Golf", 28000.0, "Nuevo"));
            modelosVolkswagen.Add("Volkswagen Jetta", new Agencia("Volkswagen Jetta", 26000.0, "Seminuevo"));
            modelosVolkswagen.Add("Volkswagen Polo", new Agencia("Volkswagen Polo", 20000.0, "Nuevo"));
            modelosVolkswagen.Add("Volkswagen Tiguan", new Agencia("Volkswagen Tiguan", 32000.0, "Usado"));
            modelosVolkswagen.Add("Volkswagen Passat", new Agencia("Volkswagen Passat", 35000.0, "Seminuevo"));
            foreach (KeyValuePair<string, Agencia> modelo in modelosVolkswagen)
            {
                Console.WriteLine("Nombre: {0}, Precio: {1:C}, Condición: {2}", modelo.Value.Nombre, modelo.Value.Precio, modelo.Value.Condicion);
            }
        }
    }
}