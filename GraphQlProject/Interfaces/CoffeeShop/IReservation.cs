using System.Collections.Generic;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Interfaces.CoffeeShop
{
    public interface IReservation
    {
        List<Reservation> GeReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
