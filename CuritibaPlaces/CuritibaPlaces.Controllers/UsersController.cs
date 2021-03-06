﻿using Banco;
using CuritibaPlaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuritibaPlaces.Controllers
{
    public class UsersController : IControler<User>
    {
        private Context context = new Context();

        public String Cadastrar(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return "Success";
        }

        public String Deletar(User entity)
        {
            context.Users.Remove(entity);
            context.SaveChanges();
            return "Success";

        }

        public String Editar(User entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return "Success";
        }
    }
}
