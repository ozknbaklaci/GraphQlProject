using GraphQL.Types;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Type.CoffeeShop;

namespace GraphQlProject.Query.CoffeeShop
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationService reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations",
                resolve: context => reservationService.GetReservations());
        }
    }
}
