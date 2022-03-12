using GraphQL.Types;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Type.CoffeeShop
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
        }
    }
}
