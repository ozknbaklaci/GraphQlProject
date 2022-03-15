using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;

namespace GraphQlProject.Query.CoffeeShop
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {
            Field<ListGraphType<MenuType>>("menu",
                resolve: context => menuService.GetMenus());
        }
    }
}
