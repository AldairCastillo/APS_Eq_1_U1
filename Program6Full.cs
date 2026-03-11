namespace Clase_ICDIA_Unidad1;

public class Program6Full {

    List<Alumno> alumnos;
    
    public void ImprimeMenu()
    {
        Console.WriteLine("Selecciona la opcion deseada:");
        Console.WriteLine("1. Ingresar un alumno"); 
        Console.WriteLine("2. Modificar un alumno");
        Console.WriteLine("3. Consultar un alumno"); 
        Console.WriteLine("4. Eliminar un alumno"); 
        Console.WriteLine("5. Salir");
    }
    
    public Program6Full() 
    {
        alumnos = new List<Alumno>();
        string matricula;

        string op;
        do 
        {
            ImprimeMenu(); 
            op = Console.ReadLine(); //respuesta del usuario
            switch (op)
            {
                case "1": //Agregar
                    AgregarAlumno(alumnos);
                    break; 
                case "2": //Modificar
                    if (alumnos.Count>0) //Comprueba si se tiene alumnos por consultar
                    {
                        EditarAlumno();
                    }
                    else
                    {
                        Console.WriteLine("La lista de alumnos esta vacia");
                    }
                    break;
                case "3": //Consultar
                    if (alumnos.Count>0) //Comprueba si se tiene alumnos por consultar
                    {
                        ConsultarAlumno();
                    }
                    else
                    {
                        Console.WriteLine("La lista de alumnos esta vacia");
                    }
                    
                    break;
                case "4": 
                    if (alumnos.Count>0)
                    { //se tiene alumnos por eliminar
                        EliminarAlumno();
                    }
                    else
                    {
                        Console.WriteLine("La lista de alumnos esta vacia");
                    }

                    break;
                case "5": //Salir
                    Console.WriteLine("Gracias por usuar nuestro programa");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (!op.Equals("5"));

        Console.WriteLine("Gracias por usar el programa!!");
    }


    public void AgregarAlumno(List<Alumno> alumnos)
    {
        string? nombre, matricula;
        Console.WriteLine("Dame el nombre del alumno:");
        nombre = Console.ReadLine();
        bool matriculaEsDisponible;
        Alumno temp;
        do
        {
            Console.WriteLine("Dame su matricula:");
            matricula = Console.ReadLine();
            
             temp = new Alumno(matricula);
            //comprobamos si existe un alumno con la misma matricula
            matriculaEsDisponible = alumnos.Contains(temp);
            if (matriculaEsDisponible){ //feedback
                //si existe el alumno, entonces no se agregara a la lista
                Console.WriteLine("La matricula ya existe!");
                return;
            }
        } while (matriculaEsDisponible);
        temp.Nombre = nombre;
        alumnos.Add(temp); //agrega al objeto creado en la lista de alumnos

    }

    public void ConsultarAlumno()
    {
        Console.WriteLine("Ingrese la matricula del alumno a CONSULTAR:");
        string matricula = Console.ReadLine();
        Alumno temp = new Alumno(matricula);
                        
        //Comprueba si el elemento existe en la lista
        bool result = alumnos.Contains(temp);
        if (result) //si existe...
        {
            //obtiene el indice que tiene el elemento en la lista
            int indice = alumnos.IndexOf(temp); 
            Console.WriteLine(alumnos[indice]);
        }
    }

    public void EditarAlumno()
    {
        Console.WriteLine("Ingrese la matricula del alumno a EDITAR:");
        string matricula = Console.ReadLine();
        Alumno temp = new Alumno(matricula);
                        
        //Comprueba si el elemento existe en la lista
        bool result = alumnos.Contains(temp);
        if (result) //si existe...
        {
            //obtiene el indice que tiene el elemento en la lista
            int indice = alumnos.IndexOf(temp); 
            
            string? nombre;
            Console.WriteLine("Ingresa el nuevo nombre del alumno:");
            nombre = Console.ReadLine();
            
            //actualiza el dato en el alumno
            alumnos[indice].Nombre = nombre;
            
        }
    }
    
    public void EliminarAlumno()
    {
        Console.WriteLine("Ingrese la matricula del alumno a ELIMINAR:");
        string matricula = Console.ReadLine();

        Alumno temp = new Alumno(matricula);
                        
        //Comprueba si el elemento existe en la lista
        bool result = alumnos.Contains(temp);
        if (result) //si existe...
        {
            alumnos.Remove(temp);
            Console.WriteLine("Alumno eliminado");
        }
    }

}