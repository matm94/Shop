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
                new User("admin","test","test@test.pl","Amin"),
                new User("Gerald","Ciri","gerald@vp.pl","Klient"),
                new User("Yen","WhiteWolf","yen@vp.pl","User")
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
                    Product = new Product
                    {
                           Collars = new List<Collar>()
                           {
                               new Collar("Zielony",2.5,"Typ","Prosze o uwage",105,"roz",19,"zatrzask",true),
                               new Collar("zolty",1.0,"Typ","Prosze o uwage",105,"bez",19,"zatrzask",true),
                               new Collar("niebieksi",2.0,"Typ","Prosze o uwage",105,"biel",19,"zatrzask",true),
                               new Collar("bialy",3.5,"Typ","Prosze o uwage",105,"czarny",19,"zatrzask",true),
                               new Collar("bez",1.5,"Typ","Prosze o uwage",105,"roz",19,"zatrzask",true),
                           },
                           NormalLeashes = new List<NormalLeash>()
                           {
                               new NormalLeash("bialy",15,"typ","uwagi",200,300,"zolty"),
                               new NormalLeash("niebieski",17,"typ","uwagi",220,300,"zolty"),
                               new NormalLeash("zielony",5,"typ","uwagi",150,300,"bialy"),
                               new NormalLeash("czerwony",25,"typ","uwagi",100,300,"zielony"),
                               new NormalLeash("szary",35,"typ","uwagi",600,300,"zloty"),
                           },
                           ReversibleLeashes = new List<ReversibleLeash>()
                           {
                               new ReversibleLeash("niebieski",12,"typ","uwagi",120,240,"bialy",true,0.0),
                               new ReversibleLeash("zloty",12,"typ","uwagi",280,440,"mat",false,2.0),
                           },
                           TrainingLeashes = new List<TrainingLeash>()
                           {
                               new TrainingLeash("zolty","uwagi",1000,500,true)
                           },
                           Suspenders = new List<Suspenders>()
                           {
                               new Suspenders("bialy",2.5,"typ","uwagi",120,"zatrzask",36,20,18,12,"zloty")
                           },
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
