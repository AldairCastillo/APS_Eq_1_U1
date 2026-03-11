namespace Clase_ICDIA_Unidad1.P8_Carros;

public class LogicaCarroV2
{
    public LogicaCarroV2()
    {
        Carro carro1 = new Carro(25, "Toyota", 2025);
        Carro carro2 = new Carro(30, "Chevrolet", 2021);
        Carro carro3 = new Carro(28, "Dodge", 2006);
        
        Console.WriteLine("Resultado: ");
        //Console.WriteLine(carro1.Equals(carro2));
        
        List<Carro> carritos = new List<Carro>();
        carritos.Add(carro1);
        carritos.Add(carro2);
        carritos.Add(carro3);
        
        //carritos.Sort();
        
        //CarroOrdenamientoPorMarca ordMarca = new CarroOrdenamientoPorMarca();
        //carritos.Sort(ordMarca);
        
        CarroOrdanamientoPorModelo ordModelo = new CarroOrdanamientoPorModelo();
        carritos.Sort(ordModelo);
        
        Console.WriteLine("------");
        
        //Clase Tarea Pendiente: TENNIS
        //Clase Tarea: Telefonos 
    }
}