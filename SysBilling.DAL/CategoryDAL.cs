using SysBilling.EL;
using Microsoft.EntityFrameworkCore;

namespace SysBilling.DAL
{
    public class CategoryDAL
    {
        private readonly BillingContext contex = new BillingContext();
        // CRUD = CREATE, RED, UPDATE y DELETE

        public int Add(Category category)
        {
            //Regla: Si guara 1 y sino 0

            if (category != null)
            {
                contex.Add(category);
                return contex.SaveChanges();
            }
            return 0;

        }
        public int Update(Category category)
        {
            if (category!= null)
            {
                contex.Update(category);
                return contex.SaveChanges();
            }
            return 0;
        }
        public int Delete(Category category)
        {
            if (category != null)
            {
                contex.Remove(category);
                return contex.SaveChanges();
            }
            return 0;
        }
        public List<Category> FindAll()
        {
            return contex.category.ToList();
        }
    }
}
