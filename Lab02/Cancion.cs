using System;

namespace Lab02
{
    class Cancion
    {
        private string genero;
        private string artista;
        private string album;
        private string nombre;

        public Cancion(string genCancion, string artCancion, string albumCancion, string nomCancion)
        {
            this.genero = genCancion;
            this.artista = artCancion;
            this.album = albumCancion;
            this.nombre = nomCancion;
        }

        public string Informacion()
        {
            return "Genero: " + genero + ", Artista: " + artista + ", Album: " + album + ", Nombre: " + nombre;
        }

        static void Main(string[] args)
        {
            Cancion C1 = new Cancion("Heavy Metal", "Sabaton", "Heroes", "No Bullets Fly");
            Console.WriteLine(C1.Informacion());
        }
    }
}
// Console.WriteLine("Genero: " + Cancion.genero + " Artista: " + Cancion.artista + " Album: " + Cancion.album + " Nombre: " + Cancion.nombre);