using System.Reflection.Emit;

public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost() {
        double cost = 0;
        foreach (Product product in _products) {
            cost += product.GetTotalCost();
        }

        if (_customer.InUSA()) {
            cost += 5;
        }
        else {
            cost += 35;
        }
        return cost;
    }

    public string GetPackingLabel() {
        string packingLabels = "";
        foreach (Product product in _products) {
            packingLabels += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }

        return packingLabels;
    }

    public string GetShippingLabel() {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";    
    }
}