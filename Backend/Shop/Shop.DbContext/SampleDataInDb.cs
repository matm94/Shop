using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Db
{
    public class SampleDataInDb
    {
        public readonly ShopDbContext _shopDbContext;

        public SampleDataInDb(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public void GetSampleDataInDb()
        {
            if(_shopDbContext.Database.CanConnect())
            {
                if(!_shopDbContext.UserDbSet.Any())
                {
                    InsertData();
                }
                if(!_shopDbContext.OrderDbSet.Any())
                {
                    InsertOrderData();
                }
            }
        }

        private void InsertData()
        {
            var user = new List<User>
            {
                new User("admin","test","test@test.pl","ADMIN"),
                new User("Gerald","Ciri","gerald@vp.pl","USER"),
                new User("Yen","WhiteWolf","yen@vp.pl","USER")
            };
            _shopDbContext.AddRange(user);
            _shopDbContext.SaveChanges();
        }

        private void InsertOrderData()
        {
            var order = new List<Order>
            {
                new Order("Geralt","Rivia","48 500888999","ciri@vp.pl","Sended","Sended")
                {
                    ProductPrice = 102,
                    ShipmentPrice = 10,
                    Products = new List<Product>
                    {

                    }



                },

                new Order("Yen","Yeneborg", "48 399200123", "on@vp.pl","Sended","Sended")
                {
                    ProductPrice = 1022,
                    ShipmentPrice = 10
                }
            };
            _shopDbContext.AddRange(order);
            _shopDbContext.SaveChanges();
        }
    }
}
