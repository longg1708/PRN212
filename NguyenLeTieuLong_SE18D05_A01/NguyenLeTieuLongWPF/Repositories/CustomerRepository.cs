using NguyenLeTieuLongWPF.Models;
namespace NguyenLeTieuLongWPF.Repositories
{
    public class CustomerRepository
    {
        private static List<Customer> _customers = new List<Customer>
        {
            new Customer { CustomerID = 1, CustomerFullName = "John Doe", Telephone = "1234567890", EmailAddress = "john@example.com", CustomerBirthday = new DateTime(1990, 5, 15), CustomerStatus = 1, Password = "pass123" },
            new Customer { CustomerID = 2, CustomerFullName = "Jane Smith", Telephone = "0987654321", EmailAddress = "jane@example.com", CustomerBirthday = new DateTime(1995, 8, 20), CustomerStatus = 1, Password = "pass456" },
            new Customer { CustomerID = 3, CustomerFullName = "Alice Johnson", Telephone = "1112223333", EmailAddress = "alice@example.com", CustomerBirthday = new DateTime(1985, 3, 10), CustomerStatus = 1, Password = "pass789" }
        };

        public List<Customer> GetAll() => _customers;
        public Customer GetById(int id) => _customers.FirstOrDefault(c => c.CustomerID == id);
        public void Add(Customer customer) => _customers.Add(customer);
        public void Update(Customer customer) => _customers[_customers.FindIndex(c => c.CustomerID == customer.CustomerID)] = customer;
        public void Delete(int id) => _customers.RemoveAll(c => c.CustomerID == id);
    }
}