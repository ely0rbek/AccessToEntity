using EntityPro.Application;
using EntityPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityPro.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            var result=await _customerService.GetAllCustomerAsync();
            return result;
        }

        [HttpGet]
        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            var result = await _customerService.GetCustomerByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<string> CreateCustomerAsync(Customer customer)
        {
            var result = await _customerService.CreateCustomerAsync(customer);
            return result;
        }

        [HttpPut]
        public async Task<Customer> UpdateCustomerAsync(int id,Customer customer)
        {
            var result=await _customerService.UpdateCustomerAsync(id, customer);
            return result;
        }

        [HttpDelete]
        public async Task<bool>DeleteCustomerAsync(int id)
        {
            var result=await _customerService.DeleteCustomerAsync(id);
            return result;
        }

        
    }
}
