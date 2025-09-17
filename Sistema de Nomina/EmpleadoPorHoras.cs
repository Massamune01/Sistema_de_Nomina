public class EmpleadoPorHoras : Empleado
{
    public int HorasTrabajadas { get; set; }
    public decimal SueldoPorHora { get; set; }

    public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, int horasTrabajadas, decimal sueldoPorHora) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        this.HorasTrabajadas = horasTrabajadas;
        this.SueldoPorHora = sueldoPorHora;
    }

    public override void CalcularPagoSemanal()
    {
        decimal pagoSemanal = 0m;

        if (this.HorasTrabajadas <= 40)
        {
            pagoSemanal = this.SueldoPorHora * this.HorasTrabajadas;
        }
        else if (this.HorasTrabajadas > 40)
        {
            pagoSemanal = (this.SueldoPorHora * 40) + (this.SueldoPorHora * 1.5m * (this.HorasTrabajadas - 40));
        }
        
        Console.WriteLine($"El pago semanal de este empleado es: {pagoSemanal}");
    }

    public override void GenerarReporte()
    {
        Console.WriteLine($"Reporte semanal del empleado:\n Primer Nombre: {this.PrimerNombre}\nApellido Paterno: {this.ApellidoPaterno}\n Numero de Seguro Social: {this.NumeroSeguroSocial}\n Horas Trabajadas: {this.HorasTrabajadas}\n Sueldo Por Hora: {this.SueldoPorHora}");
        CalcularPagoSemanal();
    }
}