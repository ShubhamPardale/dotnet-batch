using JoesPizza.Entities;

namespace JoesPizza.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Id = "01",
                    Name = "FarmHouse Pizza",
                    Price =510,
                    Photo = "img1.png",
                    Type="Veg"
                },

                new Product
                {
                    Id = "02",
                    Name = "Chicken Tikka Pizza",
                    Price =540,
                    Photo = "img8.jpg",
                    Type="Non Veg"
                    
                },
                new Product
                {
                    Id = "03",
                    Name = "Cheese Pizza",
                    Price =530,
                    Photo = "img7.png",
                    Type="Veg"
                },
                new Product
                {
                    Id = "04",
                    Name = "Chicken Sausage Pizza",
                    Price =520,
                    Photo = "img3.png",
                    Type="Non Veg"
                },
                new Product
                {
                    Id = "05",
                    Name = "Mushroom Pizza",
                    Price =550,
                    Photo = "img13.jpg",
                    Type="Veg"
                },
                new Product
                {
                    Id = "06",
                    Name = "Fresh Veggie Pizza",
                    Price =560,
                    Photo = "img14.jpg",
                    Type="Veg"
                }
            };
        }
        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            //return Products.Where(p => p.Id == id).FirstOrDefault();
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
