using System.Text;

namespace Entidades
{
    public static class Informes
    {
        // Método privado para mostrar documentos por estado
        private static void MostrarDocumentoPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            StringBuilder mostrarTexto = new();

            foreach (Documento d in e.Documentos)
            {
                if (d.Estado == estado)
                {
                    // Incrementar la extensión según el tipo de documento
                    if (d is Libro l)
                    {
                        extension += l.NumPaginas;
                    }
                    else if (d is Mapa m)
                    {
                        extension += m.Superficie;
                    }

                    // Contar el documento como único
                    cantidad++;

                    // Agregar información del documento al resumen
                    mostrarTexto.AppendLine(d.ToString());
                }
            }

            resumen = mostrarTexto.ToString();
        }

        // Método público para mostrar documentos distribuidos
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);
        }

        // Método público para mostrar documentos en escáner
        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        // Método público para mostrar documentos en revisión
        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        // Método público para mostrar documentos terminados
        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }
    }
}