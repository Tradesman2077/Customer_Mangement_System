using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 1)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted sizes of 4 flowers";
                product.CurrentPrice = 15.96M;

            }
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call insert stored proc
                    }
                    else
                    {
                        //call an update stored proc
                    }
                }
                else
                {
                    success = false;
                }
                
            }
            return success;
        }


         
        
    }
}
    

