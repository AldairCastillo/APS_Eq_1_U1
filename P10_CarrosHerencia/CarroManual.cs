namespace Clase_ICDIA_Unidad1.P10_CarrosHerencia;

public class CarroManual : Carro
{
    public CarroManual(int nnserie) : base(nnserie)
    {
        
    }

    public override void Arrancar()
    {
        Console.WriteLine("Carro manual-Arranca");
    }
}