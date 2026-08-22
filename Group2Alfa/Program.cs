using System;

namespace Grupo_Alfa
{
    internal class Program
    {

            // =========================================================
            //                    MENÚ PRINCIPAL
            // =========================================================

            static void MostrarMenu()
            {
                Console.Clear();

                Console.WriteLine("==============================================");
                Console.WriteLine("       PROGRAMACIÓN II - EJERCICIOS");
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.WriteLine(" NIVEL 1 - VARIABLES Y OPERACIONES");
                Console.WriteLine("  1. Bienvenida y nombre");
                Console.WriteLine("  2. Área de un círculo");
                Console.WriteLine("  3. Calcular edad");
                Console.WriteLine("  4. Precio con IVA");
                Console.WriteLine("  5. Operaciones con dos números");
                Console.WriteLine("  6. Promedio de 3 notas");
                Console.WriteLine("  7. Intercambiar variables");
                Console.WriteLine("  8. Celsius a Fahrenheit");
                Console.WriteLine("  9. Minutos a horas y minutos");
                Console.WriteLine(" 10. Residuo de dos números");
                Console.WriteLine();

                Console.WriteLine(" NIVEL 2 - IF / ELSE");
                Console.WriteLine(" 11. Mayor o menor de edad");
                Console.WriteLine(" 12. Par o impar");
                Console.WriteLine(" 13. Mayor de dos números");
                Console.WriteLine(" 14. Positivo o negativo");
                Console.WriteLine(" 15. Nota aprobatoria");
                Console.WriteLine(" 16. Verificar contraseña");
                Console.WriteLine(" 17. Año bisiesto");
                Console.WriteLine(" 18. Descuento del 10%");
                Console.WriteLine(" 19. Divisible exactamente");
                Console.WriteLine(" 20. Horas trabajadas");
                Console.WriteLine();

                Console.WriteLine(" NIVEL 3 - CONDICIONALES MÚLTIPLES");
                Console.WriteLine(" 21. Positivo, negativo o cero");
                Console.WriteLine(" 22. Mayor de tres números");
                Console.WriteLine(" 23. Nota numérica a letra");
                Console.WriteLine(" 24. Etapa de vida");
                Console.WriteLine(" 25. Calculadora");
                Console.WriteLine(" 26. Día de la semana");
                Console.WriteLine(" 27. Índice de Masa Corporal");
                Console.WriteLine(" 28. Sistema de peaje");
                Console.WriteLine(" 29. Tipo de triángulo");
                Console.WriteLine(" 30. Semáforo");
                Console.WriteLine();

                Console.WriteLine(" NIVEL 4 - FUNCIONES, TUPLAS Y CLASES");
                Console.WriteLine(" 31. Método Saludar");
                Console.WriteLine(" 32. Función EsPar");
                Console.WriteLine(" 33. Función CalcularMayor");
                Console.WriteLine(" 34. División con validación");
                Console.WriteLine(" 35. Tupla de coordenadas");
                Console.WriteLine(" 36. Datos de usuario con tupla");
                Console.WriteLine(" 37. Clase Calculadora");
                Console.WriteLine(" 38. TryParse");
                Console.WriteLine(" 39. Salario con tupla");
                Console.WriteLine(" 40. Menú interactivo");
                Console.WriteLine();

                Console.WriteLine("  0. SALIR");
                Console.WriteLine("==============================================");
                Console.Write("Seleccione un ejercicio: ");
            }


            // =========================================================
            //                    EJERCICIOS 1 - 10
            // =========================================================

            // EJERCICIO 01
            static void Ejercicio01()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 01 =====");

                string nombre = "Americo";

                Console.WriteLine("Bienvenido a Programación II");
                Console.WriteLine("Mi nombre es: " + nombre);
            }


            // EJERCICIO 02
            static void Ejercicio02()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 02 =====");

                const double PI = 3.14159;

                Console.Write("Ingrese el radio del círculo: ");
                double radio = double.Parse(Console.ReadLine());

