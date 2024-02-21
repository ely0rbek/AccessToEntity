using EntityPro.Infrastructure;
using EntityPro.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityPro.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return "Model was joined";
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            var person=_context.Customers.FirstOrDefaultAsync(x=>x.Id==id);
            if (person!=null)
            {
                _context.Customers.Remove(person.Result);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<List<Customer>> GetAllCustomerAsync()
        {
            var people=_context.Customers.ToListAsync();
            return people;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            var person = _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (person != null)
            {
                return person;
            }
            return null;
        }

        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
            var person = _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (person != null)
            {
                person.Result.Name = customer.Name;
                person.Result.Address=customer.Address;

                await _context.SaveChangesAsync();
                return customer;
            }
            return null;
        }
    }
}
