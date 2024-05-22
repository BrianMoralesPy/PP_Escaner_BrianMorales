using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        int numPaginas;

        // Constructor
        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }
        
        // Propiedad pública que devuelve el valor de NumNormalizado
        public string ISBN { get => NumNormalizado; }
        public int NumPaginas { get => numPaginas; }
        public static bool operator ==(Libro l1, Libro l2)
        {
            // Verificar si ambos son null
            if (l1 is null && l2 is null)
                return true;
            // Verificar si uno es null y el otro no
            else if (l1 is null || l2 is null)
                return false;
            // Comparar atributos
            bool mismoBarcode = l1.Barcode == l2.Barcode;
            bool mismoISBN = l1.ISBN == l2.ISBN;
            bool mismoTituloYAutor = l1.Titulo == l2.Titulo && l1.Autor == l2.Autor;
            return mismoBarcode || mismoISBN || mismoTituloYAutor; //determina si es el mismo libro
        }

        // Sobrecarga del operador !=
        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2); //determina si no son los mismos libros
        }
        // Sobrescribir el método ToString para incluir numPaginas y el ISBN
        public override string ToString()
        {
            StringBuilder textoRetorno = new();
            textoRetorno.Append(base.ToString());
            textoRetorno.Append($"\nISBN: {this.ISBN}");
            textoRetorno.Append($"\nNumero de Paginas: {this.NumPaginas}\n");
            return textoRetorno.ToString();
        }
    }

}

