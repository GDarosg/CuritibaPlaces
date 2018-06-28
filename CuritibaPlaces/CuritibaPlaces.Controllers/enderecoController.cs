using Banco;
using CuritibaPlaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    public class EnderecoController : IControler<Endereco>
    {
        Context context = new Context();
        public string Cadastrar(Endereco entity)
        {
            context.Enderecos.Add(entity);
            context.SaveChanges();
            return "Success";

        }

        public string Deletar(Endereco entity)
        {
            context.Enderecos.Remove(entity);
            context.SaveChanges();
            return "Success";
        }

        public string Editar(Endereco entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return "Success";
        }
    }
}
