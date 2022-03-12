using System.Collections.Generic;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Interfaces.CoffeeShop
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
