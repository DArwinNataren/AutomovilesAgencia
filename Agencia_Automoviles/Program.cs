/*Intituto Tecnologico Superior de Cintalapa
 * Programacion Orientada a Objetos
 * Profesor: Jorge Ivan Bermudez Rodriguez
 * Alumno: Darwin Amaury Nataren Arellano
 * Pratica: Herencia Tarea
 * Unidad: 3
 */
using System;
using System.Diagnostics;

namespace Agencia_Automoviles
{
    public class Program : Inventario
    {
        public static void Main(String[] arg)
        {
            Inventario inventario = new Inventario();
            MENU men = new MENU();
            int veces = 0;
            do {
                Console.WriteLine("\nQue desea hacer: Comprar, Vender o Alquilar \n Use una de las tres opciones: C,V o A");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "C":
                        Console.WriteLine("1: Autos Mazda\n2: Autos Mercedes\n3: Autos Chevrolet\n4: Autos Renault\n5: Autos Volgwagen\n6: salir");
                        uint opmar = Convert.ToUInt16(Console.ReadLine());
                        switch (opmar)
                        {
                            case 1:
                                inventario.Maz();
                                men.C();
                                break;
                            case 2:
                                inventario.Mer();
                                men.C();
                                break;
                            case 3:
                                inventario.Che();
                                men.C();
                                break;
                            case 4:
                                inventario.Ren();
                                men.C();
                                break;
                            case 5:
                                inventario.Vol();
                                men.C();
                                break;
                            case 6:
                                break;
                        }
                        break;
                    case "V":
                        Console.WriteLine("1: Autos Mazda\n2: Autos Mercedes\n3: Autos Chevrolet\n4: Autos Renault\n5: Autos Volgwagen\n6: salir");
                        uint opm = Convert.ToUInt16(Console.ReadLine());
                        switch (opm)
                        {
                            case 1:
                                inventario.Maz();
                                men.V();
                                break;
                            case 2:
                                inventario.Mer();
                                men.V();
                                break;
                            case 3:
                                inventario.Che();
                                men.V();
                                break;
                            case 4:
                                inventario.Ren();
                                men.V();
                                break;
                            case 5:
                                inventario.Vol();
                                men.V();
                                break;
                            case 6:
                                break;
                        }
                        break;
                    case "A":
                        Console.WriteLine("1: Autos Mazda\n2: Autos Mercedes\n3: Autos Chevrolet\n4: Autos Renault\n5: Autos Volgwagen\n6: salir");
                        uint o = Convert.ToUInt16(Console.ReadLine());
                        switch (o)
                        {
                            case 1:
                                inventario.Maz();
                                men.A();
                                break;
                            case 2:
                                inventario.Mer();
                                men.A();
                                break;
                            case 3:
                                inventario.Che();
                                men.A();
                                break;
                            case 4:
                                inventario.Ren();
                                men.A();
                                break;
                            case 5:
                                inventario.Vol();
                                men.A();
                                break;
                            case 6:
                                break;
                        }
                        break;
                } 
            } while (veces < 20);
        }
    }
}