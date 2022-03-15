using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;
using GraphQlProject.Type.CoffeeShop.InputTypes;

namespace GraphQlProject.Mutation.CoffeeShop
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenuService subMenuService)
        {
            Field<SubMenuType>("createSubMenu",
                arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                resolve: context => subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu")));
        }
    }
}
