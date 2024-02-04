using RapidPOSWebApiNet6.Data.Models;
using RapidPOSWebApiNet6.Data;

namespace RapidPOSWebApiNet6.Data.Services
{
    public class CustomerService
    {
        private ApiDbContext _context;

        public CustomerService(ApiDbContext context)
        {
            _context = context;
        }

        public List<CustomerEntity> GetAllCustomers() => _context.AR_CUST.ToList();

        public CustomerEntity GetCustomerByNumber(string CustNo) => _context.AR_CUST.FirstOrDefault(n => n.CUST_NO == CustNo);
    }
}
