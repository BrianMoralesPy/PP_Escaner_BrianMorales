using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        //Atributos
        int alto;
        int ancho;
        //Constructores
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int alto, int ancho)
            : base(titulo, autor, anio, numNormalizado,barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        //Propiedades
        public int Alto { get => alto; }
        public int Ancho { get => ancho; }
        public int Superficie { get => alto * ancho; }
        //Metodos
        public static bool operator ==(Mapa m1, Mapa m2)
        {
            // Verificar si ambos son null
            if (m1 is null && m2 is null) 
                return true;
            else if (m1 is null || m2 is null) 
                return false;

            // Comparar atributos relevantes
            bool mismoBarcode = m1.Barcode == m2.Barcode;
            bool mismaIdentidad = m1.Titulo == m2.Titulo && m1.Autor == m2.Autor && m1.Anio == m2.Anio && m1.Superficie == m2.Superficie;
            return mismoBarcode || mismaIdentidad;

        }
        // Sobrecarga del operador !=
        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }
        // Sobrescribir el método ToString para incluir la superficie
        public override string ToString()
        {
            StringBuilder textoRetorno = new();
            textoRetorno.Append(base.ToString());
            textoRetorno.Append($"\nSuperficie: {this.Superficie} cm2.\n");
            return textoRetorno.ToString();
        }
    }
}
