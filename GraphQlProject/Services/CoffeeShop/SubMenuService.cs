using System.Collections.Generic;
using System.Linq;
using GraphQlProject.Data.CoffeeShop;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Services.CoffeeShop
{
    public class SubMenuService : ISubMenuService
    {
        private readonly CoffeeShopDbContext _coffeeShopDbContext;

        public SubMenuService(CoffeeShopDbContext coffeeShopDbContext)
        {
            _coffeeShopDbContext = coffeeShopDbContext;
        }

        public List<SubMenu> GetSubMenus()
        {
            return _coffeeShopDbContext.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _coffeeShopDbContext.SubMenus.Where(x => x.MenuId == menuId).ToList();
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _coffeeShopDbContext.SubMenus.Add(subMenu);
            _coffeeShopDbContext.SaveChanges();
            return subMenu;
        }
    }
}
