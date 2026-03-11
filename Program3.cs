namespace Clase_ICDIA_Unidad1;

public class Program3
{
    public Program3()
    {
        List<Alumno> alumnos;
        alumnos = new List<Alumno>();

        string op;
        
        do
        {
            Console.WriteLine("Desea agregar algún alumno? (s = si)");
            op = Console.ReadLine();
            if (op.Equals("s"))
            {
                AgregarAlumno(alumnos);
            }
        } while (!op.Equals("n"));

        Console.WriteLine("Gracias por usar el programa!!");
    }


    public void AgregarAlumno(List<Alumno> alumnos)
    {
        string auxiliar1, auxiliar2;
        Console.WriteLine("Dame el nombre del alumno:");
        auxiliar1 = Console.ReadLine();
        Alumno al;
        bool resultado;
        do
        {
            Console.WriteLine("Dame su matricula:");
            auxiliar2 = Console.ReadLine();
            //comprobamos si existe un alumno con la misma matricula
            //si existe el alumno, entonces no se agregara a la lista
            //de alumnos...
            resultado = EsMatriculaDisponible(auxiliar2, alumnos); 
            if (resultado){ //feedback
                Console.WriteLine("La matricula ya existe!");
            }
        } while (resultado);
        al = new Alumno(auxiliar2, auxiliar1);
        alumnos.Add(al); //agrega al objeto creado en la lista de alumnos

    }

    public bool EsMatriculaDisponible(string matricula, List<Alumno> alumnos)
    {
        bool bandera = false;
        for (int i = 0; i < alumnos.Count; i++)
        {
            if (alumnos[i].Matricula.Equals(matricula))
            {
                bandera = true;
                break;
            }
        }

        return bandera;
    }


}