﻿using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;



// Hello World! program
namespace bootcamp_CSharp_lesson_7
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            var miVariable = new { Nombre = "Ivan", Dinero = 200 };
            Console.WriteLine(miVariable.Nombre + " " + miVariable.Dinero);
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(150, 90);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");
        }


    }

}