public class EmpleadoPorComision : Empleado
{
    public int VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }


    public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, int ventasBrutas, decimal tarifaComision) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        this.VentasBrutas = ventasBrutas;
        this.TarifaComision = tarifaComision;
    }

    public override void CalcularPagoSemanal()
    {
        decimal pagosemanal = this.VentasBrutas * this.TarifaComision;
        Console.WriteLine($"El pago semanal de este empleado es: {pagosemanal}");
    }

    public override void GenerarReporte()
    {
        Console.WriteLine($"Reporte semanal del empleado:\n Primer Nombre: {this.PrimerNombre}\nApellido Paterno: {this.ApellidoPaterno}\n Numero de Seguro Social: {this.NumeroSeguroSocial}\n Ventas Brutas : {this.VentasBrutas}\n Tarifa por Comision: {this.TarifaComision} ");
        CalcularPagoSemanal();
    }

}