using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Cancion
    {
        protected string genero;
        protected string artista;
        protected string album;
        protected string nombre;
        protected List<List<string[]>> listaPlaylists = new List<List<string[]>>();

        public Cancion(string genero, string artista, string album, string nombre)
        {
            this.genero = genero;
            this.artista = artista;
            this.album = album;
            this.nombre = nombre;
        }

        public string Informacion()
        {
            return "Genero: " + genero + ", Artista: " + artista + ", Album: " + album + ", Nombre: " + nombre;
        }

        public string[] Transformador(Cancion cancion)
        {
            string[] a2 = { genero, artista, album, nombre };
            return a2;
        }

        protected List<string[]> listaCanciones = new List<string[]>();
        public string[] t1;
        public string[] t2;
        public string[] t3;
        public string[] t4;
        public string[] t5;
        public string[] t6;
        public string[] t7;
        Cancion C1 = new Cancion("Heavy Metal", "Sabaton", "Heroes", "No Bullets Fly");
        Cancion C2 = new Cancion("Heavy Metal", "Sabaton", "The Last Stand", "The Lost Batallion");
        Cancion C3 = new Cancion("Rock", "The Rolling Stones", "Let it Bleed", "Gimme Shelter");
        Cancion C4 = new Cancion("Rock", "The Rolling Stones", "Beggars Banquet", "Sympathy For the Devil");
        Cancion C5 = new Cancion("Rock", "Green Day", "American Idiot", "Holiday");
        Cancion C6 = new Cancion("Pop", "Twenty-One Pilots", "Heathens", "Heathens");
        Cancion C7 = new Cancion("Pop", "Owl City", "Ocean Eyes", "Fireflies");

        public void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Espotifai!");
            Console.WriteLine("Para ingresar una cancion, aprete A");
            t1 = Transformador(C1);
            t2 = Transformador(C2);
            t3 = Transformador(C3);
            t4 = Transformador(C4);
            t5 = Transformador(C5);
            t6 = Transformador(C6);
            t7 = Transformador(C7);
            listaCanciones.Add(t1);
            listaCanciones.Add(t2);
            listaCanciones.Add(t3);
            listaCanciones.Add(t4);
            listaCanciones.Add(t5);
            listaCanciones.Add(t6);
            listaCanciones.Add(t7);
            Console.WriteLine(C1.Informacion());
            Console.WriteLine(listaCanciones);
        }
    }


    public class Espotifai : Cancion
    {
        public string[] s1;
        public int a;
        public int b;
        public bool AgregarCancion(Cancion cancion)
        {
            a = 0;
            s1 = Transformador(cancion);
            foreach (string[] t in listaCanciones)
            {
                if (t[1] == s1[1] & t[2] == s1[2] & t[3] == s1[3])
                {
                    a = 1;
                }
                else
                {
                    b = 1;
                }
            }
            if (a == 1)
            {
                return false;
            }
            else
            {
                listaCanciones.Add(s1);
                return true;
            }
        }

        public void VerCanciones()
        {
            Console.WriteLine(listaCanciones);
        }

        public List<string[]> CancionesPorCriterio(string criterio, string valor)
        {
            List<string[]> listaResultados = new List<string[]>();
            if (criterio == "Genero" || criterio == "genero")
            {
                Console.WriteLine("Ingrese el genero deseado");
                valor = Console.ReadLine();
                foreach (string[] s in listaCanciones)
                {
                    if (valor == s[0])
                    {
                        listaResultados.Add(s);
                    }
                }
                if (listaResultados == null)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("No se han encontrado resultados para su busqueda");
                }
            }
            else if (criterio == "Artista" || criterio == "artista")
            {
                Console.WriteLine("Ingrese el artista deseado");
                valor = Console.ReadLine();
                foreach (String[] s in listaCanciones)
                {
                    if (valor == s[1])
                    {
                        listaResultados.Add(s);
                    }
                }
                if (listaResultados == null)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("No se han encontrado resultados para su busqueda");
                }
            }
            else if (criterio == "Album" || criterio == "album")
            {
                Console.WriteLine("Ingrese el nombre del album");
                valor = Console.ReadLine();
                foreach (String[] s in listaCanciones)
                {
                    if (valor == s[2])
                    {
                        listaResultados.Add(s);
                    }
                }
                if (listaResultados == null)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("No se han encontrado resultados para su busqueda");
                }
            }
            else if (criterio == "Nombre" || criterio == "nombre")
            {
                Console.WriteLine("Ingrese el nombre de la cancion");
                Console.ReadLine();
                foreach (String[] s in listaCanciones)
                {
                    if (valor == s[3])
                    {
                        listaResultados.Add(s);
                    }
                }
                if (listaResultados == null)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("No se han encontrado resultados para su busqueda");
                }
            }
            else
            {
                Console.WriteLine("Error");
                Console.WriteLine("Criterio invalido");
            }
            return listaResultados;
        }

        private string respuesta;
        private string resp;
        int v;
        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<string[]> playlist = new List<string[]>();
            string[] NombrePlaylist = { nombrePlaylist };
            playlist.Add(NombrePlaylist);
            int u;
            u = 1;
            foreach(List<string[]> l in listaPlaylists)
            {
                if (l[0][0] == "nombrePlaylist")
                {
                    u = 1;
                }
                else
                {
                    v = 1;
                }
            }
            if (u == 1)
            {
                Console.WriteLine("Ya existe un playlist con ese nombre");
                return false;
            }
            Console.WriteLine("Desea agregar canciones a su playlist? si/no");
            respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                while (respuesta == "si")
                {
                    Console.WriteLine("Escriba por cual de los siguientes criterios desea hacer su busqueda de canciones");
                    Console.WriteLine("Genero");
                    Console.WriteLine("Artista");
                    Console.WriteLine("Album");
                    Console.WriteLine("Nombre");
                    resp = Console.ReadLine();
                    List<string[]> opciones = CancionesPorCriterio(resp, criterio);
                    if (opciones == null)
                    {
                        Console.WriteLine("No se han encontrado canciones con ese criterio");
                        break;
                    }
                    Console.WriteLine("Escriba el numero de la cancion que desea agregar");
                    int r = Convert.ToInt32(Console.ReadLine());
                    string[] d = opciones[r + 1];
                    playlist.Add(d);
                    Console.WriteLine("Desea agregar otra cancion a su playlist? si/no");
                    respuesta = Console.ReadLine();
                }
            }
            if (playlist == null)
            {
                return false;
            }
            return true;
        }

        public string VerMisPlaylists()
        {
            foreach (List<string[]> l in listaPlaylists)
            {
                Console.WriteLine(l);
            }
            return ("Listo!");
        }

        public static void Exit(int exitCode)
        {
            exitCode = 1;
        }

        public void Main(string[] args)
        {
            int ph;
            ph = 0;
            while (ph == 0)
            {
                Console.WriteLine("Desea ver todas las canciones de Espotifai? si/no");
                respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    foreach (string[] s in listaCanciones)
                    {
                        Console.WriteLine(s);
                    }
                    ph = 1;
                }
                else if (respuesta == "no")
                {
                    ph = 1;
                }
                else
                {
                    Console.WriteLine("Respuesta Invalida");
                }
            }
            ph = 0;
            while (ph == 0)
            {
                Console.WriteLine("Desea agregar canciones a Espotifai? si/no");
                respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    string g;
                    string a1;
                    string a2;
                    string n;
                    Console.WriteLine("Ingrese el genero");
                    g = Console.ReadLine();
                    Console.WriteLine("Ingrese el artista");
                    a1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el album");
                    a2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre");
                    n = Console.ReadLine();
                    Cancion c = new Cancion(g, a1, a2, n);
                    AgregarCancion(c);
                    ph = 1;
                }
                else if (respuesta == "no")
                {
                    ph = 1;
                }
                else
                {
                    Console.WriteLine("Respuesta Invalida");
                }
            }
            ph = 0;
            int a;
            a = 0;
            while (ph == 0)
            {
                Console.WriteLine("Desea salir del programa? si/no");
                respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    ph = 1;
                    a = 1;
                }
                else if (respuesta == "no")
                {

                }
                else
                {
                    Console.WriteLine("Respuesta invalida");
                }
            }
            if (a == 1)
            {
                Environment.Exit(1);
            }
        }
    }

    public class Playlist : Cancion
    {
        public Playlist(): Cancion()
        {
            
        }
        public void Main(string[] args)
        {
            int ph;
            ph = 0;
            while (ph == 0)
            {
                Console.WriteLine("Desea ver todas las playlists de Espotifai? si/no");
                string respuesta;
                respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    foreach (List<string[]> s in listaPlaylists)
                    {
                        Console.WriteLine(s);
                    }
                    ph = 1;
                }
                else if (respuesta == "no")
                {
                    ph = 1;
                }
                else
                {
                    Console.WriteLine("Respuesta Invalida");
                }
            }
        }
    }
}