using Clase_ICDIA_Unidad1.EjemploMascotas;

namespace Clase_ICDIA_Unidad1.EjemploPersona;

public class GestionPersonas
{
    public GestionPersonas()
    {//logica
        
        Persona pp1 = new Persona();
        
        pp1.Ssn = 123456;
        pp1.Nombre = "Jose";
        pp1.Edad = 16;
        pp1.Tiene_mascota = true;
        
        //mascota 1
        Mascota mascotita = new Mascota(1, "Pricesa", "Sergio", 
            "Perro", "Shitzu", true, 1, 2.3, 
            30, true, "ciega un ojo");
        
        pp1.Mascota = mascotita;
        
        Console.WriteLine(pp1);
        
    }
}