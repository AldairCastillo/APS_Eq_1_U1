namespace Clase_ICDIA_Unidad1.P8_Carros;

public class CarroOrdanamientoPorModelo: IComparer<Carro>
{
    public int Compare(Carro? x, Carro? y)
    {
        int v = x.Modelo - y.Modelo;
        return v;
    }
}