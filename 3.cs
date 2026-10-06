namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();
            Console.WriteLine("Ingrese nombres. Cuando finalice escriba -FIN-.");

            while (true)
            {
                Console.WriteLine("Ingrese un Numnero: ");
                int nombre = int.Parse(Console.ReadLine());
                if (nombre == 0)
                    break;
                if(nombre % 2 == 0)
                    pila.Push(nombre);
            }
            Console.Clear();
            int suma = 0;
            int cant = pila.Count();
            Console.WriteLine("Los numeros pares ingresados fueron: " + pila.Count()) ;
            foreach (int n in pila)
            {
                Console.WriteLine(n);
                suma += n;
            }
            Console.WriteLine("La suma de los numeros: "+suma);
            Console.WriteLine("Orden en el que seran retirados: ");
            for (int x = 0; x < cant; x++)
            {
                Console.WriteLine(pila.Pop());
            }
        }
    }
}
