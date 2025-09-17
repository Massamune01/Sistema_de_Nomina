public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }

    public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salariosemanal) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {

        while (salariosemanal <= 0)
        {
            Console.WriteLine("Debe ingresar un valor mayor a 0");
            Console.WriteLine("Ingrese la cantidad nuevamente: ");
            salariosemanal = decimal.Parse(Console.ReadLine());
        }
        
        this.SalarioSemanal = salariosemanal;
    }

    public override void CalcularPagoSemanal()
    {
        Console.WriteLine($"El pago semanal de este empleado es: {this.SalarioSemanal}");
    }

    public override void GenerarReporte()
    {
        Console.WriteLine($"Reporte semanal del empleado:\n Primer Nombre: {this.PrimerNombre}\nApellido Paterno: {this.ApellidoPaterno}\n Numero de Seguro Social: {this.NumeroSeguroSocial}\n Salario Semanal: {this.SalarioSemanal} ");
        CalcularPagoSemanal();
    }

}