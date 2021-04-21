using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capaServiciosBackend.Backend;
using capaServiciosBackend.modelos;
using capaServiciosBackend.claseModelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRestNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        // GET: api/<CategoriesController>
        [HttpGet]
        public List<Category> Get()
        {
            var categorias = new CategoriesSC().GetCategories().ToList();
            return categorias;
            
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return new CategoriesSC().getCategoryById(id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] CategoriesModel newCategories)
        {
            new CategoriesSC().agregarCategoria(newCategories);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoriesModel newCategories)
        {
            new CategoriesSC().updateCategories(id, newCategories);
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new CategoriesSC().eliminarCategoriaByID(id);
        }
    }
}
