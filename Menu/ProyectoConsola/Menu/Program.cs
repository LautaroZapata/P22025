namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            // menu
            string[] opciones = { "Ejercicio 1", "Ejercicio 2", "Ejercicio 3", "Ejercicio 4", "Ejercicio 5", "Ejercicio 6", "Ejercicio 7", "Ejercicio 8" };
            // solicita numeros hasta que se ponga 0
            do
            {
                Menu(opciones);
                opcion = Utils.PedirNumero("Opcion");
                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Ejercicio5();
                        break;
                    case 6:
                        Ejercicio6();
                        break;
                    case 7:
                        Ejercicio7();
                        break;
                    case 8:
                        Ejercicio8();
                        break;
                }
                if (opcion != 0)
                {
                    Console.Write("Cualquier tecla para seguir...");
                    Console.ReadKey();
                }

            } while (opcion != 0);

        }

        static public void Menu(string[] opciones)
        {
            Console.Clear();
            int numero = 1;
            Console.WriteLine("Ingresa una de las siguientes opciones (0 para finalizar)");
            foreach (string opcion in opciones)
            {
                Console.WriteLine(numero + " - " + opcion);
                numero++;
            }
        }
        static public void Ejercicio1()
        { 
          /*    Solicitar números hasta que ingrese el 0 (fin del ingreso).
                Se debe comparar con un número random e indicar cuando son iguales.
          */
            
            int numeroIngresado = Utils.PedirNumero();
            while (numeroIngresado != 0)
            {
                int opcionIngresada = Utils.PedirNumero();
                Random rnd = new Random();
                int rndNumber = rnd.Next(1,10);
                if(rndNumber == opcionIngresada)
                {
                    Console.WriteLine("El numero aleatorio coincide con tu numero ingresado");
                    break;
                }
            }
        }

        static public void Ejercicio2()
        { /*    Solicitar números hasta que ingrese el 0 (fin del ingreso).
                Se debe mostrar la tabla del mismo.
                Ejemplo ingresando el numero 2
                2 x 1 = 2
                2 x 2 = 4
                2 x 3 = 6
                Hasta el 9
           */
            int numeroIngresado = Utils.PedirNumero("Ingrese numero para realizar la tabla.");

            while (numeroIngresado != 0)
            {
                for (int i = 0; i <= 9; i++)
                {
                    int resultado = numeroIngresado * i;
                    Console.WriteLine($"{numeroIngresado} x {i} = {resultado}");

                }
                break;
            }

        }

        static public void Ejercicio3()
        { /*    Solicitar dos números (controlar que el primer número sea menor al segundo) y muestre todos
                los números entre los valores ingresados que sean pares. Para salir se debe ingresar 0.
           */

            int num1 = Utils.PedirNumero("Ingrese un numero --- [0 para salir]");
            if (num1 == 0) return;
            int num2 = Utils.PedirNumero("Ingrese el segundo numero --- [0 para salir]");
            if (num2 == 0) return;

            if (num1 < num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        int par = i;
                        Console.WriteLine($"{par + " "}");

                    }

                }
            }else
            {
                Console.WriteLine("El 2do numero ingresado debe ser mayor al primero.");
                return;
            }
            //} else if(num1 > num2)
            //{
            //    int numAux = num1;
            //    num1 = num2;
            //    num2 = numAux;

                

            //    for (int i = num1; i < num2; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            int par = i;
            //            Console.WriteLine($"{par + " "}");
            //        }

            //    }
            //}

            

        }

        static public void Ejercicio4()
        { /*    Solicitar dos números y un valor, indicar si el valor está comprendido entre los números
           */
            int num1 = Utils.PedirNumero("Ingrese un numero");
            int num2 = Utils.PedirNumero("Ingrese otro numero mas grande");
            int valor = Utils.PedirNumero("Ingrese un valor.");

            if(valor < num2 && valor > num1)
            {
                Console.WriteLine("El valor ingresado está entre los numeros.");
            }
            else
            {
                Console.WriteLine("El valor ingresado NO está entre los numeros.");

            }



        }

        static public void Ejercicio5()
        { /*    Solicitar números hasta que se ingrese el 0. Se debe mostrar la suma de todos ellos.
           */

            bool sigo = false;
            
            int suma = 0;

            while (!sigo)
            {
                int numSuma = Utils.PedirNumero("Ingrese numero a sumar");
                suma += numSuma;
                if (numSuma == 0)
                { 
                    Console.WriteLine($"Total de la suma = {suma}");
                    return;
                }
            }
        }

        static public void Ejercicio6()
        { /*    Ingresar una palabra y mostrar la cantidad de vocales que tiene.
           */
            string palabra = Utils.PedirLetras("Ingrese palabra");
            palabra = palabra.ToLower();
            int cantVocales = 0;

            foreach (Char letra in palabra)
            { 
                if("aeiou".Contains(letra))
                {
                    cantVocales++;
                }
            }
            Console.WriteLine($"La cantidad de vocales de {palabra} = {cantVocales}");
        }

        static public void Ejercicio7()
        { /*    Ingresar una palabra y mostrarla en el otro sentido(Hola -> aloH).
           */
            string palabra = Utils.PedirLetras("Ingrese palabra");
            string palabraInvertida = new String (palabra.Reverse().ToArray());
            Console.WriteLine(palabraInvertida);
        }

        static public void Ejercicio8()
        { /*    Ingresar una palabra e indicar si es palíndromo(somos).
           */

            string palabra = Utils.PedirLetras("Ingrese palabra");
            string palabraInvertida = new String(palabra.Reverse().ToArray());
            if ( palabra == palabraInvertida)
            {
                Console.WriteLine($"{palabra} Es palindromo : {palabraInvertida}");
            }
            else
            {
                Console.WriteLine($" NO es palindromo");
            }
        }
    }
}
