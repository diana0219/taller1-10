using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios1_10
{
	class Program

	{
		static Validaciones Validar = new Validaciones();

		static void Main(string[] args)
		{

			int opcion;
			string temporal;
			bool EntValida = false;
			do
			{
				Console.SetCursorPosition(30, 10); Console.WriteLine("Bienvenido");
				Console.SetCursorPosition(30, 12); Console.WriteLine("1.Definir si es par o impar ");
				Console.SetCursorPosition(30, 14); Console.WriteLine("2.Mostrar la tabla de multiplicar del número ingresado ");
				Console.SetCursorPosition(30, 16); Console.WriteLine("3.Tablas de multiplicar del 2 al 9");
				Console.SetCursorPosition(30, 18); Console.WriteLine("4.Definir si un numero es primo");
				Console.SetCursorPosition(30, 20); Console.WriteLine("5.Ordenar en forma ascendente los vectores");
				Console.SetCursorPosition(30, 22); Console.WriteLine("6.Definir si existe o no un dato");
				Console.SetCursorPosition(30, 24); Console.WriteLine("7.Buscar el numero mayor y menor");
				Console.SetCursorPosition(30, 26); Console.WriteLine("8.Definir si es palindromo o no");
				Console.SetCursorPosition(30, 28); Console.WriteLine("9.Mostrar la serie del algoritmo de Fibonacci");
				Console.SetCursorPosition(30, 30); Console.WriteLine("0. para salir");
				opcion = int.Parse(Console.ReadLine());


				do
				{
					Console.WriteLine("Digite una opcion");
					temporal = Console.ReadLine();
					if (!Validar.Vacio(temporal))
						if (Validar.TipoNumero(temporal))
							EntValida = true;

				} while (!EntValida);




				switch (opcion)
				{
					case 1:
						Numero_par_o_impar();
						break;
					case 2:
						Tabla_multipl_no();
						break;
					case 3:
						Tablas_multipl();
						break;
					case 4:
						Numero_primo();
						break;
					case 5:
						ImprimirVector();
						break;
					case 6:
						ExisteDato();
						break;
					case 7:
						Mayor_menor();
						break;
					case 8:
						Palindromo();
						break;
					case 9:
						Algoritmo_Fibonacci();
						break;



					case 0:
						Console.WriteLine(" gracias por usar el aplicativo");
						Console.WriteLine(" ******************************");
						Console.ReadKey();
						break;
				}
			} while (opcion != 0);
		}




		static void Numero_par_o_impar()

		{
			Console.Clear();
			int number = 0;
			Console.Clear();
			Console.WriteLine("Ingrese un numero");
			number = int.Parse(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.WriteLine("El numero es par");

			}
			else
			{
				Console.WriteLine("El numero es impar");
			}
			Console.ReadLine();

		}

		static void Tabla_multipl_no()
		{
			Console.Clear();

			int number = 0;

			Console.WriteLine("Introduce un número:");
			number = int.Parse(Console.ReadLine());

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(number + "x" + i + "=" + (i * number));
			}
			Console.ReadLine();
			Console.Clear();

		}

		static void Tablas_multipl()

		{

			Console.Clear();
			int a, b;
			for (a = 2; a <= 9; a++)
			{
				Console.WriteLine("           Tabla " + a + "               ");
				for (b = 1; b <= 10; b++)
				{
					Console.Write("            " + a + " x " + b + " = " + a * b + "      " + "\n");

				}
			}
			Console.Clear();

		}
		static void Numero_primo()
		{

			Console.Clear();


			Console.Write("Escriba un número mayor que 1: ");
			string leerlineauno = Console.ReadLine();
			int convertirenterouno = int.Parse(leerlineauno);

			int contador = 0;
			// Un número entero mayor que 1 es primo si es divisible únicamente por 1 y por sí mismo.
			if (convertirenterouno < 1)
			{
				Console.WriteLine("¡Le he pedido un número entero mayor que 1!");
			}

			for (int i = 1; i <= convertirenterouno; i++)
			{

				int numero = convertirenterouno % i;



				if (numero == 0)
				{
					contador = contador + 1;
				}

				if (contador > 2)
				{
					Console.WriteLine("NO es primo");
					return;
				}
				if (convertirenterouno == i && contador <= 2)
				{


					Console.WriteLine("Es primo");
					return;

				}
			}
			Console.Clear();

		}

		static void ImprimirVector()
		{
			Console.Clear();

			int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
			int Aux;

			ImprimirVector(edad, "Orginal");


			for (int ciclo = 1; ciclo <= edad.Length; ciclo++)
			{

				for (int i = 0; i < edad.Length - ciclo; i++)
				{
					if (edad[i] < edad[i + 1])
					{
						Aux = edad[i];
						edad[i] = edad[i + 1];
						edad[i + 1] = Aux;
					}
				}

			}

			ImprimirVector(edad, "Ordenado");

			Console.WriteLine("\n presione cualquier tecla para continuar");
			Console.ReadKey();

		}

		static void ImprimirVector(Array vector, string titulo)
		{
			Console.WriteLine("\n Arreglo " + titulo);

			foreach (int elemento in vector)
			{
				Console.Write("[ " + elemento + " ] ");
			}
			Console.Clear();

		}

		static void ExisteDato()
		{
			Console.Clear();
			string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
			string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
			Console.Clear();
			string nombreBuscar;
			bool existe = false;
			int posicion = 0;

			Console.Clear();

			ExisteDato(edad, " Edades");
			ExisteDato(nombre, "Nombres");

			Console.WriteLine("Digite El nombre a buscar");
			nombreBuscar = Console.ReadLine();

			for (int i = 0; i < nombre.Length; i++)
			{
				if (nombre[i] == nombreBuscar)
				{
					existe = true;
					posicion = i;
				}
			}

			if (existe)
			{
				Console.WriteLine(" El Usuario " + nombreBuscar + " Existe y tiene " + edad[posicion] + " Anos de edad");
			}
			else
			{
				Console.WriteLine(" El Usuario " + nombreBuscar + " No Existe");
			}

			Console.WriteLine("\n presiones cualquier tecla para continuar");
			Console.ReadKey();

		}

		static void ExisteDato(Array vector, string titulo)
		{
			Console.WriteLine("\n Arreglo " + titulo);

			foreach (string elemento in vector)
			{
				Console.Write("[ " + elemento + " ] ");
			}
			Console.WriteLine("\n");
			Console.Clear();
				

		}

		static void Mayor_menor()

		{
			Console.Clear();


			int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
			string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
			int em = 0, emn = 100, pm = 0, pmn = 0;
			for (int i = 0; i < edad.Length; i++)
			{
				if (edad[i] > em)
				{
					em = edad[i];
					pm = i;
				}
				if (edad[i] < emn)
				{
					emn = edad[i];
					pmn = i;
				}
			}

			Console.WriteLine("Persona mayor es : " + nombres[pm] + " Edad : " + em + " años  ");
			Console.WriteLine("Persona menor es : " + nombres[pmn] + " Edad : " + emn + " años  ");


		}


		static void Palindromo()
		{
			Console.Clear();
			string palabra, inverso, caracter;

			int i;

			Console.WriteLine("palabra que desea invertir");
			palabra = Convert.ToString(Console.ReadLine());

			i = palabra.Length;
			inverso = "";
			for (int x = i = 1; x >= 0; x = i++)
			{
				caracter = palabra.Substring(x, 1);

				inverso = inverso + caracter;

			}
			if (palabra == inverso)
			{
				Console.WriteLine("ES PALINDROMIE");
			}
			else
			{
				Console.WriteLine("NO ES PALINDROMIE");
			}

			Console.ReadKey();

		}


		static void Algoritmo_Fibonacci()
		{
			Console.Clear();
			byte cant;
			int a = 0, b = 1, c;



			string aux;
			Console.WriteLine("Cuantos numeros FIBONACCI desea generar?...");

			aux = Console.ReadLine();
			cant = byte.Parse(aux);

			Console.Write("LA SERIE ES:" + a + " " + b + " ");

			for (int i = 3; i <= cant; i++)
			{
				c = a + b;
				Console.Write(c + " ");
				a = b;
				b = c;

			}
			Console.WriteLine();
			Console.Write("PRESIONE UNA TECLA PARA SALIR...");
			Console.ReadKey();
		}




	}

}


