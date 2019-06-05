﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Contratos;

namespace Logica
{
    internal sealed class Archivos
    {
        public static Archivos Instancia { get { return new Archivos(); } }

        private static string UbicacionArchivo = @" C:\Users\lu_ga\Documents\ucse-tp-prog2-2019\WebApp\Archivos\";

        public static string RutaArchivoInstituciones = UbicacionArchivo + "Instituciones.txt";
        public static string RutaArchivoHijos = UbicacionArchivo + "Hijos.txt";
        public static string RutaArchivoPadres = UbicacionArchivo + "Padres.txt";
        public static string RutaArchivoDocentes = UbicacionArchivo + "Docentes.txt";
        public static string RutaArchivoDirectoras = UbicacionArchivo + "Directoras.txt";

        public Institucion[] ObtenerInstituciones()
        {
            Institucion[] Instituciones = new Institucion[] { };
            if (!File.Exists(RutaArchivoInstituciones))
            { File.Create(RutaArchivoInstituciones); }
            else
            {
                using (StreamReader Leer = new StreamReader(RutaArchivoInstituciones, false))
                {
                    string ContenidoDelArchivo = Leer.ReadToEnd();
                    Instituciones = JsonConvert.DeserializeObject<Institucion[]>(ContenidoDelArchivo) == null ? new Institucion[] { } : JsonConvert.DeserializeObject<Institucion[]>(ContenidoDelArchivo);
                }
            }
            return Instituciones;
        }

        public Hijo[] ObtenerHijos()
        {
            Hijo[] Hijos = new Hijo[] { };
            if (!File.Exists(RutaArchivoHijos))
            { File.Create(RutaArchivoHijos); }
            else
            {
                using (StreamReader Leer = new StreamReader(RutaArchivoHijos, false))
                {
                    string ContenidoDelArchivo = Leer.ReadToEnd();
                    Hijos = JsonConvert.DeserializeObject<Hijo[]>(ContenidoDelArchivo) == null ? new Hijo[] { } : JsonConvert.DeserializeObject<Hijo[]>(ContenidoDelArchivo);
                }
            }
            return Hijos;
        }

        public Padre[] ObtenerPadres()
        {
            Padre[] Padres = new Padre[] { };
            if (!File.Exists(RutaArchivoPadres))
            { File.Create(RutaArchivoPadres); }
            else
            {
                using (StreamReader Leer = new StreamReader(RutaArchivoPadres, false))
                {
                    string ContenidoDelArchivo = Leer.ReadToEnd();
                    Padres = JsonConvert.DeserializeObject<Padre[]>(ContenidoDelArchivo) == null ? new Padre[] { } : JsonConvert.DeserializeObject<Padre[]>(ContenidoDelArchivo);
                }
            }
            return Padres;
        }

        public Docente[] ObtenerDocentes()
        {
            Docente[] Docentes = new Docente[] { };
            if (!File.Exists(RutaArchivoDocentes))
            { File.Create(RutaArchivoDocentes); }
            else
            {
                using (StreamReader Leer = new StreamReader(RutaArchivoDocentes, false))
                {
                    string ContenidoDelArchivo = Leer.ReadToEnd();
                    Docentes = JsonConvert.DeserializeObject<Docente[]>(ContenidoDelArchivo) == null ? new Docente[] { } : JsonConvert.DeserializeObject<Docente[]>(ContenidoDelArchivo);
                }
            }
            return Docentes;
        }

        public Directora[] ObtenerDirectoras()
        {
            Directora[] Directoras = new Directora[] { };
            if (!File.Exists(RutaArchivoDirectoras))
            { File.Create(RutaArchivoDirectoras); }
            else
            {
                using (StreamReader Leer = new StreamReader(RutaArchivoDirectoras, false))
                {
                    string ContenidoDelArchivo = Leer.ReadToEnd();
                    Directoras = JsonConvert.DeserializeObject<Directora[]>(ContenidoDelArchivo) == null ? new Directora[] { } : JsonConvert.DeserializeObject<Directora[]>(ContenidoDelArchivo);
                }
            }
            return Directoras;
        }

        public bool ModificarArchivoInstituciones(Institucion[] Instituciones)
        {
            using (StreamWriter Escribir = new StreamWriter(RutaArchivoInstituciones, false))
            {
                string jsonInstituciones = JsonConvert.SerializeObject(Instituciones);
                Escribir.Write(jsonInstituciones);
                return true;
            }
        }

        public bool ModificarArchivoHijos(Hijo[] Hijos)
        {
            using (StreamWriter Escribir = new StreamWriter(RutaArchivoHijos, false))
            {
                string jsonHijos = JsonConvert.SerializeObject(Hijos);
                Escribir.Write(jsonHijos);
                return true;
            }
        }

        public bool ModificarArchivoPadres(Padre[] Padres)
        {
            using (StreamWriter Escribir = new StreamWriter(RutaArchivoPadres, false))
            {
                string jsonPadres = JsonConvert.SerializeObject(Padres);
                Escribir.Write(jsonPadres);
                return true;
            }
        }

        public bool ModificarArchivoDocentes(Docente[] Docentes)
        {
            using (StreamWriter Escribir = new StreamWriter(RutaArchivoDocentes, false))
            {
                string jsonDocentes = JsonConvert.SerializeObject(Docentes);
                Escribir.Write(jsonDocentes);
                return true;
            }
        }

        public bool ModificarArchivoDirectoras(Directora[] Directoras)
        {
            using (StreamWriter Escribir = new StreamWriter(RutaArchivoDirectoras, false))
            {
                string jsonDirectoras = JsonConvert.SerializeObject(Directoras);
                Escribir.Write(jsonDirectoras);
                return true;
            }
        }


    }
}
