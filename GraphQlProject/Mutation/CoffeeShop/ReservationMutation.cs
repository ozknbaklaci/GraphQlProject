using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;
using GraphQlProject.Type.CoffeeShop.InputTypes;

namespace GraphQlProject.Mutation.CoffeeShop
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationService reservationService)
        {
            Field<ReservationType>("createReservation",
                arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
                resolve: context => reservationService.AddReservation(context.GetArgument<Reservation>("reservation")));
        }
    }
}
