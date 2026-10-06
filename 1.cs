namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();
            int suma = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                int numero = int.Parse(Console.ReadLine());
                pila.Push(numero);

                suma += numero;
            }
            Console.Clear();
            foreach(int n in pila)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Elemento en el tope: "+ pila.Peek());
            Console.WriteLine("La cantidad de elementos: "+pila.Count());
            Console.WriteLine("La suma de elementos : " + suma);
            Console.WriteLine("Extrayendo numeros");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(pila.Pop());
            }
        }
    }
}
