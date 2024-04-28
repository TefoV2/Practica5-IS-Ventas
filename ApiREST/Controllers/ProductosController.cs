using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

// NOMBRE APELLIDOS: Estefano Galarza
// PARALELO: P3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 29/04/2024
// PRÁCTICA No. #5

namespace ApiREST.Controllers
{
    public class ProductosController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();

        //Get - listar todos
        public IHttpActionResult Get()
        {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);
        }
        //Get - mostrar producto por id
        public IHttpActionResult Get(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if(producto != null)
            {
                return Ok(producto);
            }
            return NotFound();
        }
        // Post - insertar un nuevo Producto
        public IHttpActionResult Post(Producto producto)
        {
            try
            {
                productoNegocio.insertarProducto(producto);
                return Ok("Insertado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //Put -actualizar un producto
        public IHttpActionResult Put(int id, Producto producto)
        {
            // Obtener el producto de la base de datos por su ID
            Producto productoExistente = productoNegocio.ById(id);
            if (productoExistente == null)
            {
                return BadRequest("El producto no existe.");
            }

            // Actualizar los valores del producto
            productoExistente.nombre = producto.nombre;
            productoExistente.precio_unitario = producto.precio_unitario;
            productoExistente.iva = producto.iva;

            // Guardar los cambios
            if (productoNegocio.actualizarProducto(productoExistente))
            {
                return Ok("Producto actualizado correctamente.");
            }
            else
            {
                return BadRequest();
            }
        }

        //Delete - eliminar un producto
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Producto productoEliminar = productoNegocio.ById(id);
                if (productoEliminar == null)
                {
                    return NotFound();
                }
                productoNegocio.eliminarProducto(productoEliminar);
                return Ok("Producto Eliminado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}