using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class CafeDbInitialazer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            
                Category c1 = new Category { Id = 1, Type = "Веган" };
                Category c2 = new Category { Id = 2, Type = "Пицца" };
                Category c3 = new Category { Id = 3, Type = "Роллы" };


                db.Categories.Add(c1);
                db.Categories.Add(c2);
                db.Categories.Add(c3);

                Cafe cf1 = new Cafe { Id = 1, Name = "2 берега", PhoneNumber = "123456", Image = "/site/images/GreenLife.jpg" };
                Cafe cf2 = new Cafe { Id = 2, Name = "3 берега", PhoneNumber = "123456", Image = "/site/images/GreenLife.jpg" };
                Cafe cf3 = new Cafe { Id = 3, Name = "4 берега", PhoneNumber = "123456", Image = "/site/images/GreenLife.jpg" };
                Cafe cf4 = new Cafe { Id = 4, Name = "Урюк", PhoneNumber = "123456", Image = "/site/images/circle.jpg" };
                Cafe cf5 = new Cafe { Id = 5, Name = "Брюк", PhoneNumber = "123456", Image = "/site/images/circle.jpg" };
                Cafe cf6 = new Cafe { Id = 6, Name = "Трюк", PhoneNumber = "123456", Image = "/site/images/circle.jpg" };
                Cafe cf7 = new Cafe { Id = 7, Name = "Мак", PhoneNumber = "123456", Image = "/site/images/mac.jpg" };
                Cafe cf8 = new Cafe { Id = 8, Name = "Бак", PhoneNumber = "123456", Image = "/site/images/mac.jpg" };
                Cafe cf9 = new Cafe { Id = 9, Name = "Так", PhoneNumber = "123456", Image = "/site/images/mac.jpg" };

                db.Cafes.Add(cf1);
                db.Cafes.Add(cf2);
                db.Cafes.Add(cf3);
                db.Cafes.Add(cf4);
                db.Cafes.Add(cf5);
                db.Cafes.Add(cf6);
                db.Cafes.Add(cf7);
                db.Cafes.Add(cf8);
                db.Cafes.Add(cf9);
                Menu m1 = new Menu
                {
                    Id = 1,
                    Name = "Чечевичный суп",
                    Description = "Чечевица, зелень, приправы по вкусу",
                    Image = "/site/images/Soup.jpg",
                    CafeId = cf1.Id,
                    Categories = new List<Category>() { c1 }
                };

                Menu m2 = new Menu
                {
                    Id = 2,
                    Name = "Фалафель",
                    Description = "Горох нут, вода, крупа булгур, луковица большая, чеснок, петрушка, кинза",
                    Image = "/site/images/Soup.jpg",
                    CafeId = cf2.Id,
                    Categories = new List<Category>() { c1 }
                };

                Menu m3 = new Menu
                {
                    Id = 3,
                    Name = "Сэндвич",
                    Description = "Бекон, белый хлеб, сыр эдам, помидоры, майонез",
                    Image = "/site/images/Soup.jpg",
                    CafeId = cf3.Id,
                    Categories = new List<Category>() { c1, c2 }
                };

                Menu m4 = new Menu
                {
                    Id = 4,
                    Name = "Лапша",
                    Description = "Лапша, зелень, соль, вода",
                    Image = "/site/images/L.jpg",
                    CafeId = cf4.Id,
                    Categories = new List<Category>() { c3 }
                };

                Menu m5 = new Menu
                {
                    Id = 5,
                    Name = "Хачапури",
                    Description = "Яйца, мука, дрожжи, соль",
                    Image = "/site/images/H.jpg",
                    CafeId = cf5.Id,
                    Categories = new List<Category>() { c2 }
                };

                Menu m6 = new Menu
                {
                    Id = 6,
                    Name = "Чизкейк",
                    Description = "Песочное печенье, сливочное масло, творог, сахар",
                    Image = "/site/images/cake.jpg",
                    CafeId = cf6.Id,
                    Categories = new List<Category>() { c2, c3 }
                };

                Menu m7 = new Menu
                {
                    Id = 7,
                    Name = "Чикенбургер",
                    Description = "Куринная котлета, карамелизованная булочка, салат, соус",
                    Image = "/site/images/B.jpg",
                    CafeId = cf7.Id,
                    Categories = new List<Category>() { c2 }
                };

                Menu m8 = new Menu
                {
                    Id = 8,
                    Name = "Наггетсы",
                    Description = "Куринное филе, панированное в сухарях",
                    Image = "/site/images/N.jpg",
                    CafeId = cf8.Id,
                    Categories = new List<Category>() { c3 }
                };

                Menu m9 = new Menu
                {
                    Id = 9,
                    Name = "Милкшейк",
                    Description = "Молоко, мороженое, клубника",
                    Image = "/site/images/M.jpg",
                    CafeId = cf9.Id,
                    Categories = new List<Category>() { c1 }
                };

                db.Menus.Add(m1);
                db.Menus.Add(m2);
                db.Menus.Add(m3);
                db.Menus.Add(m4);
                db.Menus.Add(m5);
                db.Menus.Add(m6);
                db.Menus.Add(m7);
                db.Menus.Add(m8);
                db.Menus.Add(m9);
                db.SaveChanges();

                base.Seed(db);
            }
        }

    }
