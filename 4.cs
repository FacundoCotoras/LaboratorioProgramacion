namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pila = new Stack<string>();

            while (true)
            {
                Console.WriteLine("Calculadora 300001");
                Console.WriteLine("1. Registrar Operacion");
                Console.WriteLine("2. Deshacer última operación");
                Console.WriteLine("3. Consultar última operación");
                Console.WriteLine("4. Mostrar cantidad de operaciones");
                Console.WriteLine("5. Salir");

                Console.Write("Opcion: ");
                int op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 5)
                    break;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese la operacio: ");
                        
                        pila.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ultima operacion borrada ");
                        pila.Pop();
                        break;
                    case 3:
                        Console.WriteLine("Ultima operacion: "+pila.Peek());
                        break;
                    case 4:
                        Console.WriteLine("Cantidad de operaciones: "+pila.Count());
                        break;
                    default:
                        Console.WriteLine("Escribi bien mogolico");
                        break;
                }
            }
        }
    }
}
