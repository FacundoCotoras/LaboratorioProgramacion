namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> cola = new Queue<int>();

            while (true)
            {

                Console.WriteLine("Ingrese un numero: ");
                int nombre = int.Parse(Console.ReadLine());
                if (nombre == 0)
                    break;
                cola.Enqueue(nombre);

            }
            int[] vector = new int[cola.Count()];
            Console.WriteLine("El primer numero ingresado: "+cola.Peek());
            int i = 0;
            foreach(int n in cola)
            {
                vector[i] = n;
                i++;
            }
            Console.WriteLine("Ultimo numero ingresado: " + vector[cola.Count() - 1]);
            Console.WriteLine("La cantidad de numeros ingresados: "+cola.Count());
            int cant = cola.Count();
            for(int x = 0; x <cant; x++ )
            {
                Console.WriteLine("Eliminando: "+cola.Dequeue());
            }
        }
    }
}
