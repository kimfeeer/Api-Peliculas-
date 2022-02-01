using WebApi.Models.Response;
using WebApi.Models; 

namespace WebApi.Models.Response
{
    public class Respuesta
    {
        public char Titulo { get; set; }
        public string Mensaje { get; set; }
        public char Director { get; set; }
        public char Genero { get; set; }
        public char Puntuacion { get; set; }
        public char Rating { get; set; }
        public char Añopublicacion { get; set; }

        public Respuesta()
        {
            this.Titulo = (char)100; 
            this.Director = (char)100;
            this.Genero = (char)100;
            this.Puntuacion = (char)100;
            this.Rating = (char)100;
            this.Añopublicacion = (char)100;
        }

    }
}
