using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Model
{
    public class User
    {
        public int Id{ get; set; }
        public String Nome { get; set; }

        public int Cpf { get; set; }

        public List<Place> Places  { get; set; }

        public String Login { get; set; }

        public String Senha { get; set; }

        }
}
