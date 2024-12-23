using juegoDeAdivinasa;
using System;
using System.Numerics;

//2.Juego de adivinanzas(número secreto)
//Descripción: Un pequeño juego en el que los jugadores
//intentan adivinar un número secreto con pistas (más alto, más bajo).
//Características:
//Contador de intentos.
//Mensajes dinámicos para guiar al jugador.
//Opción para jugar nuevamente.
//Tecnologías:
//Consola para la interfaz básica o WinForms para algo más visual.
//Roles:
//Uno puede diseñar la lógica del juego.
//Otro puede trabajar en el diseño y las interacciones.
//Un tercero puede agregar características adicionales como dificultad o estadísticas.


namespace juegodeadivinasa
{
    class JuegoAdivinasaMain
    {
        static void Main(string[] args)
        {
            //Se crea un numero aleatorio
            Random numRando = new Random();
            int numUsuario;
            int intentos = 0, opc;
            Condiciones condiciones = new Condiciones();
            //Se muestra la lista de opciones
            Console.WriteLine("Este es un juego de adivinar el numero");
            Console.WriteLine("Elije un nivel\n" +
                "1. Facil\n" +
                "2. Medio\n" +
                "3. Dificil");
            var opcString = Console.ReadLine();
            bool converExit2 = int.TryParse(opcString, out opc);
            condiciones.CondicionNumeroUsuario(converExit2);
            if (converExit2 == true)
            {
                switch (opc)
                {
                    case 1:
                        int numeroFacil = numRando.Next(10);
                        Console.WriteLine("Pon un numero del 1 al 10");
                        do
                        {
                            var numString = Console.ReadLine();
                            bool converExitosa = int.TryParse(numString, out numUsuario);
                            condiciones.CondicionNumeroUsuario(converExitosa);
                            if (converExitosa == true)
                            {
                                condiciones.CondicionMasBajoAlto(numUsuario, numeroFacil);
                            }
                            intentos++;
                        } while (numeroFacil != numUsuario);
                        Console.WriteLine($"Felicidades encontrate el numeor aleatorio {numeroFacil} en el intento {intentos}");
                        break;
                    case 2:
                        int numeroMedio = numRando.Next(100);
                        Console.WriteLine("Pon un numero del 1 al 100");
                        do
                        {
                            var numString = Console.ReadLine();
                            bool converExitosa = int.TryParse(numString, out numUsuario);
                            condiciones.CondicionNumeroUsuario(converExitosa);
                            if (converExitosa == true)
                            {
                            condiciones.CondicionMasBajoAlto(numUsuario, numeroMedio);
                            }
                            intentos++;
                        } while (numeroMedio != numUsuario);
                        Console.WriteLine($"Felicidades encontrate el numeor aleatorio {numeroMedio} en el intento {intentos}");
                        break;
                    case 3:
                        int numeroDificil = numRando.Next(1000);
                        Console.WriteLine("Pon un numero del 1 al 1000");
                        do
                        {
                            var numString = Console.ReadLine();
                            bool converExitosa = int.TryParse(numString, out numUsuario);
                            condiciones.CondicionNumeroUsuario(converExitosa);
                            if (converExitosa == true)
                            {
                                condiciones.CondicionMasBajoAlto(numUsuario, numeroDificil);
                            }
                            intentos++;
                        } while (numeroDificil != numUsuario);
                        Console.WriteLine($"Felicidades encontrate el numeor aleatorio {numeroDificil} en el intento {intentos}");
                        break;
                    default:
                        Console.WriteLine("Elije una opcion valida");
                        break;
                }

            }
        }
    }
}
