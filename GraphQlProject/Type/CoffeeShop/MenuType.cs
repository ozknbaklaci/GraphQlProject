using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Type.CoffeeShop
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenuService subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);

            Field<ListGraphType<SubMenuType>>("submenus",
                resolve: context => subMenuService.GetSubMenus(context.Source.Id));
        }
    }
}
