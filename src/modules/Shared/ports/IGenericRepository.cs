using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostfinalForm.src.modules.Shared.ports
{
    public interface IGenericRepository<T>
    {
        void Crear(T entity);
        void Actualizar(T entity);
        void Eliminar(int id);
    }
}