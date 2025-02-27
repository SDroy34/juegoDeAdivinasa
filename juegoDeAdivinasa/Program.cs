using juegoDeAdivinasa.Services;
using System;
using System.Numerics;
using System.Runtime;

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
            bool salir = false;
            do
            {

                #region Variables
                //Se crea un numero aleatorio
                bool converExitosa;
                Random numRando = new Random();
                int numUsuario;
                int intentos = 0, opc;
                Condiciones condiciones = new Condiciones();
                #endregion
                //Se muestra la lista de opciones

                Mensajes.MensajeIncio();
                var opcString = Console.ReadLine();
                converExitosa = int.TryParse(opcString, out opc);
                if (converExitosa == false)
                    opc = condiciones.ValidarNumUsuario();
                switch (opc)
                {
                    case 1:
                        int numeroFacil = numRando.Next(10);
                        Mensajes.PonUnNumeroCase1();
                        do
                        {
                            Mensajes.IngresNum();
                            var numString = Console.ReadLine();
                            converExitosa = int.TryParse(numString, out numUsuario);
                            if (converExitosa == false)
                                condiciones.ValidarNumUsuario();
                            if (converExitosa == true)
                            {
                                condiciones.CondicionMasBajoAlto(numUsuario, numeroFacil);
                            }
                            intentos++;
                        } while (numeroFacil != numUsuario);
                        Mensajes.Felicitaciones(numeroFacil, intentos);
                        break;
                    case 2:
                        int numeroMedio = numRando.Next(100);
                        Mensajes.PonUnNumeroCase2();
                        do
                        {
                            Mensajes.IngresNum();
                            var numString = Console.ReadLine();
                            converExitosa = int.TryParse(numString, out numUsuario);
                            if (converExitosa == false)
                                opc = condiciones.ValidarNumUsuario();
                            if (converExitosa == true)
                            {
                                condiciones.CondicionMasBajoAlto(numUsuario, numeroMedio);
                            }
                            intentos++;
                        } while (numeroMedio != numUsuario);
                        Mensajes.Felicitaciones(numeroMedio, intentos);
                        break;
                    case 3:
                        int numeroDificil = numRando.Next(1000);
                        Mensajes.PonUnNumeroCase3();
                        do
                        {
                            Mensajes.IngresNum();
                            var numString = Console.ReadLine();
                            converExitosa = int.TryParse(numString, out numUsuario);
                            if (converExitosa == false)
                                numUsuario = condiciones.ValidarNumUsuario();
                            if (converExitosa == true)
                            {
                                condiciones.CondicionMasBajoAlto(numUsuario, numeroDificil);
                            }
                            intentos++;
                        } while (numeroDificil != numUsuario);
                        Mensajes.Felicitaciones(numeroDificil, intentos);
                        break;
                    case 4:
                        salir = true;
                        break;
                    case >= 0:
                    case <= 5:
                        Console.WriteLine("Fuera de rango");
                        break;
                }

            } while (!salir);
            Mensajes.Despeida();
        }
    }
}

