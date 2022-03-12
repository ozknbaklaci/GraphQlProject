using System.Collections.Generic;
using System.Linq;
using GraphQlProject.Data.CoffeeShop;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Services.CoffeeShop
{
    public class MenuService : IMenuService
    {
        private readonly CoffeeShopDbContext _coffeeShopDbContext;

        public MenuService(CoffeeShopDbContext coffeeShopDbContext)
        {
            _coffeeShopDbContext = coffeeShopDbContext;
        }

        public List<Menu> GetMenus()
        {
            return _coffeeShopDbContext.Menus.ToList();
        }

        public Menu AddMenu(Menu menu)
        {
            _coffeeShopDbContext.Menus.Add(menu);
            _coffeeShopDbContext.SaveChanges();
            return menu;
        }
    }
}
