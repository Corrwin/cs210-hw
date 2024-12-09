using System;

public class Product{
    string _name;
    int _id;
    int _ppu;
    int _quantity;

    public Product(string name, int id, int ppu, int quantity){
        _name  = name;
        _id = id;
        _ppu = ppu;
        _quantity = quantity;
    }

    public int TotalCost(){
        return _ppu * _quantity;
    }
}