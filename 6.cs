namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();

            while (true)
            {

                Console.WriteLine("Ingrese el nombre de un cliente: ");
                string nombre = Console.ReadLine();
                if (nombre.ToLower() == "fin")
                    break;
                cola.Enqueue(nombre);

            }
            Console.Clear();
            Console.WriteLine("Prox Cliente: "+cola.Peek());
            int cant = cola.Count();
            for(int i = 0; i < cant; i++)
            {
                Console.WriteLine("Atendiendo cliente "+ cola.Peek());
                cola.Dequeue();
            }
            Console.WriteLine("Cantidad de clientes atendidos: "+cant);
        }
    }
}