                double area = PI * radio * radio;

                Console.WriteLine("El área del círculo es: " + area);
            }


            // EJERCICIO 03
            static void Ejercicio03()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 03 =====");

                Console.Write("Ingrese su año de nacimiento: ");
                int nacimiento = int.Parse(Console.ReadLine());

                int añoActual = 2026;
                int edad = añoActual - nacimiento;

                Console.WriteLine("Su edad aproximada es: " + edad + " años.");
            }


            // EJERCICIO 04
            static void Ejercicio04()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 04 =====");

                const double IVA = 0.13;

                Console.Write("Ingrese el precio del producto: ");
                double precio = double.Parse(Console.ReadLine());

                double impuesto = precio * IVA;
                double precioFinal = precio + impuesto;

                Console.WriteLine("IVA: " + impuesto);
                Console.WriteLine("Precio final: " + precioFinal);
            }


            // EJERCICIO 05
            static void Ejercicio05()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 05 =====");

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Suma: " + (numero1 + numero2));
                Console.WriteLine("Resta: " + (numero1 - numero2));
                Console.WriteLine("Multiplicación: " + (numero1 * numero2));

                if (numero2 != 0)
                {
                    Console.WriteLine("División: " + (numero1 / numero2));
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
            }


            // EJERCICIO 06
            static void Ejercicio06()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 06 =====");

                Console.Write("Ingrese la primera nota: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la tercera nota: ");
                double nota3 = double.Parse(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("El promedio final es: " + promedio);
            }


            // EJERCICIO 07
            static void Ejercicio07()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 07 =====");

                int a = 5;
                int b = 10;

                Console.WriteLine("Antes del intercambio:");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);

                int temporal = a;
                a = b;
                b = temporal;

                Console.WriteLine();
                Console.WriteLine("Después del intercambio:");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
            }


            // EJERCICIO 08
            static void Ejercicio08()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 08 =====");

                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit);
            }


            // EJERCICIO 09
            static void Ejercicio09()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 09 =====");

                Console.Write("Ingrese una cantidad de minutos: ");
                int minutos = int.Parse(Console.ReadLine());

                int horas = minutos / 60;
                int minutosRestantes = minutos % 60;

                Console.WriteLine("Horas: " + horas);
                Console.WriteLine("Minutos: " + minutosRestantes);
            }


            // EJERCICIO 10
            static void Ejercicio10()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 10 =====");

                Console.Write("Ingrese el primer número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                if (numero2 != 0)
                {
                    int residuo = numero1 % numero2;

                    Console.WriteLine("El residuo es: " + residuo);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
            }


            // =========================================================
            //                    EJERCICIOS 11 - 20
            // =========================================================

            // EJERCICIO 11
            static void Ejercicio11()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 11 =====");

                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Es menor de edad.");
                }
            }


            // EJERCICIO 12
            static void Ejercicio12()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 12 =====");

                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }


            // EJERCICIO 13
            static void Ejercicio13()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 13 =====");

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                if (numero1 > numero2)
                {
                    Console.WriteLine("El mayor es: " + numero1);
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine("El mayor es: " + numero2);
                }
                else
                {
                    Console.WriteLine("Los dos números son iguales.");
                }
            }


            // EJERCICIO 14
            static void Ejercicio14()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 14 =====");

                Console.Write("Ingrese un número: ");
                double numero = double.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }
            }


            // EJERCICIO 15
            static void Ejercicio15()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 15 =====");

                Console.Write("Ingrese la nota final (1 - 100): ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 51)
                {
                    Console.WriteLine("Aprobado.");
                }
                else
                {
                    Console.WriteLine("Reprobado.");
                }
            }


            // EJERCICIO 16
            static void Ejercicio16()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 16 =====");

                const string CLAVE_CORRECTA = "1234";

                Console.Write("Ingrese la contraseña: ");
                string clave = Console.ReadLine();

                if (clave == CLAVE_CORRECTA)
                {
                    Console.WriteLine("Acceso permitido");
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }


            // EJERCICIO 17
            static void Ejercicio17()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 17 =====");

                Console.Write("Ingrese un año: ");
                int año = int.Parse(Console.ReadLine());

                if (año % 4 == 0)
                {
                    Console.WriteLine("Es un año bisiesto.");
                }
                else
                {
                    Console.WriteLine("No es un año bisiesto.");
                }
            }


            // EJERCICIO 18
            static void Ejercicio18()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 18 =====");

                const double DESCUENTO = 0.10;

                Console.Write("Ingrese el monto de la compra: ");
                double compra = double.Parse(Console.ReadLine());

                if (compra > 100)
                {
                    double descuento = compra * DESCUENTO;
                    double precioFinal = compra - descuento;

                    Console.WriteLine("Descuento: " + descuento);
                    Console.WriteLine("Precio final: " + precioFinal);
                }
                else
                {
                    Console.WriteLine("Precio original: " + compra);
                }
            }


            // EJERCICIO 19
            static void Ejercicio19()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 19 =====");

                Console.Write("Ingrese el primer número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                if (numero2 != 0)
                {
                    if (numero1 % numero2 == 0)
                    {
                        Console.WriteLine("El primer número es divisible exactamente entre el segundo.");
                    }
                    else
                    {
                        Console.WriteLine("No es divisible exactamente.");
                    }
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
            }


            // EJERCICIO 20
            static void Ejercicio20()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 20 =====");

                Console.Write("Ingrese las horas trabajadas: ");
                int horas = int.Parse(Console.ReadLine());

                if (horas > 40)
                {
                    Console.WriteLine("Tiene horas extra.");
                }
                else
                {
                    Console.WriteLine("Jornada normal.");
                }
            }


            // =========================================================
            //                    EJERCICIOS 21 - 30
            // =========================================================

            // EJERCICIO 21
            static void Ejercicio21()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 21 =====");

                Console.Write("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("Positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Negativo");
                }
                else
                {
                    Console.WriteLine("Cero");
                }
            }


            // EJERCICIO 22
            static void Ejercicio22()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 22 =====");

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                double numero3 = double.Parse(Console.ReadLine());

                if (numero1 >= numero2 && numero1 >= numero3)
                {
                    Console.WriteLine("El mayor es: " + numero1);
                }
                else if (numero2 >= numero1 && numero2 >= numero3)
                {
                    Console.WriteLine("El mayor es: " + numero2);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + numero3);
                }
            }


            // EJERCICIO 23
            static void Ejercicio23()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 23 =====");

                Console.Write("Ingrese una nota de 0 a 100: ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 90 && nota <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (nota >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (nota >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (nota >= 60)
                {
                    Console.WriteLine("D");
                }
                else if (nota >= 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("Nota inválida.");
                }
            }


            // EJERCICIO 24
            static void Ejercicio24()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 24 =====");

                Console.Write("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 0 && edad <= 12)
                {
                    Console.WriteLine("Niño");
                }
                else if (edad >= 13 && edad <= 17)
                {
                    Console.WriteLine("Adolescente");
                }
                else if (edad >= 18 && edad <= 64)
                {
                    Console.WriteLine("Adulto");
                }
                else if (edad >= 65)
                {
                    Console.WriteLine("Adulto mayor");
                }
                else
                {
                    Console.WriteLine("Edad inválida.");
                }
            }


            // EJERCICIO 25
            static void Ejercicio25()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 25 =====");

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.Write("Elija una operación: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Resultado: " + (numero1 + numero2));
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Resultado: " + (numero1 - numero2));
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Resultado: " + (numero1 * numero2));
                }
                else if (opcion == 4)
                {
                    if (numero2 != 0)
                    {
                        Console.WriteLine("Resultado: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
            }


            // EJERCICIO 26
            static void Ejercicio26()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 26 =====");

                Console.Write("Ingrese un número del 1 al 7: ");
                int dia = int.Parse(Console.ReadLine());

                if (dia == 1)
                {
                    Console.WriteLine("Lunes");
                }
                else if (dia == 2)
                {
                    Console.WriteLine("Martes");
                }
                else if (dia == 3)
                {
                    Console.WriteLine("Miércoles");
                }
                else if (dia == 4)
                {
                    Console.WriteLine("Jueves");
                }
                else if (dia == 5)
                {
                    Console.WriteLine("Viernes");
                }
                else if (dia == 6)
                {
                    Console.WriteLine("Sábado");
                }
                else if (dia == 7)
                {
                    Console.WriteLine("Domingo");
                }
                else
                {
                    Console.WriteLine("Error: número inválido.");
                }
            }


            // EJERCICIO 27
            static void Ejercicio27()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 27 =====");

                Console.Write("Ingrese su peso en kg: ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Ingrese su estatura en metros: ");
                double estatura = double.Parse(Console.ReadLine());

                double imc = peso / (estatura * estatura);

                Console.WriteLine("Su IMC es: " + imc);

                if (imc < 18.5)
                {
                    Console.WriteLine("Bajo peso");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("Normal");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Obesidad");
                }
            }


            // EJERCICIO 28
            static void Ejercicio28()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 28 =====");

                Console.WriteLine("1. Moto - $2");
                Console.WriteLine("2. Auto - $5");
                Console.WriteLine("3. Autobús - $10");
                Console.WriteLine("4. Camión - $15");

                Console.Write("Seleccione el tipo de vehículo: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Debe pagar $2");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Debe pagar $5");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Debe pagar $10");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Debe pagar $15");
                }
                else
                {
                    Console.WriteLine("Vehículo inválido.");
                }
            }


            // EJERCICIO 29
            static void Ejercicio29()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 29 =====");

                Console.Write("Ingrese el lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado 3: ");
                double lado3 = double.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triángulo Equilátero");
                }
                else if (lado1 == lado2 ||
                         lado1 == lado3 ||
                         lado2 == lado3)
                {
                    Console.WriteLine("Triángulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triángulo Escaleno");
                }
            }


            // EJERCICIO 30
            static void Ejercicio30()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 30 =====");

                Console.Write("Ingrese el color del semáforo: ");
                string color = Console.ReadLine().ToLower();

                if (color == "rojo")
                {
                    Console.WriteLine("Detenerse");
                }
                else if (color == "amarillo")
                {
                    Console.WriteLine("Precaución");
                }
                else if (color == "verde")
                {
                    Console.WriteLine("Avanzar");
                }
                else
                {
                    Console.WriteLine("Color inválido.");
                }
            }


            // =========================================================
            //                    EJERCICIOS 31 - 40
            // =========================================================

            // EJERCICIO 31
            static void Saludar(string nombre)
            {
                Console.WriteLine("Hola " + nombre + ", bienvenido a C#");
            }

            static void Ejercicio31()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 31 =====");

                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Saludar(nombre);
            }


            // EJERCICIO 32
            static bool EsPar(int numero)
            {
                return numero % 2 == 0;
            }

            static void Ejercicio32()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 32 =====");

                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (EsPar(numero))
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }


            // EJERCICIO 33
            static double CalcularMayor(double n1, double n2)
            {
                if (n1 > n2)
                {
                    return n1;
                }
                else
                {
                    return n2;
                }
            }

            static void Ejercicio33()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 33 =====");

                Console.Write("Ingrese el primer número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                double mayor = CalcularMayor(n1, n2);

                Console.WriteLine("El número mayor es: " + mayor);
            }


            // EJERCICIO 34
            static double Dividir(double numero1, double numero2)
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                    return 0;
                }

                return numero1 / numero2;
            }

            static void Ejercicio34()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 34 =====");

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el divisor: ");
                double numero2 = double.Parse(Console.ReadLine());

                if (numero2 != 0)
                {
                    double resultado = Dividir(numero1, numero2);
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Dividir(numero1, numero2);
                }
            }


            // EJERCICIO 35
            static (double x, double y) PedirCoordenadas()
            {
                Console.Write("Ingrese X: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Ingrese Y: ");
                double y = double.Parse(Console.ReadLine());

                return (x, y);
            }

            static void Ejercicio35()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 35 =====");

                var coordenadas = PedirCoordenadas();

                Console.WriteLine("X = " + coordenadas.x);
                Console.WriteLine("Y = " + coordenadas.y);
            }


            // EJERCICIO 36
            static (string nombre, int edad, string cargo) ObtenerDatosUsuario()
            {
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese su cargo: ");
                string cargo = Console.ReadLine();

                return (nombre, edad, cargo);
            }

            static void Ejercicio36()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 36 =====");

                var datos = ObtenerDatosUsuario();

                Console.WriteLine();
                Console.WriteLine("Nombre: " + datos.nombre);
                Console.WriteLine("Edad: " + datos.edad);
                Console.WriteLine("Cargo: " + datos.cargo);
            }


            // =========================================================
            // EJERCICIO 37 - CLASE CALCULADORA
            // =========================================================

            static void Ejercicio37()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 37 =====");

                Calculadora calculadora = new Calculadora();

                Console.Write("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Suma: " +
                    calculadora.Sumar(numero1, numero2));

                Console.WriteLine("Resta: " +
                    calculadora.Restar(numero1, numero2));

                Console.WriteLine("Multiplicación: " +
                    calculadora.Multiplicar(numero1, numero2));

                Console.WriteLine("División: " +
                    calculadora.Dividir(numero1, numero2));
            }


            // EJERCICIO 38
            static void Ejercicio38()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 38 =====");

                Console.Write("Ingrese un número: ");
                string entrada = Console.ReadLine();

                double numero;

                if (double.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Número ingresado: " + numero);
                }
                else
                {
                    Console.WriteLine("Error: debe ingresar un número válido.");
                }
            }


            // EJERCICIO 39
            static (double SalarioBruto,
                    double DescuentoSeguro,
                    double SalarioNeto)
                CalcularSalario(double salarioBruto)
            {
                const double PORCENTAJE_SEGURO = 0.10;

                double descuentoSeguro =
                    salarioBruto * PORCENTAJE_SEGURO;

                double salarioNeto =
                    salarioBruto - descuentoSeguro;

                return
                (
                    salarioBruto,
                    descuentoSeguro,
                    salarioNeto
                );
            }

            static void Ejercicio39()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 39 =====");

                Console.Write("Ingrese el salario bruto: ");
                double salario = double.Parse(Console.ReadLine());

                var resultado = CalcularSalario(salario);

                Console.WriteLine();
                Console.WriteLine("Salario bruto: " +
                    resultado.SalarioBruto);

                Console.WriteLine("Descuento seguro: " +
                    resultado.DescuentoSeguro);

                Console.WriteLine("Salario neto: " +
                    resultado.SalarioNeto);
            }


            // =========================================================
            // EJERCICIO 40 - MENÚ INTERACTIVO
            // =========================================================

            static void CalcularAreaTriangulo()
            {
                Console.Write("Ingrese la base: ");
                double baseTriangulo =
                    double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura: ");
                double altura =
                    double.Parse(Console.ReadLine());

                double area =
                    (baseTriangulo * altura) / 2;

                Console.WriteLine("El área del triángulo es: " + area);
            }

            static void VerificarPar()
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }

            static void MayorDeTres()
            {
                Console.Write("Ingrese el primer número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                double n3 = double.Parse(Console.ReadLine());

                double mayor;

                if (n1 >= n2 && n1 >= n3)
                {
                    mayor = n1;
                }
                else if (n2 >= n1 && n2 >= n3)
                {
                    mayor = n2;
                }
                else
                {
                    mayor = n3;
                }

                Console.WriteLine("El número mayor es: " + mayor);
            }

            static void Ejercicio40()
            {
                Console.Clear();
                Console.WriteLine("===== EJERCICIO 40 =====");

                int opcion;

                do
                {
                    Console.Clear();

                    Console.WriteLine("=================================");
                    Console.WriteLine("       MENÚ DEL EJERCICIO 40");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1. Calcular área de triángulo");
                    Console.WriteLine("2. Verificar si un número es par");
                    Console.WriteLine("3. Determinar mayor de 3 números");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("=================================");
                    Console.Write("Seleccione una opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (opcion == 1)
                    {
                        CalcularAreaTriangulo();
                    }
                    else if (opcion == 2)
                    {
                        VerificarPar();
                    }
                    else if (opcion == 3)
                    {
                        MayorDeTres();
                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Saliendo del ejercicio 40...");
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }

                    if (opcion != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }

                } while (opcion != 4);
            }


            // =========================================================
            //                  MÉTODO PRINCIPAL
            // =========================================================

            static void Main()
            {
                int opcion;

                do
                {
                    MostrarMenu();

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Ejercicio01();
                            break;

                        case 2:
                            Ejercicio02();
                            break;

                        case 3:
                            Ejercicio03();
                            break;

                        case 4:
                            Ejercicio04();
                            break;

                        case 5:
                            Ejercicio05();
                            break;

                        case 6:
                            Ejercicio06();
                            break;

                        case 7:
                            Ejercicio07();
                            break;

                        case 8:
                            Ejercicio08();
                            break;

                        case 9:
                            Ejercicio09();
                            break;

                        case 10:
                            Ejercicio10();
                            break;

                        case 11:
                            Ejercicio11();
                            break;

                        case 12:
                            Ejercicio12();
                            break;

                        case 13:
                            Ejercicio13();
                            break;

                        case 14:
                            Ejercicio14();
                            break;

                        case 15:
                            Ejercicio15();
                            break;

                        case 16:
                            Ejercicio16();
                            break;

                        case 17:
                            Ejercicio17();
                            break;

                        case 18:
                            Ejercicio18();
                            break;

                        case 19:
                            Ejercicio19();
                            break;

                        case 20:
                            Ejercicio20();
                            break;

                        case 21:
                            Ejercicio21();
                            break;

                        case 22:
                            Ejercicio22();
                            break;

                        case 23:
                            Ejercicio23();
                            break;

                        case 24:
                            Ejercicio24();
                            break;

                        case 25:
                            Ejercicio25();
                            break;

                        case 26:
                            Ejercicio26();
                            break;

                        case 27:
                            Ejercicio27();
                            break;

                        case 28:
                            Ejercicio28();
                            break;

                        case 29:
                            Ejercicio29();
                            break;

                        case 30:
                            Ejercicio30();
                            break;

                        case 31:
                            Ejercicio31();
                            break;

                        case 32:
                            Ejercicio32();
                            break;

                        case 33:
                            Ejercicio33();
                            break;

                        case 34:
                            Ejercicio34();
                            break;

                        case 35:
                            Ejercicio35();
                            break;

                        case 36:
                            Ejercicio36();
                            break;

                        case 37:
                            Ejercicio37();
                            break;

                        case 38:
                            Ejercicio38();
                            break;

                        case 39:
                            Ejercicio39();
                            break;

                        case 40:
                            Ejercicio40();
                            break;

                        case 0:
                            Console.Clear();
                            Console.WriteLine("=================================");
                            Console.WriteLine("   PROGRAMA FINALIZADO");
                            Console.WriteLine("=================================");
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Opción inválida.");
                            break;
                    }

                    if (opcion != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Presione ENTER para volver al menú...");
                        Console.ReadLine();
                    }

                } while (opcion != 0);
            }
        }


        // =========================================================
        //                 CLASE CALCULADORA
        //                 EJERCICIO 37
        // =========================================================

        public class Calculadora
        {
            public double Sumar(double a, double b)
            {
                return a + b;
            }

            public double Restar(double a, double b)
            {
                return a - b;
            }

            public double Multiplicar(double a, double b)
            {
                return a * b;
            }

            public double Dividir(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return 0;
                }

                return a / b;
            }
    }
}
