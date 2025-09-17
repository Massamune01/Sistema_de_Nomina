namespace Sistema_de_Nomina;

class Program
{
    static void Main(string[] args)
    {
        GestionEmpleados gestion = new GestionEmpleados();
        List<Empleado> lista_de_empleados = new List<Empleado>();
        ReporteEmpleado reporte = new ReporteEmpleado();

        int opcionn;


        try
        {
            do
            {
                Console.Clear();
                Console.WriteLine("*________________________________*");
                Console.WriteLine("|Sistema de Nomina               |");
                Console.WriteLine("|Ingrese una opcion:             |");
                Console.WriteLine("|1) Añadir Empleado              |");
                Console.WriteLine("|2) Actualizar Datos del Empleado|");
                Console.WriteLine("|3) Mostrar Reporte de Empleado  |");
                Console.WriteLine("|4) Salir                        |");
                Console.WriteLine("*--------------------------------*");

                opcionn = int.Parse(Console.ReadLine());

                switch (opcionn)
                {
                    case 1:
                        Console.Clear();
                        gestion.AñadirEmpleado(lista_de_empleados);
                        break;

                    case 2:
                        Console.Clear();
                        if (lista_de_empleados.Count == 0)
                        {
                            Console.WriteLine("***--- No existe ningun Empleado ---***");
                            Console.WriteLine("   --- Por favor vuelva, e ingrese los empleados ---");
                            Console.WriteLine("*** Presione cualquier tecla para continuar ***");
                            Console.ReadLine();
                        }
                        else
                        {
                            gestion.ActualizarDatosEmpleado(lista_de_empleados);
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (lista_de_empleados.Count == 0)
                        {
                            Console.WriteLine("***--- No existe ningun Empleado ---***");
                            Console.WriteLine("   --- Por favor vuelva, ingrese los empleados ---");
                            Console.WriteLine("*** Presione cualquier tecla para continuar ***");
                            Console.ReadLine();
                        }
                        else
                        {
                            reporte.GenerarReporteEmpleado(lista_de_empleados);
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Debe ingresar una opcion valida. Intente nuevamente");
                        break;
                }
            } while (opcionn != 4);
        }
        catch(Exception ex)
        {
            Console.WriteLine("A ocurrido un error: " + ex.Message);
        }
    }
}











