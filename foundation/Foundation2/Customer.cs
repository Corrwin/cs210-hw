using System;

public class Customer{
    Address _address;
    string _name;

    public Customer(Address address, string name){
        _address = address;
        _name = name;
    }

    public bool InUSA(){
        return _address.InUSA();
    }
}