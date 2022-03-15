using System;
using GraphQlProject.Mutation.CoffeeShop;
using GraphQlProject.Query.CoffeeShop;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQlProject.Schema.CoffeeShop
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
