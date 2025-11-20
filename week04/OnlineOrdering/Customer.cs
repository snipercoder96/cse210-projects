/* Second easiest class to work with */
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string DisplayCustomerInfo()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }

    public string SetName()
    {
        return _name;
    }

    public Address SetAddress()
    {
        return _address;
    }
    
    
}