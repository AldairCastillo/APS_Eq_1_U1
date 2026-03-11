using Clase_ICDIA_Unidad1.EjemploMascotas;

namespace Clase_ICDIA_Unidad1.EjemploPersona;

public class Persona
{
    private int ssn; //social security number
    private string nombre;
    private int edad;
    private bool tiene_mascota;
    private Mascota mascota;

    #region CONSTRUCTORS
    
    //Constructor vacio
    public Persona()
    {
        
    }

    //constructor "BASE"
    public Persona(int ssn, string nombre, int edad,
        bool tiene_mascota)
    {
        this.ssn = ssn;
        this.nombre = nombre;
        this.edad = edad;
        this.tiene_mascota = tiene_mascota;
    }

    //Constructor para comparaciones 
    public Persona(int ssn)
    {
        this.ssn = ssn;
    }

    #endregion

    #region PROPERTIES
    
    public int Ssn
    {
        get => ssn; 
        set => ssn = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }
    
    public bool Tiene_mascota
    {
        get => tiene_mascota;
        set => tiene_mascota = value;
    }

    public Mascota Mascota
    {
        get => mascota;
        set => mascota = value;
    }

    #endregion

    public override string ToString()
    {
        string cad = "("+ssn+")-" + nombre + 
                     ". Tiene Mascota?: " + tiene_mascota;
        return cad;
    }

}