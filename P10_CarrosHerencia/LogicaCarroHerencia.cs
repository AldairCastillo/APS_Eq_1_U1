namespace Clase_ICDIA_Unidad1.P10_CarrosHerencia;

public class LogicaCarroHerencia
{
    public LogicaCarroHerencia()
    {
        Carro carro1 = new CarroAutomatico(12);
        Carro carro2 = new CarroManual(10);
        Carro carro3  = new CarroAutomatico(15);
        Carro carro4 = new CarroAutomatico(20);

        carro1.Arrancar();
        carro2.Arrancar();
        carro3.Arrancar();
        carro4.Arrancar();
        
    }
}