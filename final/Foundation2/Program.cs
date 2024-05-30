using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Alvin Meredith III", address1);

        Address address2 = new Address("23 Tribe Street", "South Melbourne", "Victoria", "Australia");
        Customer customer2 = new Customer("Ann Smith", address2);
        
        Product product1 = new Product("Textbooks", 1245, 89.99, 300);
        Product product2 = new Product("Book of Mormon", 7, 1, 2000);
        List<Product> products1 = new List<Product> {product1, product2}; 

        Product product3 = new Product("Towel set", 4387, 14.99, 1);
        Product product4 = new Product("T-Shirt Set",1063,12.99,2);
        List<Product> products2 = new List<Product> {product3, product4};

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);
        List<Order> orders = new List<Order> {order1, order2};

        foreach (Order order in orders) {
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}\n");
        }

    }
}