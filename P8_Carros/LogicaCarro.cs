namespace Clase_ICDIA_Unidad1.P8_Carros;

public class LogicaCarro
{
    public LogicaCarro()
    {
        Carro carro1 = new Carro(25);
        Carro carro2 = new Carro(30);
        Carro carro3 = new Carro(28);
        
        Console.WriteLine("Resultado: ");
        //Console.WriteLine(carro1.Equals(carro2));
        
        List<Carro> carritos = new List<Carro>();
        carritos.Add(carro1);
        carritos.Add(carro2);
        carritos.Add(carro3);
        
        carritos.Sort();
        
        Console.WriteLine("------");
        
    }
}