using System;

public class Customer{
    private Address _address;
    private string _name;

    public Customer(Address address, string name){
        _address = address;
        _name = name;
    }

    public bool InUSA(){
        return _address.InUSA();
    }

    public string FindAddress(){
        return _address.FullAddress();
    }

    public string GetName(){
        return _name;
    }

}