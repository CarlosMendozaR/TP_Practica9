using System;

namespace ImplementarInterfaces
{
    abstract class Libros
    {
        public int hojas;
        public int paginaActual;

        public void ContarHojas()
        {
            Console.WriteLine("Tu libro tiene {0} hojas", hojas);
        }

        public virtual void AbrirLibro()
        {
            Console.WriteLine("Se abrio tu libro");
        }

        public void IrAPagina()
        {
            Console.WriteLine("Escribe la pagina a la que deseas ir");
            paginaActual = int.Parse(Console.ReadLine());
            Console.WriteLine("Te encuentras en la pagina" + paginaActual);
        }

        public virtual void Opciones()
        {

        }
    }
}
