namespace Clase_ICDIA_Unidad1.EjemploMascotas;

public class Mascota
{
    private int id_mascota;
    private string nombre;
    private string nombre_cuidador;
    private string tipo_mascota;
    private string raza;
    private bool tiene_cartilla;
    private int edad;
    private double peso;
    private double tamanio;
    private bool tiene_chip;
    private string rasgo_caracteristico;

    #region Constructores
    
    public Mascota(int id_mascota, string nombre,
        string nombre_cuidador, string tipo_mascota,
        string raza, bool tiene_cartilla, int edad,double peso, double tamanio,
        bool tiene_chip, string rasgo_caracteristico) {
        this.id_mascota = id_mascota;
        this.nombre = nombre;
        this.nombre_cuidador = nombre_cuidador; 
        this.tipo_mascota = tipo_mascota;
        this.raza = raza;
        this.tiene_cartilla = tiene_cartilla;
        this.edad = edad;
        this.peso = peso;
        this.tamanio = tamanio;
        this.tiene_chip = tiene_chip;
        this.rasgo_caracteristico = rasgo_caracteristico;
        
    }
    
    #endregion

    public override string ToString()
    {
        string temporal = "(" + id_mascota +") " + nombre + " - Cuidador: " 
                          + nombre_cuidador;
        return temporal;
    }

    #region Propiedades (Getters-Setters)
    public double Peso
    {
        get => peso;
        set => peso = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public double Tamanio
    {
        get => tamanio;
        set => tamanio = value;
    }

    public string Tipo_mascota
    {
        get => tipo_mascota;
        set => tipo_mascota = value;
    }

    public string Raza
    {
        get => raza;
        set => raza = value;
    }

    public bool Tiene_cartilla
    {
        get => tiene_cartilla;
        set => tiene_cartilla = value;
    }

    public bool Tiene_chip
    {
        get => tiene_chip;
        set => tiene_chip = value;
    }

    public string Rasgo_caracteristico
    {
        get => rasgo_caracteristico;
        set => rasgo_caracteristico = value;
    }
    
    #endregion
    
}