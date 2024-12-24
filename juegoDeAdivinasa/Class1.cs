using juegodeadivinasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoDeAdivinasa
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
        public void CondicionNumeroUsuario(bool conversionExitosa)
        {
            if (conversionExitosa == false)
            {
                Console.WriteLine("Pon un numero valido");
            }
        }
    }
}