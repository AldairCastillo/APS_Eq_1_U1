namespace Clase_ICDIA_Unidad1.P9_IntroHerencia;

public class Alumno : Persona
{
    
    public Alumno(string nombre) 
        : base(nombre)
    {
        
    }

    
    public override void Saludar()
    {
        Console.WriteLine(
            "Hola! mi nombre es " 
            + Nombre);
    }
    

    public override string ToString()
    {
        return "";
    }
}