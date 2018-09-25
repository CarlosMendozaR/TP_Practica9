using System;

namespace ImplementarInterfaces
{
    class CuadernoDeEjercicios:Libros,IEjercicios
    {
        public CuadernoDeEjercicios(int hojas, int paginaActual)
        {
            this.hojas = hojas;
            this.paginaActual = paginaActual;
        }

        public override void AbrirLibro()
        {
            Console.WriteLine("Has abierto tu cuaderno de ejercicios");
        }

        void IEjercicios.ResolverEjercicio()
        {
            Console.WriteLine("Indica el ejercicio que quieres resolver");
            string ejercicio = Console.ReadLine();
            Console.WriteLine("El ejercicio que resuleves de tu cuaderno de ejercicios es: {0}", ejercicio);
        }
    }
}
