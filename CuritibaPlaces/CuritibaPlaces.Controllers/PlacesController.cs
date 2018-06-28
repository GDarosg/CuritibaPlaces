using Banco;
using CuritibaPlaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    public class PlacesController : IControler<Place>
    {
        Context context = new Context();
        public string Cadastrar(Place entity)
        {
            context.Places.Add(entity);
            context.SaveChanges();
            return "success";
        }

        public string Deletar(Place entity)
        {
            context.Places.Remove(entity);
            context.SaveChanges();
            return "success";
        }

        public string Editar(Place entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return "Success";
        }
    }
}
