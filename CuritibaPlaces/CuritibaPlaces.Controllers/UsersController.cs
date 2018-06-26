using CuritibaPlaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    class UsersController : IControler<User>
    {
        public User BuscarPorId(int id)
        {
            
        }

        public void Cadastrar(User entity)
        {
            
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}
