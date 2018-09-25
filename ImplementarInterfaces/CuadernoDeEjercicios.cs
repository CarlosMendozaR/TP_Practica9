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

        public override void Opciones()
        {
            int opcion = 0;
            bool bandera = true;
            do
            {
                AbrirLibro();
                Console.WriteLine("Seleccion una accion para hacerla en tu libro:\n1. Ir a una pagina\n2. Colorear libro\n3. Cambiar de libro");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IrAPagina();
                        break;
                    case 2:
                        ResolverEjercicio();
                        break;
                    case 3:
                        bandera = false;
                        break;
                }
            } while (bandera);
        }

        public void ResolverEjercicio()
        {
            Console.WriteLine("Indica el ejercicio que quieres resolver");
            string ejercicio = Console.ReadLine();
            Console.WriteLine("El ejercicio que resuleves de tu cuaderno de ejercicios es: {0}", ejercicio);
        }
    }
}
