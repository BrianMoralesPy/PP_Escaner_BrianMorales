using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {   
        public enum Departamento
        {
            Nulo,Mapoteca,ProcesosTecnicos
        }

        public enum TipoDoc
        {
            Libro,Mapa
        }

        // Atributos
        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;
        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            listaDocumentos = new List<Documento>();

            // Establecer la locación según el tipo de documento
            if (this.tipo == TipoDoc.Libro)
            {
                locacion = Departamento.ProcesosTecnicos;
            }
            else if (this.tipo == TipoDoc.Mapa)
            {
                locacion = Departamento.Mapoteca;
            }
            else
            {
                locacion = Departamento.Nulo;
            }
        }

        // Propiedades
        public List<Documento> Documentos { get => listaDocumentos;}
        public Departamento Locacion { get => locacion;}
        public string Marca { get => marca;}
        public TipoDoc Tipo { get => tipo;}
        // Metodos
        public static bool operator ==(Escaner e, Documento d) // esta sobrecarga del operador == lo que hace es devolver true si hay algun documento igual si no devuelvue false
        {
            if (e is null || d is null)
            {
                return false;
            }

            foreach (var doc in e.listaDocumentos)
            {
                if (doc == d)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d); 
        }
        public static bool operator +(Escaner e, Documento d)
        {
            if (e is null || d is null)
            {
                // Si alguno de los argumentos es null, no se puede agregar el documento
                return false;
            }

            // Verificar si el documento ya está en la lista
            if (e.Tipo == TipoDoc.Libro && d is Libro || e.Tipo == TipoDoc.Mapa && d is Mapa)
            {
                e.Documentos.Add(d);
                return true;
            }
            return false;
        }
        public bool CambiarEstadoDocumento(Documento d) //este metodo pregunta si en la lista de documentos contiene los documentos, si los tiene avanza de estado
        {
            if (Documentos.Contains(d))
            {
                d.AvanzarEstado();
                return true;
            }
            return false;
        }
    }
}
