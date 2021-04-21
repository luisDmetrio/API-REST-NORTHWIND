using capaServiciosBackend.claseModelos;
using capaServiciosBackend.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaServiciosBackend.Backend
{
    public class CategoriesSC
    {
        //capa de servicios para categories

        public NorthwindContext dbContex = new NorthwindContext();

        public void agregarCategoria(CategoriesModel newCategories)
        {
            var nuevaCategoria = new Category();
            nuevaCategoria.CategoryName = newCategories.nombreCategoria;
            dbContex.Categories.Add(nuevaCategoria);
            dbContex.SaveChanges();

        }

        public void updateCategories(int id, CategoriesModel newCategories)
        {
            var updateCategoria = getCategoryById(id);
            updateCategoria.CategoryName = newCategories.nombreCategoria;
            dbContex.SaveChanges();
        }

        public void eliminarCategoriaByID(int id)
        {
            var eliminarCategiria = getCategoryById(id);
            dbContex.Remove(eliminarCategiria);
            dbContex.SaveChanges();
        }

        public Category getCategoryById(int id)
        {
            return GetCategories().Where(x => x.CategoryId == id).FirstOrDefault();  
        } 
        
        public IQueryable<Category> GetCategories()
        {
            return dbContex.Categories.AsQueryable();
        }

    }
}
