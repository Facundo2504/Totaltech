using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Repository;
using Entidades;

namespace Logica
{
    public class ProductoLogic
    {
        private readonly GenericRepository<Producto> _repo;

        public ProductoLogic ( GenericRepository<Producto> repo )
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Producto>> ListarProductos ( )
        {
            return await _repo.GetAllAsync ();
        }

        public async Task AgregarProducto ( Producto producto )
        {
            if (producto.Precio <= 0)
                throw new ArgumentException ("El precio debe ser mayor a cero.");

            await _repo.AddAsync (producto);
            await _repo.SaveAsync ();
        }
    }
}

