namespace Clase_ICDIA_Unidad1.EjemploAlumnos;

public class ProgramAlumno
{
    public ProgramAlumno()
    {//logica 
        
        Alumno nuevoAlumno = new Alumno();
        nuevoAlumno.Nombre = "Juan yoquese";
        nuevoAlumno.Matricula = 2;
        nuevoAlumno.Promedio = 6;
        
        Console.WriteLine(nuevoAlumno);
        //Console.WriteLine(nuevoAlumno.ToString());


    }
}