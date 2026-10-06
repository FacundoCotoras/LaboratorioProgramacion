
namespace ConsoleApp1
{
    internal class Program
    {

        struct Turno 
        {
            public int Numero;
            public string Nombre;
            public string Motivo;

        }
        static void Main(string[] args)
        {
            Turno aux;
            int cont = 1;
            Queue<Turno> cola = new Queue<Turno>();
            while (true)
            {
                Console.WriteLine("====================================\r\n       SISTEMA DE TURNOS\r\n====================================");
                Console.WriteLine("\r\n1. Solicitar turno\r\n2. Atender siguiente turno\r\n3. Mostrar turnos pendientes\r\n4. Mostrar próximo turno\r\n5. Mostrar cantidad de personas esperando\r\n6. Salir");
                int op = int.Parse(Console.ReadLine());
                if (op == 6)
                    break;
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        aux.Numero = cont;
                        cont++;
                        Console.WriteLine("Ingrese el Nombre del Paciente: ");
                        aux.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el Motivo de la Visita: ");
                        aux.Motivo = Console.ReadLine();
                        cola.Enqueue(aux);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Atendiendo Turno");
                        Turno aux2 = cola.Dequeue();
                        Console.WriteLine("Numero: " + aux2.Numero);
                        Console.WriteLine("Nombre: " + aux2.Nombre);
                        Console.WriteLine("Motivo: " + aux2.Motivo);
                        break;
                    case 3:
                        Console.Clear();
                        int cant = cola.Count();
                        foreach(Turno n in cola)
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("Numero: " + n.Numero);
                            Console.WriteLine("Nombre: " + n.Nombre);
                            Console.WriteLine("Motivo: " + n.Motivo);
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("PROXIMO TURNO");
                        Console.WriteLine("Numero: "+cola.Peek().Numero);
                        Console.WriteLine("Nombre: "+cola.Peek().Nombre);
                        Console.WriteLine("Motivo: "+cola.Peek().Motivo);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("CANTIDAD DE TURNOS PENDIENTES");
                        Console.WriteLine("             "+cola.Count());
                        break;
                }
            }
        }
    }
}
