using System;

public class GestionEmpleados
{
    //Metodo para añadir empleado dependiendo de su tipo
    public void AñadirEmpleado(List<Empleado> lista_de_empleados)
    {
        int opcion;

        do
        {
            Console.WriteLine("*___________________________________*");
            Console.WriteLine("|Ingrese su Tipo de contracto:      |");
            Console.WriteLine("|1) Empleado Asalariado por Comision|\n" +
                "|2) Empleado Asalariado             |\n" +
                "|3) Empleado por Comision           |\n" +
                "|4) Empleado por horas              |\n" +
                "|5) Salir                           |");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese su salario Base:");
                    decimal salarioBase = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de ventas realizadas:");
                    int cantidadVentas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tarifa que cobra por comision:");
                    decimal tarifa = decimal.Parse(Console.ReadLine());

                    (var nombre, var apellido, var numerosegurosocial) = AñadirDatosBaseEmpleado();

                    lista_de_empleados.Add(new EmpleadoAsalariadoPorComision(nombre, apellido, numerosegurosocial, salarioBase, cantidadVentas, tarifa));

                    return;
                case 2:
                    Console.WriteLine("Ingrese su salario Semanal");
                    decimal salario = decimal.Parse(Console.ReadLine());


                    (var nombre1, var apellido1, var numerosegurosocial1) = AñadirDatosBaseEmpleado();

                    lista_de_empleados.Add(new EmpleadoAsalariado(nombre1, apellido1, numerosegurosocial1, salario));

                    return;

                case 3:
                    Console.WriteLine("Ingrese la cantidad de ventas realizadas:");
                    int cantidadVentas1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tarifa que cobra por comision:");
                    decimal tarifa1 = decimal.Parse(Console.ReadLine());

                    (var nombre2, var apellido2, var numerosegurosocial2) = AñadirDatosBaseEmpleado();

                    lista_de_empleados.Add(new EmpleadoPorComision(nombre2, apellido2, numerosegurosocial2, cantidadVentas1, tarifa1));

                    return;

                case 4:
                    Console.WriteLine("Ingresa la cantidad de horas trabajadas esta semana:");
                    int cantidadHoras = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo ganado por hora:");
                    decimal sueldoHora = decimal.Parse(Console.ReadLine());

                    (var nombre3, var apellido3, var numerosegurosocial3) = AñadirDatosBaseEmpleado();

                    lista_de_empleados.Add(new EmpleadoPorHoras(nombre3, apellido3, numerosegurosocial3, cantidadHoras, sueldoHora));
                    return;

                case 5:

                    return;

                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Intente nuevamente.");
                    return;
            }
        } while (opcion != 5);
    }

    //Metodo base para no repetir el mismo formato de datos al ingresar cliente
    static (string, string, string) AñadirDatosBaseEmpleado()
    {
        Console.WriteLine("Ingrese su Primer Nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su primer Apellido:");
        string apellido = Console.ReadLine();
        Console.WriteLine("ingrese su numero de seguro social: ");
        string numeroseguro = Console.ReadLine();

        return (nombre, apellido, numeroseguro);
    }
        

    // Metodo para actualizar empleado
    public void ActualizarDatosEmpleado(List<Empleado> lista_de_empleados)
        {
            int numero;
            Console.WriteLine("Lista de empleados:");
            for (int i = 0; i < lista_de_empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {lista_de_empleados[i].PrimerNombre}");
            }

            Console.WriteLine("Ingresa el numero de empleado a modificar:");
            numero = int.Parse(Console.ReadLine());
            numero--;


            for (int i = 0; i < lista_de_empleados.Count; i++)
            {
                if (i == numero)
                {
                    if (lista_de_empleados[i] is EmpleadoAsalariadoPorComision empAsaPorCom)
                    {
                        Console.WriteLine("Deja en campo en blanco, si no desea actualizar");
                        (string n, string a, string e) = AñadirDatosBaseEmpleado();

                        empAsaPorCom.PrimerNombre = n;
                        empAsaPorCom.ApellidoPaterno = a;
                        empAsaPorCom.NumeroSeguroSocial = e;


                        Console.WriteLine("Ingrese su nuevo salario Base:");
                        decimal salarioBase;
                        while (!decimal.TryParse(Console.ReadLine(), out salarioBase))
                        {
                            Console.WriteLine("Valor inválido. Intente de nuevo:");
                        }
                        empAsaPorCom.SalarioBase = salarioBase;

                        Console.WriteLine("Ingrese la nueva cantidad de ventas realizadas");
                        int ventas;
                        while (!int.TryParse(Console.ReadLine(), out ventas))
                        {
                            Console.WriteLine("Valor inválido. Intente de nuevo:");
                        }
                        empAsaPorCom.VentasBrutas = ventas;

                        Console.WriteLine("Ingrese la nueva tarifa que cobra por comisión");
                        decimal tarifa;
                        while (!decimal.TryParse(Console.ReadLine(), out tarifa))
                        {
                            Console.WriteLine("Valor inválido. Intente de nuevo:");
                        }
                        empAsaPorCom.TarifaComision = tarifa;

                        Console.WriteLine("Datos actualizados");
                    }

                    if (lista_de_empleados[i] is EmpleadoAsalariado empAsal)
                    {
                        Console.WriteLine("Deja en campo en blanco, si no desea actualizarlo");
                        (string n, string a, string e) = AñadirDatosBaseEmpleado();

                        empAsal.PrimerNombre = n;
                        empAsal.ApellidoPaterno = a;
                        empAsal.NumeroSeguroSocial = e;

                        Console.WriteLine("Ingrese su nuevo salario Semanal:");
                        decimal salario;
                        while (!decimal.TryParse(Console.ReadLine(), out salario))
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número válido:");
                        }

                        empAsal.SalarioSemanal = salario;
                        Console.WriteLine("Datos actualizados");

                    }

                    if (lista_de_empleados[i] is EmpleadoPorComision empPorCom)
                    {
                        Console.WriteLine("Deja en campo en blanco, si no desea actualizarlo");
                        (string n, string a, string e) = AñadirDatosBaseEmpleado();

                        empPorCom.PrimerNombre = n;
                        empPorCom.ApellidoPaterno = a;
                        empPorCom.NumeroSeguroSocial = e;

                        Console.WriteLine("Ingrese la nueva cantidad de ventas realizadas");
                        int ventas;
                        while (!int.TryParse(Console.ReadLine(), out ventas))
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número:");
                        }
                        empPorCom.VentasBrutas = ventas;

                        Console.WriteLine("Ingrese la nueva tarifa que cobra por comisión");
                        decimal tarifa;
                        while (!decimal.TryParse(Console.ReadLine(), out tarifa))
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número decimal:");
                        }
                        empPorCom.TarifaComision = tarifa;

                        Console.WriteLine("Datos actualizados");

                    }

                    if (lista_de_empleados[i] is EmpleadoPorHoras empPorhor)
                    {
                        Console.WriteLine("Deja en campo en blanco, si no desea actualizarlo");
                        (string n, string a, string e) = AñadirDatosBaseEmpleado();
                        empPorhor.PrimerNombre = n;
                        empPorhor.ApellidoPaterno = a;
                        empPorhor.NumeroSeguroSocial = e;

                        Console.WriteLine("Ingresa la nueva cantidad de horas trabajadas esta semana");
                        int horas;
                        while (!int.TryParse(Console.ReadLine(), out horas))
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número entero:");
                        }
                        empPorhor.HorasTrabajadas = horas;

                        Console.WriteLine("Ingrese el nuevo sueldo ganado por hora");
                        decimal sueldo;
                        while (!decimal.TryParse(Console.ReadLine(), out sueldo))
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número decimal:");
                        }
                        empPorhor.SueldoPorHora = sueldo;

                        Console.WriteLine("Datos actualizados");
                    }

                }
                else
                {
                    Console.WriteLine("Opcion invalida ");
                }
            }

        }
}