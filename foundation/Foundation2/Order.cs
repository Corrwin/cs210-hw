using System;

public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public int TotalShippingCost(){
        int _productTotalCost = 0;
        int i = 0;
        while (i < _products.Count()) {
            _productTotalCost = _productTotalCost +_products[i].TotalCost();
            i++;
        }
        if (_customer.InUSA() == false){
            _productTotalCost = _productTotalCost + 35;
        }
        return _productTotalCost;
    }

    public string ShippingLabel(){
       string shippingLabel = "\n" + _customer.GetName() + "\n";
       shippingLabel = shippingLabel + _customer.FindAddress();
        return shippingLabel;
    }

    public string PackingLabel(){
        string packingLabel =  "";
        int i = 0;
        while (i < _products.Count()){
            packingLabel = packingLabel + _products[i].GetName() + "\n";
            int _holdover = _products[i].GetID();
            packingLabel = packingLabel + $"{_holdover}" + "\n";
            i++;
        }
        return packingLabel;

    }
}