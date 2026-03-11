namespace Clase_ICDIA_Unidad1;

public class Program2
{
    public Program2() {
        
        List<Alumno> alumnos;
        alumnos = new List<Alumno>();

        string op;
        string auxiliar1, auxiliar2;
        do
        {
            Console.WriteLine("Desea agregar algún alumno? (s = si)");
            op = Console.ReadLine();
            if (op.Equals("s"))
            {
                Console.WriteLine("Dame el nombre del alumno:");
                auxiliar1 = Console.ReadLine();
                Console.WriteLine("Dame su matricula:");
                auxiliar2 = Console.ReadLine();
                Alumno al = new Alumno(auxiliar2, auxiliar1);
                //comprobamos si existe un alumno con la misma matricula
                //si existe el alumno, entonces no se agregara a la lista
                //de alumnos...
                bool bandera = false;
                for (int i = 0; i < alumnos.Count; i++)
                {
                    if (alumnos[i].Matricula.Equals(auxiliar2))
                    {
                        bandera = true;
                        break;
                    }
                }

                if (!bandera) {
                    alumnos.Add(al); //agrega al objeto creado en la lista de alumnos
                }
                else {
                    Console.WriteLine("La matricula ya existe!");
                }
            }
        } while (!op.Equals("n"));
        Console.WriteLine("Gracias por usar el programa!!");
    }

}

