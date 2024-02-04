using Microsoft.EntityFrameworkCore;
using RapidPOSWebApiNet6.Data.Models;
using System.Linq;

namespace RapidPOSWebApiNet6.Data.Services
{
    public class PaymentService
    {
        private ApiDbContext _context;
        private readonly ILogger<PaymentService> _logger;

        public PaymentService(ApiDbContext context, ILogger<PaymentService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<PaymentEntity> GetAllPayments() => _context.PS_DOC_PMT.ToList<PaymentEntity>();

        public PaymentEntity GetPaymentByDocId(Int64 docId) => _context.PS_DOC_PMT.FirstOrDefault(d => d.DOC_ID== docId);

        public void AddPayment(PaymentEntity payment) 
        {
            #region validation FK vvalues
            //validate related foreign-key values
            if (!(payment.STR_ID == null))
            {
                SaleStoreEntity _store;
                _store = FindSaleStoreById(payment.STR_ID);
                if (_store == null)
                {
                    _logger.LogCritical("Store Id " + payment.STR_ID.ToString() + "not found");
                    return;
                }
            }

            if (!(payment.STA_ID == null))
            {
                SaleStationEntity _station;
                _station = FindSaleStationById(payment.STA_ID);
                if (_station == null)
                {
                    _logger.LogCritical("Station Id " + payment.STA_ID.ToString() + "not found");
                    return;
                }
            }
            #endregion          

            try
            {
                _context.PS_DOC_PMT.Add(payment);  
                _context.SaveChanges();
            }
            catch (InvalidOperationException ex) {   
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public void UpdatePayment(PaymentEntity payment) 
        {
            #region validation FK vvalues
            //validate related foreign-key values
            if (!(payment.STR_ID == null))
            {
                SaleStoreEntity _store;
                _store = FindSaleStoreById(payment.STR_ID);
                if (_store == null)
                {
                    _logger.LogCritical("Store Id " + payment.STR_ID.ToString() + "not found");
                    return;
                }
            }

            if (!(payment.STA_ID == null))
            {
                SaleStationEntity _station;
                _station = FindSaleStationById(payment.STA_ID);
                if (_station == null)
                {
                    _logger.LogCritical("Station Id " + payment.STA_ID.ToString() + "not found");
                    return;
                }
            }
            #endregion            

            try
            {
                _context.PS_DOC_PMT.Update(payment);
                _context.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public void DeletePayment(PaymentEntity payment) 
        {
            #region validation FK vvalues
            //validate related foreign-key values
            if (!(payment.STR_ID == null))
            {
                SaleStoreEntity _store;
                _store = FindSaleStoreById(payment.STR_ID);
                if (_store == null)
                {
                    _logger.LogCritical("Store Id " + payment.STR_ID.ToString() + "not found");
                    return;
                }
            }

            if (!(payment.STA_ID == null))
            {
                SaleStationEntity _station;
                _station = FindSaleStationById(payment.STA_ID);
                if (_station == null)
                {
                    _logger.LogCritical("Station Id " + payment.STA_ID.ToString() + "not found");
                    return;
                }
            }
            #endregion            

            try
            {
                _context.PS_DOC_PMT.Remove(payment);
                _context.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        private SaleStoreEntity FindSaleStoreById(string storeId) => _context.PS_STR.FirstOrDefault(s => s.STR_ID == storeId);
        private SaleStationEntity FindSaleStationById(string stationId) => _context.PS_STA.FirstOrDefault(t => t.STA_ID == stationId);

    }
}
