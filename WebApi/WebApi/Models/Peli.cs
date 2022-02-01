using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Peli
    {
        public string? Titulo { get; set; }
        public string? Director { get; set; }
        public string? Genero { get; set; }
        public decimal? Puntuacion { get; set; }
        public string? Rating { get; set; }
        public string? Añopublicacion { get; set; }
    }
}
