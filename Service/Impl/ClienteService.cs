using Domain.Entities;
//using Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class ClienteService
    {
        //ClienteRepository repo = new ClienteRepository();

        //CRUD
        public void Salvar(Cliente cliente)
        {
            using(var db = new ContextoEF())
            {
                if(cliente.ID != 0)
                {
                    db.Cliente.Attach(cliente);
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    db.Cliente.Add(cliente);
                }
                
                db.SaveChanges();
            }
        }

        public Cliente Obter(int codigo)
        {
            using(var db = new ContextoEF())
            {
                return db.Cliente.Find(codigo);
            }
        }

        public List<Cliente> Listar()
        {
            using(var db = new ContextoEF())
            {
                return db.Cliente.ToList();
            }
        }

        public void Deletar(int codigo)
        {
            using(var db = new ContextoEF())
            {
                var cli = new Cliente() { ID = codigo };
                db.Cliente.Attach(cli);
                db.Cliente.Remove(cli);
                db.SaveChanges();
            }
            //repo.Delete(codigo);
        }
    }
}
