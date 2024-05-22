using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {
        // Atributos
        public enum Paso 
        {
            Inicio,Distribuido,EnEscaner,EnRevision,Terminado
        }
        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;
        //Constructores
        public Documento(string titulo,string autor,int anio,string numNormalizado,string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
            
            
        }
        //Propiedades
        public int Anio { get => anio;}
        public string Autor { get => autor;}
        public string Barcode { get => barcode;}
        public Paso Estado { get => estado;}
        protected string NumNormalizado { get => numNormalizado;}
        public string Titulo { get => titulo;}
        //Metodos
        public bool AvanzarEstado() //este metodo lo que hace es avanzar de 1 en 1 en el enum y devolver true, si ya termino devuelve false
        {
            if (this.estado == Paso.Terminado)
            {
                return false;
            }
            else
            {
                this.estado = (Paso)(((int)this.estado) + 1);
                return true;
            }
        }
        public override string ToString() // creo el stringbuilder
        {
            StringBuilder textoRetorno = new();
            textoRetorno.Append($"Título: {this.titulo}\n");
            textoRetorno.Append($"Autor: {this.autor}\n");
            textoRetorno.Append($"Año: {this.anio}\n");
            textoRetorno.Append($"Código de Barras: {this.barcode}");
            return textoRetorno.ToString();
        }
    }
}
