using SysBilling.EL;
using SysBilling.DAL;

namespace SysBilling.BL
{
    public class CategoryBL
    {
        private CategoryDAL _category = new CategoryDAL();

        public List<Category> serchCategoryWhithoutRepeating()
        {
            return _category.FindAll().Distinct().ToList();
        }

        public int AddSingleCategory(Category category)
        {
            bool CategoryExistLamda = _category.FindAll().Any(c => c.Name.ToLower() == category.Name.ToLower());


            //bool CategoryExistLingSql = (from c in _category.FindAll() where c.Name == category.Name select c).Any();

            if (!CategoryExistLamda)
            {
                _category.Add(category);
            }
            return 0;
        }

        public Category SerhCategoryById(int id)
        {
            List<Category> ListCategoryBD = new List<Category>();
            ListCategoryBD = _category.FindAll().ToList();

            Category CategoryFind = (from c in ListCategoryBD
                                     where c.IdCategory == id
                                     select c).SingleOrDefault();


            if (CategoryFind != null)
            {
                return CategoryFind;
            }
            return null;
        }

    }
}
