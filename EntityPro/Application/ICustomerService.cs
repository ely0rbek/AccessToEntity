using EntityPro.Models;

namespace EntityPro.Application
{
    public interface ICustomerService
    {
        Task<string> CreateCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(int id,Customer customer);
        Task<bool> DeleteCustomerAsync(int id);
        Task<List<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(int id);

    }
}
