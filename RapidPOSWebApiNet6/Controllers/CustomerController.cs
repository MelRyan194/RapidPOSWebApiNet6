using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidPOSWebApiNet6.Data.Services;

namespace RapidPOSWebApiNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerService _customerservice;

        public CustomerController(CustomerService service)
        {
            _customerservice = service;
        }

        [HttpGet("get-all-customers")]
        public IActionResult GetAllCustomers()
        {
            var allCustomers = _customerservice.GetAllCustomers();
            return Ok(allCustomers);
        }

        [HttpGet("gey-customer-by-number/{custno}")]
        public IActionResult GetCustomerByNumber(string custno)
        {
            var cust = _customerservice.GetCustomerByNumber(custno);
            return Ok(cust);
        }
    }
}
