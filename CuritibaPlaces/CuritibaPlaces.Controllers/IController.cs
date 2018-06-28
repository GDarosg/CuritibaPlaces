using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    interface IControler<T> where T : class
    {
        String Cadastrar(T entity);
        String Editar( T entity);
        String Deletar(T entity);
        
    }

    
}
