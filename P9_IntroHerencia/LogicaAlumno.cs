namespace Clase_ICDIA_Unidad1.P9_IntroHerencia;

public class LogicaAlumno
{
    public LogicaAlumno()
    {
        Persona pLuis;
        //pLuis = new Persona("Luis");
        pLuis = new Alumno("Luis");

        pLuis.Saludar();
    }
}