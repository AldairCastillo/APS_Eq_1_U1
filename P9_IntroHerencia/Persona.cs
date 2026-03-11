using Clase_ICDIA_Unidad1.EjemploMascotas;
using Clase_ICDIA_Unidad1.P8_Carros;

namespace Clase_ICDIA_Unidad1.P9_IntroHerencia;

public class Persona
{
    private string nombre;
    private Mascota mascota;
    private Carro carro;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public string Nombre
    {
        get => nombre; 
        set => nombre = value;
    }

    public virtual void Saludar()
    {
        Console.WriteLine("Saludo como persona!");
    }
}