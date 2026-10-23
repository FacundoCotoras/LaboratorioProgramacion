namespace ConsoleApp1
{
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double promedio = 0;
            int contA = 0;
            int cont = 0;
            string[] lineas = File.ReadAllLines("NOTAS_A_PROMEDIAR.TXT");

            int[] notas = new int[lineas.Length];

            for (int i = 0; i < lineas.Length; i++)
            {
                notas[i] = int.Parse(lineas[i]);
            }
            for(int i = 0; i < lineas.Length; i++)
            {
                cont++;
                suma = suma + notas[i];
                if (cont == 3)
                {
                    promedio = suma / 3.0;
                    Console.WriteLine($"Promedio{contA++}: {promedio:f2}");
                    suma = 0;
                    cont = 0;
                } 
            }
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 10)
                {
                    notas[i]++;
                }
            }

            // 3. Convertimos cada número entero a string
            for (int i = 0; i < notas.Length; i++)
            {
                lineas[i] = notas[i].ToString();
            }
            File.WriteAllLines("Notas Modificadas", lineas);
        }
    }
}
