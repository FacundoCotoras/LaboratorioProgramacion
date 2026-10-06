namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Turnos 300001");
                Console.WriteLine("1. Solicitar turno");
                Console.WriteLine("2. Atender paciente");
                Console.WriteLine("3. Consultar próximo paciente");
                Console.WriteLine("4. Cantidad de pacientes esperando");
                Console.WriteLine("5. Salir");

                Console.Write("Opcion: ");
                int op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 5)
                    break;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del turno: ");

                        cola.Enqueue(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Paciente atendido ");
                        cola.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine("Prox paciente: " + cola.Peek());
                        break;
                    case 4:
                        Console.WriteLine("Cantidad de pacientes: " + cola.Count());
                        break;
                    default:
                        Console.WriteLine("Escribi bien mogolico");
                        break;
                }
            }
        }
    }
}
