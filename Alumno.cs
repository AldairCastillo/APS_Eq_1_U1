namespace Clase_ICDIA_Unidad1;

public class Alumno : IEquatable<Alumno>
{
    private string? nombre;
    private string matricula;
    private int cal1;
    private int cal2;
    private int cal3;
    private double promedio;

    public Alumno(string matricula, string nombre)
    {
        this.matricula = matricula;
        this.nombre = nombre;
    }

    public Alumno(string matricula)
    {
        //this.nombre = "";
        this.matricula = matricula;
    }
    
    public string Matricula
    {
        get => matricula; 
        set => matricula = value;
    }
    
    public string Nombre
    {
        get => nombre; 
        set => nombre = value;
    }

    
    public bool Equals(Alumno? other)
    {
        return this.matricula.Equals(other.Matricula);
    }
    //Pendiente analizar el uso de: GetHashCode y Equals(object?) de object ***
    // --> string hash por: StringComparer.Ordinal.GetHashCode(matricula)
    
    
    public override string ToString()
    {
        string cad = " Nombre: "+nombre +
                     "\n Matricula: "+matricula +
                     "\n Promedio: "+promedio;

        return cad;
    }


}