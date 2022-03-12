using System.Collections.Generic;
using System.Linq;
using GraphQlProject.Data.CoffeeShop;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Models.CoffeeShop;

namespace GraphQlProject.Services.CoffeeShop
{
    public class ReservationService : IReservationService
    {
        private readonly CoffeeShopDbContext _coffeeShopDbContext;

        public ReservationService(CoffeeShopDbContext coffeeShopDbContext)
        {
            _coffeeShopDbContext = coffeeShopDbContext;
        }

        public List<Reservation> GetReservations()
        {
            return _coffeeShopDbContext.Reservations.ToList();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _coffeeShopDbContext.Reservations.Add(reservation);
            _coffeeShopDbContext.SaveChanges();
            return reservation;
        }
    }
}
