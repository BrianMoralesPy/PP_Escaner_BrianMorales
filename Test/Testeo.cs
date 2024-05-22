using System;
using Entidades;

namespace Test
{
    public class Testeo
    {
        static void Main(string[] args)
        {

            // Crear un escáner
            Escaner escanerLibro = new Escaner("Marca1", Escaner.TipoDoc.Libro);
            Escaner escanerMapa = new Escaner("Marca2", Escaner.TipoDoc.Mapa);
            // Agregar algunos documentos
            Libro libro1 = new Libro("Título1", "Autor1", 2020, "ISBN1", "12345", 200);
            Libro libro2 = new Libro("Título2", "Autor2", 2021, "ISBN2", "67890a", 15);
            Libro libro3 = new Libro("Título3", "Autor3", 2022, "ISBN3", "1234531", 2033);
            Libro libro4 = new Libro("Título4", "Autor4", 2023, "ISBN412", "123452123213", 2021);
            Libro libro5 = new Libro("ASDF", "Autor231", 2024, "ISBN412", "123452123213", 2022);
            Libro libro6 = new Libro("ADSFAS", "Autor23", 2025, "ISBN412", "123452123213234", 2023);
            Mapa mapa1 = new Mapa("mapa1", "autor1", 2000, "", "1", 10, 20);
            Mapa mapa2 = new Mapa("mapa2", "autor2", 2001, "", "2", 11, 21);
            Mapa mapa3 = new Mapa("mapa3", "autor3", 2002, "", "3", 12, 22);
            Mapa mapa4 = new Mapa("mapa4", "autor4", 2003, "", "4", 13, 23);
            Mapa mapa5 = new Mapa("mapa6", "autor4", 2003, "", "123", 14, 24);
            Mapa mapa6 = new Mapa("mapa6", "autor4", 2003, "", "123", 15, 25);

            //añado los libros y mapas a sus respectivos escaneres
            bool resultado = escanerLibro + libro1;
            resultado = escanerLibro + libro2;
            resultado = escanerLibro + libro3;
            resultado = escanerLibro +libro4;
            resultado = escanerLibro.CambiarEstadoDocumento(libro1);
            resultado = escanerLibro.CambiarEstadoDocumento(libro2) && escanerLibro.CambiarEstadoDocumento(libro2);
            resultado = escanerLibro.CambiarEstadoDocumento(libro3) && escanerLibro.CambiarEstadoDocumento(libro3) && escanerLibro.CambiarEstadoDocumento(libro3);
            resultado = escanerLibro.CambiarEstadoDocumento(libro4) && escanerLibro.CambiarEstadoDocumento(libro4) && escanerLibro.CambiarEstadoDocumento(libro4) && escanerLibro.CambiarEstadoDocumento(libro3);
            bool resultado2 = escanerMapa + mapa1;
            resultado2 = escanerMapa + mapa2;
            resultado2 = escanerMapa + mapa3;
            resultado2 = escanerMapa + mapa4;
            resultado2 = escanerMapa.CambiarEstadoDocumento(mapa1);
            resultado2 = escanerMapa.CambiarEstadoDocumento(mapa2) && escanerMapa.CambiarEstadoDocumento(mapa2);
            resultado2 = escanerMapa.CambiarEstadoDocumento(mapa3) && escanerMapa.CambiarEstadoDocumento(mapa3) && escanerMapa.CambiarEstadoDocumento(mapa3);
            resultado2 = escanerMapa.CambiarEstadoDocumento(mapa4) && escanerMapa.CambiarEstadoDocumento(mapa4) && escanerMapa.CambiarEstadoDocumento(mapa4) && escanerMapa.CambiarEstadoDocumento(mapa4);

            //Libros
            // Generar informe distribuidos
            Console.WriteLine("Informes de documentos distribuidos:");
            Informes.MostrarDistribuidos(escanerLibro, out int extension, out int cantidad, out string resumen);
            Console.WriteLine($"Extensión total: {extension}");
            Console.WriteLine($"Cantidad total: {cantidad}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen);
            // Generar informe en escaner
            Console.WriteLine("Informes de documentos en escaner:");
            Informes.MostrarEnEscaner(escanerLibro, out int extension2, out int cantidad2, out string resumen2);
            Console.WriteLine($"Extensión total: {extension2}");
            Console.WriteLine($"Cantidad total: {cantidad2}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen2);
            // Generar informe en revision
            Console.WriteLine("Informes de documentos en revision:");
            Informes.MostrarEnRevision(escanerLibro, out int extension3, out int cantidad3, out string resumen3);
            Console.WriteLine($"Extensión total: {extension3}");
            Console.WriteLine($"Cantidad total: {cantidad3}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen3);
            // Generar informe en terminados
            Console.WriteLine("Informes de documentos en terminados:");
            Informes.MostrarTerminados(escanerLibro, out int extension4, out int cantidad4, out string resumen4);
            Console.WriteLine($"Extensión total: {extension4}");
            Console.WriteLine($"Cantidad total: {cantidad4}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen4);
            
            //MAPAS
            // Generar informe de mapas distribuidos
            Console.WriteLine("Informes de mapas distribuidos:");
            Informes.MostrarDistribuidos(escanerMapa, out int extension5, out int cantidad5, out string resumen5);
            Console.WriteLine($"Extensión total: {extension5}");
            Console.WriteLine($"Cantidad total: {cantidad5}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen5);

            // Generar informe de mapas en escáner
            Console.WriteLine("\nInformes de mapas en escáner:");
            Informes.MostrarEnEscaner(escanerMapa, out int extension6, out int cantidad6, out string resumen6);
            Console.WriteLine($"Extensión total: {extension6}");
            Console.WriteLine($"Cantidad total: {cantidad6}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen6);

            // Generar informe de mapas en revisión
            Console.WriteLine("\nInformes de mapas en revisión:");
            Informes.MostrarEnRevision(escanerMapa, out int extension7, out int cantidad7, out string resumen7);
            Console.WriteLine($"Extensión total: {extension7}");
            Console.WriteLine($"Cantidad total: {cantidad7}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen7);

            // Generar informe de mapas terminados
            Console.WriteLine("\nInformes de mapas terminados:");
            Informes.MostrarTerminados(escanerMapa, out int extension8, out int cantidad8, out string resumen8);
            Console.WriteLine($"Extensión total: {extension8}");
            Console.WriteLine($"Cantidad total: {cantidad8}");
            Console.WriteLine("\nResumen:");
            Console.WriteLine(resumen8);

            // Verificar si dos libros son iguales
            if (libro5 == libro6)
            {
                Console.WriteLine("Los libros 1 y 2 son iguales.");
            }
            else
            {
                Console.WriteLine("Los libros 5 y 6 no son iguales.");
            }

            // Verificar si dos mapas son iguales
            if (mapa5 == mapa6)
            {
                Console.WriteLine("Los mapas 5 y 6 son iguales.");
            }
            else
            {
                Console.WriteLine("Los mapas 1 y 2 no son iguales.");
            }
        }
    }
}
