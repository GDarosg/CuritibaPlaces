using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    interface IControler<T> where T : class
    {
        void Cadastrar(T entity);
        void Editar(int id, T entity);
        void Deletar(int id);
        T BuscarPorId(int id);
    }
}
