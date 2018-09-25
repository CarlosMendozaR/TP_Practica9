using System;

namespace ImplementarInterfaces
{
    class LibroParaColorear:Libros,ILibrosDidacticos
    {
        public LibroParaColorear(int hojas, int paginaActual)
        {
            this.hojas = hojas;
            this.paginaActual = paginaActual;
        }

        public override void AbrirLibro()
        {
            Console.WriteLine("Has abierto tu libro para colorear");
        }

        void ILibrosDidacticos.ColorearLibro()
        {
            Console.WriteLine("Estas coloreando tu libro para colorear");
        }

        void ILibrosDidacticos.CompartirDibujo()
        {
            Console.WriteLine("Indica la red social donde quieres compartir tu dibujo:");
            string redSocial = Console.ReadLine();
            Console.WriteLine("Se ha compartido tu dibujo en {0}", redSocial);
        }
    }
}
