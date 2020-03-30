﻿using System;
using System.Collections.Generic;

namespace Lab02
{
    public class Cancion
    {
        protected string genero;
        protected string artista;
        protected string album;
        protected string nombre;

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

        public string[] Transformador(string genero, string artista, string album, string nombre)
        {
            string[] a2;
            a2[0] = genero;
            a2[1] = artista;
            a2[2] = album;
            a2[3] = nombre;
            return a2;
        }

        public List<Array> listaCanciones = new List<Array>();
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
            t1 = Transformador(C1.genero, C1.artista, C1.album, C1.nombre);
            t2 = Transformador(C2.genero, C2.artista, C2.album, C2.nombre);
            t3 = Transformador(C3.genero, C3.artista, C3.album, C3.nombre);
            t4 = Transformador(C4.genero, C4.artista, C4.album, C4.nombre);
            t5 = Transformador(C5.genero, C5.artista, C5.album, C5.nombre);
            t6 = Transformador(C6.genero, C6.artista, C6.album, C6.nombre);
            t7 = Transformador(C7.genero, C7.artista, C7.album, C7.nombre);
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

        public bool AgregarCancion(Cancion cancion)
        {
            foreach (string[] t2 in listaCanciones)
            {
                if (t2[1] == t1[1] & t2[2] == t1[2] & t2[3] == t1[3])
                {
                    return false;
                }
                else
                {
                    listaCanciones.Add(t2);
                    return true;
                }
            }
        }
        public void VerCanciones()
        {
            Console.WriteLine(listaCanciones);
        }
        public Cancion[] CancionesPorCriterio(String criterio, String valor)
        {
            List<Array> listaResultados() = new List<Array>();
            Console.WriteLine("Escriba por cual de los siguientes criterios desea hacer su busqueda de canciones");
            Console.WriteLine("Genero");
            Console.WriteLine("Artista");
            Console.WriteLine("Album");
            Console.WriteLine("Nombre");
            criterio = Console.ReadLine();
            if (criterio == "Genero" || criterio == "genero")
            {
                Console.WriteLine("Ingrese el genero deseado");
                valor = Console.ReadLine();
                foreach(String[] s in listaCanciones)
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
                    return listaResultados();
                }
            }
            else if (criterio == "Artista" || criterio == "artista")
            {
                Console.WriteLine("Ingrese el artista deseado");
                valor = Console.ReadLine();
                foreach(String[] s in listaCanciones)
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
                    return listaResultados();
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
                    return listaResultados();
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
                    return listaResultados();
                }
            }
            else
            {
                Console.WriteLine("Error");
                Console.WriteLine("Criterio invalido");
                return listaResultados();
            }
        }
        public void Main(string[] args)
        {

        }
    }
}