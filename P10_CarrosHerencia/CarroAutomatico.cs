namespace Clase_ICDIA_Unidad1.P10_CarrosHerencia;

public class CarroAutomatico : Carro
{
    public CarroAutomatico(int num_serie) 
        : base(num_serie)
    {
        
    }

    public override void Arrancar()
    {
        Console.WriteLine("Carro automatico Arranca");
    }




}