using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class NotaService : IService<Nota>
    {
        private IModel<Nota> model;
        public NotaService(IModel<Nota> model)
        {
            this.model = model;
        }
        public void Add(Nota t)
        {
            model.Add(t);
        }

        public List<Nota> FindAll()
        {
            return model.FindAll();
        }
    }
}
