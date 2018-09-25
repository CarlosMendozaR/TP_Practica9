using System;

namespace ImplementarInterfaces
{
    class BlocDeHojas:Libros,IEjercicios
    {
        public BlocDeHojas(int hojas, int paginaActual)
        {
            this.hojas = hojas;
            this.paginaActual = paginaActual;
        }

        void IEjercicios.ResolverEjercicio()
        {
            Console.WriteLine("Estas resolviendo un ejercicio en tu bloc de hojas");
        }
    }
}
