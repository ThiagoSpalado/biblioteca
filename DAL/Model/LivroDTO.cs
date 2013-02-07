using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LivroDTO
    {
        public int IdLivro { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }
        public int Paginas { get; set; }
        public bool Status { get; set; }
    }
}
