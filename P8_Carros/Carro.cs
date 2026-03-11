namespace Clase_ICDIA_Unidad1.P8_Carros;

public class Carro: IEquatable<Carro>, IComparable<Carro>
{
    private long vin; //codigo del carro
    private string marca;
    private int modelo; //año

    
    public Carro(long vin)
    {
        this.vin = vin;
    }
    public Carro()
    {
    }
    public Carro(long vin, string marca, int modelo)
    {
        this.vin = vin;
        this.marca = marca;
        this.modelo = modelo;
    }

    public long Vin
    {
        get => vin; 
        set => vin = value;
    }
    public string Marca { 
        get => marca;
        set => marca = value; 
    }

    public int Modelo
    {
        get => modelo; 
        set => modelo = value;
    }

    
    public bool Equals(Carro? other)
    {
        //return this.vin == other.vin;
        if (other is null) return false;
        if (Vin == other.vin)
        {
            //LOG
            return true;
        }
        else
        {
            //LOG
            return false;
        }
    }

    public int CompareTo(Carro? other)
    {
        int resultado = (int)(this.Vin - other.Vin);
        //resultado = resultado * -1; //
        return resultado;
    }

    public override string ToString()
    {
        string cad = "("+ vin +") " + marca + " - " + modelo;
        return cad;
    }

    
}