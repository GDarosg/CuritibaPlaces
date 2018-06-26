using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Model
{
   public class Place
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public Endereco Endereco  { get; set; }

        public int Nota { get; set; }

        public User UserCadastrado { get; set; }

        public String Descricao { get; set; }

        public DateTime HoraAtendimento { get; set; }
    }
}
