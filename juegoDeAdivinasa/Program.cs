using juegoDeAdivinasa;
using System;

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
            Console.WriteLine("Este es un juego de adivinar el numero");
            //Se crea un numero aleatorio
            Random numRando = new Random();
            int numeroAleatorio = numRando.Next(100);
            int numUsuario;
            int intentos = 0; 
            //Se crea un objeto para mandar a llamar nuestras condiciones
            Condiciones condiciones = new Condiciones();
            condiciones.numeroRandom = numeroAleatorio;
            do
            {
                Console.WriteLine("Pon un numero del uno al cien.");
                var numString = Console.ReadLine();
                //Nos aseguramos de que el numero ingresado se entero
                bool converExit = int.TryParse(numString, out numUsuario);
                //Comprobamos que el numero sea entero
                condiciones.CondicionNumeroUsuario(converExit);
                if (converExit == true)
                {
                    //Damos pistas al usuario
                    condiciones.CondicionMasBajoAlto(numUsuario, numeroAleatorio);
                }
                
                intentos++;
            } while (numUsuario != numeroAleatorio);
            Console.WriteLine($"Felicidades encontrate el numeor aleatorio {numeroAleatorio} en el intento {intentos}");

        }
    }

}