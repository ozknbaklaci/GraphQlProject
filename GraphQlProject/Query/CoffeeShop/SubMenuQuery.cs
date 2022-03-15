using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;

namespace GraphQlProject.Query.CoffeeShop
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenuService subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus",
                resolve: context => subMenuService.GetSubMenus());

            Field<ListGraphType<SubMenuType>>("submenuById",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => subMenuService.GetSubMenus(context.GetArgument<int>("id")));
        }
    }
}
