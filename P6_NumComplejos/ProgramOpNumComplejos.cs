namespace Clase_ICDIA_Unidad1.NumComplejos;

public class ProgramOpNumComplejos
{
    //Constructor vacio para la clase auxiliar
    public ProgramOpNumComplejos()
    { //logica del programa

        //Las palabras en gris de los argumentos son puestas
        //por el entorno de desarrollo, NO se ponen...
        NumeroComplejo z1 = new NumeroComplejo(2, 3);
        NumeroComplejo z2 = new NumeroComplejo(3, 4);

        NumeroComplejo zr = z1.Suma(z2);
        NumeroComplejo zr2 = z1.Resta(z2);
        
        Console.WriteLine(zr);
        Console.WriteLine(zr2);
        
        //Tarea...
        //Multiplicacion
        
    }
}