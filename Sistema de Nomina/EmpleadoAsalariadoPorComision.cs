public class EmpleadoAsalariadoPorComision : Empleado
{
    public decimal SalarioBase { get; set; }
    public int VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }

    public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioBase, int ventasBrutas, decimal tarifaComsion) : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        this.SalarioBase = salarioBase;
        this.VentasBrutas = ventasBrutas;
        this.TarifaComision = tarifaComsion;
    }

    public override void CalcularPagoSemanal()
    {
        decimal pagosemanal = (this.VentasBrutas * this.TarifaComision) + this.SalarioBase + (SalarioBase * 0.10m);
        Console.WriteLine($"El pago semanal de este empleado es: {pagosemanal}");
    }

    public override void GenerarReporte()
    {
        Console.WriteLine($"Reporte semanal del empleado:\n Primer Nombre: {this.PrimerNombre}\nApellido Paterno: {this.ApellidoPaterno}\n Numero de Seguro Social: {this.NumeroSeguroSocial}\n Salario Base: {this.SalarioBase}\n Ventas Brutas: {this.VentasBrutas}\n Tarifa por Comsion: {this.TarifaComision} ");
        CalcularPagoSemanal();
    }
    
}