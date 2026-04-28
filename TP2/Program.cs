namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Ejercicio 1
            Console.WriteLine("Ingrese su Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine(nombre + " en 10 años tendrá "+(edad+10)+" años");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
//Ejercicio 2
            Console.WriteLine("Ingrese 2 números, el primero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("La resta es: ");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("El producto es: ");
            Console.WriteLine(num1 * num2);
            float cociente = num1 / num2;
            Console.WriteLine("El cociente es: "+cociente);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
//Ejercicio 3
            Console.WriteLine("Ingrese 1 número entero: ");
            int nument = int.Parse(Console.ReadLine());
            if (nument / 2 == 0)
            {
                Console.WriteLine("El Numero es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

            if (nument == 0)
            {
                Console.WriteLine("El numero es Cero");
            }
            else if (nument < 0){
                Console.WriteLine("El número es negativo");
            }
            else if (nument > 0)
            {
                Console.WriteLine("El número es positivo");
            }

        }

    }
}
