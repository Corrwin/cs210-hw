using System;

public class Product{
    private string _name;
    private int _id;
    private int _ppu;
    private int _quantity;

    public Product(string name, int id, int ppu, int quantity){
        _name  = name;
        _id = id;
        _ppu = ppu;
        _quantity = quantity;
    }

    public int TotalCost(){
        return _ppu * _quantity;
    }

    public string GetName(){
        return _name;
    }

    public int GetID(){
        return _id;
    }
    
}