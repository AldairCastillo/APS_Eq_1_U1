using System.Collections;

namespace Clase_ICDIA_Unidad1.EjemploMascotas;

public class ProgramMascotas
{
    public ProgramMascotas()
    {
        ArrayList mascotas = new ArrayList(); //lista de mascotas
        
        //mascota 1
        mascotas.Add(new Mascota(1, "Pricesa", "Sergio", 
            "Perro", "Shitzu", true, 1, 2.3, 
            30, true, "ciega un ojo"));
        //mascota 2
        mascotas.Add(new Mascota(2, "Darinka", "Juan", 
            "Perro", "Husky", true, 3, 5.3, 
            50, false, "Mucho pelo y muy energetica con ojos azules"));
        //mascota 3
        mascotas.Add(new Mascota(3, "Mila", "Banda", 
            "Gato", "negro", false, 5, 4.2, 
            34, false, "tiene 3 patas"));
        //mascota 4
        mascotas.Add(new Mascota(4, "Walter", "Luis", 
            "Perro", "Labrador", true, 3, 8, 
            70, true, "bien musculoso"));
        //mascota 5
        mascotas.Add(new Mascota(5, "lukas", "Ruben", 
            "Perro", "Rot Weiler", true, 6, 20.3, 
            66, true, "Tiene un ojo rojo"));
        //mascota 6
        mascotas.Add(new Mascota(6, "Muñeca", "Dui", 
            "Perra", "Kelpie Australiano", true, 1, 9, 
            50, false, "Ojos color miel"));
        
        Console.WriteLine("Mascotas Registradas:");

        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
        }

        /////
        double pesoLimite = 5;
        Console.WriteLine("Mascotas con menos de " + pesoLimite + " Kilos.: ");

        foreach (Mascota mascota in mascotas)
        {
            if (mascota.Peso<=pesoLimite)
            {
                Console.WriteLine(mascota);
            }
        }
        
        ////
        //imprimir a las mascotas que tienen menos de x años
        int edadReferencia = 3;
        Console.WriteLine("Mascotas con " + edadReferencia + " años o menos.:");

        //recorre a la lista de mascotas
        foreach (Mascota mascota in mascotas)
        { //por cada mascota checamos si cumple o no la condicion
            if (mascota.Edad <= edadReferencia)
            { //si cumple la condicion, imprimimos a la mascota
                Console.WriteLine(mascota);
            }
        }




    }
}