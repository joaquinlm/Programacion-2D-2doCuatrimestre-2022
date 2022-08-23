using System;
namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int minimo = 0;
            int maximo = 0;
            decimal suma = 0;
            bool flag = false;
            bool exito = false;
            int auxInt;
            int segundo;
            int tercero;
            int cuarto;
            int quinto;
            decimal promedio;
                
            for(int i = 0; i<5; i++){
            Console.WriteLine($"Ingrese un número ({i+1})");
            aux = Console.ReadLine();
            exito = int.TryParse(aux, out auxInt);
            while(!exito)
            {
                Console.WriteLine($"Error, ingrese un número {i + 1}");
                aux = Console.ReadLine();
                exito = int.TryParse(aux, out auxInt);
            }
            if(!flag){
                maximo = auxInt;
                minimo = auxInt;
                flag = true;
            } else{

            if(auxInt>maximo)
            {

                maximo = auxInt;
            } else{
                if(auxInt<minimo){
                minimo = auxInt;
                }
            }
            }
                suma += auxInt;
            }
            
            promedio = suma / 5;
            Console.WriteLine($"El valor maximo es {maximo}, el mínimo es {minimo}, y el promedio {promedio}");
        }
    }
}
