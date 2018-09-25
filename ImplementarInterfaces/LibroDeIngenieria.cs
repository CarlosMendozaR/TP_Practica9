using System;

namespace ImplementarInterfaces
{
    class LibroDeIngenieria:Libros,ILibrosDeTexto
    {
        public LibroDeIngenieria(int hojas, int paginaActual)
        {
            this.hojas = hojas;
            this.paginaActual = paginaActual;
        }

        public override void AbrirLibro()
        {
            Console.WriteLine("Has abierto tu libro de ingenieria");
        }

        void ILibrosDeTexto.EstudiarLibro()
        {
            Console.WriteLine("Ahora estas estudiando el libro de Ingenieria");
        }

        void ILibrosDeTexto.LeerLibro()
        {
            Console.WriteLine("Ahora estas leyendo el libro de Ingenieria");
        }
    }
}
