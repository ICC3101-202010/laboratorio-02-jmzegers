using System;

namespace Lab02
{
    class Cancion
    {
        private string genero;
        private string artista;
        private string album;
        private string nombre;

        public string Informacion(string genCancion, string artCancion, string albumCancion, string nomCancion)
        {
            this.genero = genCancion;
            this.artista = artCancion;
            this.album = albumCancion;
            this.nombre = nomCancion;
        }
        static void Main(string[] args)
        {
            Cancion C1 = new Cancion();
            C1.Informacion("Heavy Metal", "Sabaton", "Heroes", "No Bullets Fly");
            Console.WriteLine(C1);
        }
    }
}