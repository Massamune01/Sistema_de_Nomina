public abstract class Empleado
{
    
    // Propiedades
    public string PrimerNombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string NumeroSeguroSocial { get; set; }


    //Constructor
    public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
    {
        this.PrimerNombre = primerNombre;
        this.ApellidoPaterno = apellidoPaterno;
        this.NumeroSeguroSocial = numeroSeguroSocial;
    }
    //Metodos
    public abstract void CalcularPagoSemanal();
    public abstract void GenerarReporte();
    

    
}