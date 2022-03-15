using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;
using GraphQlProject.Type.CoffeeShop.InputTypes;

namespace GraphQlProject.Mutation.CoffeeShop
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuService menuService)
        {
            Field<MenuType>("createMenu",
                arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context => menuService.AddMenu(context.GetArgument<Menu>("menu")));
        }
    }
}
