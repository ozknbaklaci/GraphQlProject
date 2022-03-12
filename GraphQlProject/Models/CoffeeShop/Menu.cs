using System.Collections.Generic;

namespace GraphQlProject.Models.CoffeeShop
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<SubMenu> SubMenus { get; set; }
    }
}
