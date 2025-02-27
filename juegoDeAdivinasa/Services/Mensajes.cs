using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDeAdivinasa.Services
{
    public static class Mensajes
    {
         public static void MensajeIncio()
        {
            Console.Write("Este es un juego de adivinar el numero \r\n" +
                "Elije un nivle de dificultad \r\n" +
                "1. Facil \r\n" +
                "2. Medio \r\n" +
                "3. Dificil \r\n" +
                "4. Salir \r\n" +
                "Seleciona:");
        }
        public static void Felicitaciones(int numRamd, int intento)
        {
            Console.WriteLine($"Feliciades enontraste el numero random {numRamd} en el intento {intento}.");
        }

        public static void PonUnNumeroCase1() { Console.WriteLine("Pon un numero del 1 al 10."); }
        public static void PonUnNumeroCase2() { Console.WriteLine("Pon un numero del 1 al 100"); }
        public static void PonUnNumeroCase3() { Console.WriteLine("Pon un numeor del 1 al 100"); }
        public static void Despeida() { Console.WriteLine("Gracias por jugar, hasta la proxima."); }
        public static void IngresNum() { Console.Write("Ingresa un numero: "); }
    }
}
