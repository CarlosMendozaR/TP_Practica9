using System;

namespace ImplementarInterfaces
{
    class Program
    {
        static void Main()
        {
            LibroDeFiolosofia LFilosofia = new LibroDeFiolosofia(350, 0);
            LibroDeIngenieria LIngenieria = new LibroDeIngenieria(400, 0);
            LibroParaColorear LColorear = new LibroParaColorear(80, 0);
            CuadernoDeEjercicios LEjericios = new CuadernoDeEjercicios(120, 0);
            BlocDeHojas LBlock = new BlocDeHojas(100, 0);

            bool bandera = true;
            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenido a tu librero, escoge un libro para trabajar:\n1. Libro de Ingenieria\n2. Libro de Filosofia\n3. Libro para colorear\n4. Cuaderno de Ejercicios\n5. Bloc de hojas\n6. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        LIngenieria.Opciones();
                        break;
                    case 2:
                        LFilosofia.Opciones();
                        break;
                    case 3:
                        LColorear.Opciones();
                        break;
                    case 4:
                        LEjericios.Opciones();
                        break;
                    case 5:
                        LBlock.Opciones();
                        break;
                    case 6:
                        bandera = false;
                        break;
                    default:
                        Console.WriteLine("Incorrecto");
                        break;
                }
            } while (bandera);
        }
    }
}
