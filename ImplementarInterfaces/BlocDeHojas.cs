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

        public override void Opciones()
        {
            int opcion = 0;
            bool bandera = true;
            do
            {
                AbrirLibro();
                Console.WriteLine("Seleccion una accion para hacerla en tu libro:\n1. Ir a una pagina\n2. Reolver un ejercicio\n3. Cambiar de libro");
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
            Console.WriteLine("Estas resolviendo un ejercicio en tu bloc de hojas");
        }
    }
}
