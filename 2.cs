using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("{0,-8}{1,-16}{2,-16}{3,-16}", "PISO", "OFICINA 1", "OFICINA 2", "OFICINA 3");

            for (int fila = 0; fila < 4; fila++)
            {
                Console.Write("{0,-8}", fila + 1);

                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write("{0,-16}", edificio[fila, columna].Nombre);
                }
                Console.WriteLine();
            }
        }
        static void Contar()
        {
            Console.Clear();
            int suma = 0;
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    suma += edificio[fila, columna].Cantidad;
                }
            }
            Console.WriteLine("La suma de los Empleados de todas la oficinas es de: "+suma);
        }
        static void Eliminar()
        {
            Console.Clear();
            Oficina aux;
            aux.Nombre = "Disponible";
            aux.Cantidad = 0;
            aux.ocupado = false;
            Console.WriteLine("Ingrese el piso de la oficina: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Departamento: ");
            int columna = int.Parse(Console.ReadLine());
            edificio[fila, columna] = aux;
            Console.WriteLine("La oficina fue eliminada");
        }
        static void Asignar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el piso de la oficina: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Departamento: ");
            int columna = int.Parse(Console.ReadLine());
            if (edificio[fila, columna].ocupado == false)
            {
                Console.WriteLine("Ingrese el nombre de su empresa: ");
                edificio[fila, columna].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de empleados de su empresa: ");
                edificio[fila, columna].Cantidad = int.Parse(Console.ReadLine());
                edificio[fila, columna].ocupado = true;
            }
            else
                Console.WriteLine("Ese espacio ya esta ocupado");
        }
        static void inicializar()
        {
            Oficina aux;
            aux.Nombre = "Disponible";
            aux.Cantidad = 0;
            aux.ocupado = false;
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    edificio[fila, columna] = aux;
                }
            }
        }
        struct Oficina()
        {
            public string Nombre;
            public int Cantidad;
            public bool ocupado;
        }
        static Oficina[,] edificio = new Oficina[4, 3];
        static void Main(string[] args)
        {
            inicializar();
            while (true)
            {
                Console.WriteLine(" MENU\r\n  1 - Asignar Oficina\r\n  2 - Liberar Oficina\r\n  3 - Contar Empleados\r\n  4 - Mostrar Mapa\r\n  5 - Salir");
                int op = int.Parse(Console.ReadLine());
                if (op == 5)
                    break;
                switch (op)
                {
                    case 1:
                        Asignar();
                            break;
                    case 2:
                        Eliminar();
                        break;
                    case 3:
                        Contar();
                        break;
                    case 4:
                        Mostrar();
                        break;
                    default:
                        Console.WriteLine("Pone unaopcion valida");
                        break;
                }
            }
        }
    }
}
