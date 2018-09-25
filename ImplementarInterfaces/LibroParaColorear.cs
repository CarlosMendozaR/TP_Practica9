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

        public override void Opciones()
        {
            int opcion = 0;
            bool bandera = true;
            do
            {
                AbrirLibro();
                Console.WriteLine("Seleccion una accion para hacerla en tu libro:\n1. Ir a una pagina\n2. Colorear libro\n3. Compartir dibujo\n4. Cambiar de libro");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IrAPagina();
                        break;
                    case 2:
                        ColorearLibro();
                        break;
                    case 3:
                        CompartirDibujo();
                        break;
                    case 4:
                        bandera = false;
                        break;
                }
            } while (bandera);
        }

        public void ColorearLibro()
        {
            Console.WriteLine("Estas coloreando tu libro para colorear");
        }

        public void CompartirDibujo()
        {
            Console.WriteLine("Indica la red social donde quieres compartir tu dibujo:");
            string redSocial = Console.ReadLine();
            Console.WriteLine("Se ha compartido tu dibujo en {0}", redSocial);
        }
    }
}
