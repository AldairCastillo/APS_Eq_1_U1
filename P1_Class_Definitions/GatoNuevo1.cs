using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_2026_1_U2_EQ_0.Class_Definitions
{
    internal class GatoNuevo1
    {
        //Abstracción..,

        //modificadores de acceso ... : private / public (Encapsulamiento)
        private int id_gato;
        private string nombre;
        private string color;
        private int edad;
        private bool estaVacunado;
        private double peso;

        //constructores
        public GatoNuevo1(int id_gato, string nombre, string color,
            int edad, bool estaVacunado, double peso)
        {
            this.id_gato = id_gato;
            this.nombre = nombre;
            this.color = color;
            this.edad = edad;
            this.estaVacunado = estaVacunado;
            this.peso = peso;
        }

        public GatoNuevo1(int id_gato, string nombre, string color,
            int edad)
        {
            this.id_gato = id_gato;
            this.nombre = nombre;
            this.color = color;
            this.edad = edad;
            this.peso = 999;
        }

        public GatoNuevo1()
        {

        }

        public GatoNuevo1(string nombre)
        {
            this.nombre = nombre;
        }

        public GatoNuevo1(string nombre, string color)
        {
            this.color = color;
        }



        public string Nombre()
        {
            return nombre;
        }

        public void Nombre(string nombre)
        {
            this.nombre = nombre;
        }

        //getter y setter -> propiedades
        public string Color
        {
            get
            {
                //acceder a una base de datos y almacenar
                //informacion de la consulta
                return "Gato Color: " + color;
            }
            set
            {
                //validar que el dato de entrada sea esperado
                color = value;
            }
        }

    }
}
