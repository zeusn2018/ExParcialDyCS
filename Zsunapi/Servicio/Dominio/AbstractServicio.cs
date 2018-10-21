using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zsunapi.Common.Domain.ValueObject;

namespace Zsunapi.Servicio.Dominio
{
    public abstract class AbstractServicio
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string ImagenLink { get; set; }
        public virtual string Description { get; set; }
        public virtual string Autor { get; set; }

        public virtual Money Balance { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
