using juegodeadivinasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDeAdivinasa.Services
{
    public class Condiciones
    {

        public void CondicionMasBajoAlto(int numeroUsuario, int numeroRandom)
        {
            if (numeroUsuario > numeroRandom)
            {
                Console.WriteLine("Mas bajo");
            }
            else
            {
                Console.WriteLine("Mas alto");
            }

        }
        public int  ValidarNumUsuario()
        {
            bool band = false, conver;
            int numUser;
            do
            {
                Console.WriteLine("Valor incorrecto");
                Console.Write("Ingresa una opcion valida: ");   
                var numStrUser =Console.ReadLine();
                conver = int.TryParse(numStrUser, out numUser);
                if(conver == false)
                {
                    band = false;
                }
                else
                {
                    band = true;
                }


            } while (!band);
            return numUser;
        }
    }
}