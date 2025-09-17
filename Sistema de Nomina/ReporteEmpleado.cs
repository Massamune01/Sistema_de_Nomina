public class ReporteEmpleado
{
    public void GenerarReporteEmpleado(List<Empleado> lista_de_empleados)
        {
            int numero;
            Console.WriteLine("Lista de Empleados:");
            for (int i = 0; i < lista_de_empleados.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {lista_de_empleados[i].PrimerNombre}");
            }

            Console.WriteLine("Ingresa el numero del empleado para generar reporte: ");
            numero = int.Parse(Console.ReadLine());
            numero = numero - 1;

            for (int i = 0; i < lista_de_empleados.Count; i++)
            {
                if (i == numero)
                {
                    Console.WriteLine("-------------------------------------------------------------");
                    lista_de_empleados[i].GenerarReporte();
                    Console.WriteLine("*** Presione cualquier tecla para continuar ***");
                    Console.ReadLine();
            }
            }

        }
}