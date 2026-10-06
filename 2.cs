namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pila = new Stack<string>();
            Console.WriteLine("Ingrese nombres. Cuando finalice escriba -FIN-.");

            while (true)
            {
                Console.WriteLine("Ingrese un Nombre: ");
                string nombre = Console.ReadLine();
                if (nombre.ToLower() == "fin")
                    break;
                pila.Push(nombre);
            }
            string[] vector = new string[pila.Count()];
            int cant = pila.Count();
            int i = 0;
            foreach (string n in pila)
            {
                vector[i] = n;
                i++;
            }
            Console.WriteLine("Orden en el que fueron ingresados: ");
            for (int x = vector.Length; x > 0 ; x--)
            {
                Console.WriteLine(vector[x-1]);
            }
            Console.WriteLine("Orden en el que seran retirados: ");
            for (int x = 0; x < cant; x++)
            {
                Console.WriteLine(pila.Pop());
            }
        }
    }
}
