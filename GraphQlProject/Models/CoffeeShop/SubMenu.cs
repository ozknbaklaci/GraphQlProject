namespace GraphQlProject.Models.CoffeeShop
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int MenuId { get; set; }
    }
}
