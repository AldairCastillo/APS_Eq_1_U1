namespace Clase_ICDIA_Unidad1.EjemploAlumnos;

public class Alumno: IEquatable<Alumno>
{
    private int matricula;
    private string nombre;
    private double promedio;

    #region  CONSTRUCTORES

    //vacio
    public Alumno()
    {
    }

    public Alumno(int matricula)
    {
        this.matricula = matricula;
    }

    public Alumno(int matricula, string nombre, double promedio)
    {
            this.matricula = matricula;
            this.nombre = nombre;
            this.promedio = promedio;
    }
    
    #endregion

    public int Matricula
    {
        get => matricula;
        set => matricula = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public double Promedio
    {
        get => promedio;
        set => promedio = value;
    }
    
    public bool Equals(Alumno? other)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        string cad = "(" + matricula +") " + nombre +
                     " Promedio: " + promedio;
        return cad;
    }

    

}