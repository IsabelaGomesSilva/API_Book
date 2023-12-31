using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LIVROS.Model
{
    public class LivroModel
    {
        public string  Id { get; set; } = Guid.NewGuid().ToString();
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public DateTime dtinserted {get; set;}
    }
}