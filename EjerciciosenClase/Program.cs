//int x = 2;                           ENUNCIADO 1
//while (x <= 10)
//{
//    Console.WriteLine(x);
//    x = x + 2;
//
//}


//int x = 1;
//int suma = 0;
//while (x <= 10)
//{
//    suma += x;
//    Console.WriteLine(x);
//    x++; //para que no se cree un bucle
//}
//Console.WriteLine("La suma de los primeros 10 numeros naturales es: " + suma);


//int numero;                            ENUNCIADO 2
//int suma = 0;
//do
//{
//    Console.WriteLine("Ingrese un numero entero");
//    int.TryParse(Console.ReadLine(), out numero);
//    if (numero >= 0)
//    {
//        suma += numero;
//    }
//}
//while (numero >= 0);
//{
//    Console.WriteLine("La suma de los numeros es: " + suma);
//} 


//while (true)
//{
//    Console.Write("Por favor, ingresa un número: ");
//    int numero = int.Parse(Console.ReadLine());

//    if (numero % 7 == 0 && numero % 11 == 0)
//    {
//        Console.WriteLine("¡El número es divisible entre 7 y 11! Cerrando el programa.");
//        break;
//    }
//}

//string contrasena = "jutiapa";                          ENUNCIADO 3
//string ingreso;

//do
//{
//    Console.WriteLine("Ingrese la contrasena: ");
//    ingreso = Console.ReadLine();
//}
//while (ingreso != contrasena);
//Console.WriteLine("CONTRASENA INCORRECTA!!");


