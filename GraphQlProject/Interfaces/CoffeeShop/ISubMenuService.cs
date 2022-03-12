using System.Collections.Generic;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Interfaces.CoffeeShop
{
    public interface ISubMenuService
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
