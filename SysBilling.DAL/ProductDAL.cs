using SysBilling.EL;


namespace SysBilling.DAL
{
    public class ProductDAL
    {
        //Objeto del contexto que permite
        //manipular los datos temporales y afectar la BD
        private readonly BillingContext contex;
        

        public int Add(Product product)
        {
            if (product != null)
            {
                contex.Add(product);
                return contex.SaveChanges();
            }
            return 0;
        }
        public int Update(Product product)
        {
            if (product != null)
            {
                contex.Update(product);
                return contex.SaveChanges();
            }
            return 0;
        }
        public int Delete(Product product)
        {
            if (product != null)
            {
                contex.Remove(product);
                return contex.SaveChanges();
            }
            return 0;
        }
        public List<Product> FindAll()
        {
            return contex.products.ToList();
        }
    }
}
