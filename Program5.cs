namespace Clase_ICDIA_Unidad1;

public class Program5 {

    public void ImprimeMenu()
    {
        Console.WriteLine("Selecciona la opcion deseada:");
        Console.WriteLine("1. Ingresar un alumno"); //Declar e instanciar
        Console.WriteLine("2. Modificar un alumno"); //Getters y setter para editar
        Console.WriteLine("3. Consultar un alumno"); //Getters 
        Console.WriteLine("4. Eliminar un alumno"); //Desvincular un objeto para que el gc lo elimine
            //gc  = garbage collector - Recolector de Basura
        Console.WriteLine("5. Salir");
       
    }

    public Program5() 
    {
        List<Alumno> alumnos;
        alumnos = new List<Alumno>();

        string op;
        do 
        {
            ImprimeMenu(); //Imprime el menu
            op = Console.ReadLine(); //gudar la respuesta del usuario
            switch (op)
            {
                case "1": //Agregar
                    AgregarAlumno(alumnos);
                    break; 
                case "2": //Modificar
                    break;
                case "3": //Consultar
                    Console.WriteLine("Ingresa la matricula del alumno a consultar:");
                    string matricula = Console.ReadLine(); //ingresado por el usuario
                    Alumno al = null; // = alumnos[0]; //se debe modificar para obtener el alumn de la matricula
                    int bandera = 0;
                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.Matricula.Equals(matricula)) // ==
                        {
                            al = alumno;
                            bandera = 1;
                            break;
                        }
                    }

                    if (bandera  == 1) {
                        Console.WriteLine(al.ToString());
                    }
                    else {
                        Console.WriteLine("El alumno no existe");
                    }
                    
                    break;
                case "4": //Eliminar
                    //1.- Comprobar que se tengan alumnos por eliminar
                    //2.- Si se tiene alumnos: 
                    //3.- Pedir una matricula
                    //4.- Buscar el alumno para comprobar si existe
                    //5.- Si el alumno existe, se devuelve y se le notifica al usuario
                    //      que confirme la eliminacion
                    //6.- Si se confirma la eliminacion, se borra el alumno!  
                    
                    //Toda ESTRUCTURA DE DATOS...
                    //tiene al menos las siguientes funciones:
                    // - insertar elementos
                    // - recorrer/consultar (recuperacion de informacion)
                    // - eliminar elementos
                    // - modificar elementos
                    // - buscar elementos
                    // - ordenar elementos 
                    // - comprobar el estado de la estructura (esta vacia?, cuantos elementos tiene?)
                    
                    if (alumnos.Count>0)
                    { //se tiene alumnos por eliminar
                        Console.WriteLine("Ingrese la matricula del alumno a ELIMINAR:");
                        string mat = Console.ReadLine();

                        Alumno temp = new Alumno(mat);
                        
                        //Comprueba si el elemento existe en la lista
                        bool result = alumnos.Contains(temp);
                        if (result)
                        {
                            int indice = alumnos.IndexOf(temp);
                            alumnos.Remove(temp);
                            Console.WriteLine("Alumno eliminado");
                            //Console.WriteLine(result + " indice: " + indice);   
                        }
                        
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