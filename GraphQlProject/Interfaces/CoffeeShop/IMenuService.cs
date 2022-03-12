using System.Collections.Generic;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Interfaces.CoffeeShop
{
    public interface IMenuService
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
