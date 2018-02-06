namespace BandencenterJWM
{
    public abstract class Customer : ICustomers
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(int customerID, string name, string address)
        {
            customerID = CustomerID;
            name = Name;
            address = Address;
        }
    }
}