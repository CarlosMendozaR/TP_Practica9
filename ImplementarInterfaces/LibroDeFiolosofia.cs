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

        public override void Opciones()
        {
            int opcion = 0;
            bool bandera = true;
            do
            {
                AbrirLibro();
                Console.WriteLine("Seleccion una accion para hacerla en tu libro:\n1. Ir a una pagina\n2. Estudiar libro\n3. Leer libro\n4. Cambiar de libro");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IrAPagina();
                        break;
                    case 2:
                        LeerLibro();
                        break;
                    case 3:
                        EstudiarLibro();
                        break;
                    case 4:
                        bandera = false;
                        break;
                }
            } while (bandera);
        }

        public void LeerLibro()
        {
            Console.WriteLine("Ahora estas estudiando el libro de Filosofia");
        }

        public void EstudiarLibro()
        {
            Console.WriteLine("Estas leyendo el libro de Filosofia");
        }
    }
}
