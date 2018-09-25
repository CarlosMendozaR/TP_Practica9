using System;

namespace ImplementarInterfaces
{
    class LibroDeFiolosofia:Libros,ILibrosDeTexto
    {
        public LibroDeFiolosofia(int hojas, int paginaActual)
        {
            this.hojas = hojas;
            this.paginaActual = paginaActual;
        }

        public override void AbrirLibro()
        {
            Console.WriteLine("Has abierto tu libro de Filosofia");
        }

        void ILibrosDeTexto.EstudiarLibro()
        {
            Console.WriteLine("Ahora estas estudiando el libro de Filosofia");
        }

        void ILibrosDeTexto.LeerLibro()
        {
            Console.WriteLine("Estas leyendo el libro de Filosofia");
        }
    }
}
