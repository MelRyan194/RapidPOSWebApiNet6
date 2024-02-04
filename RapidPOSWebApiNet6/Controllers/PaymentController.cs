using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidPOSWebApiNet6.Data.Models;
using RapidPOSWebApiNet6.Data.Services;
using RapidPOSWebApiNet6.Data.ViewModels;

namespace RapidPOSWebApiNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private PaymentService _payService;
        private readonly ILogger<PaymentService> _logger;

        public PaymentController(PaymentService service, ILogger<PaymentService> logger)
        {
            _payService = service;
            _logger = logger;
        }

        [HttpGet("get-all-payments")]
        public IActionResult GetAllPayments()
        {
            var allPayments = _payService.GetAllPayments();
            return Ok(allPayments);
        }

        [HttpGet("get-payment-by-number/{docId}")]
        public IActionResult GetPaymentByNumber(Int64 docId)
        {
            var pay = _payService.GetPaymentByDocId(docId);
            return Ok(pay);
        }

        [HttpPost("add-payment-details")]
        public ActionResult<PaymentVM> AddPayment([FromBody] PaymentVM paymentVM )
        {
            #region Validate data
            //validate payment info
            if (paymentVM.DOC_ID == 0)
            {
                _logger.LogError("DOC_ID info not passed.");
                return BadRequest();
            }
            if(!(ModelState.IsValid))
            {
                _logger.LogError("Required fields were not provided.");
                return BadRequest();
            }
            #endregion
            PaymentEntity _newPayment = new PaymentEntity();
            _newPayment.DOC_ID = paymentVM.DOC_ID;
            _newPayment.EXCH_LOSS = paymentVM.EXCH_LOSS;
            _newPayment.STA_ID = paymentVM.STA_ID;
            _newPayment.STR_ID = paymentVM.STR_ID;
            _newPayment.EXCH_RATE_DENOM = paymentVM.EXCH_RATE_DENOM;
            _newPayment.AMT = paymentVM.AMT;
            _newPayment.CARD_IS_NEW = paymentVM.CARD_IS_NEW;
            _newPayment.CURNCY_COD = paymentVM.CURNCY_COD;
            _newPayment.DEP_LIN_COPIED_TO_REL_DOC = paymentVM.DEP_LIN_COPIED_TO_REL_DOC;
            _newPayment.EDC_AUTH_FLG = paymentVM.EDC_AUTH_FLG;
            _newPayment.EXCH_RATE_DENOM = paymentVM.EXCH_RATE_DENOM;
            _newPayment.EXCH_RATE_NUMER = paymentVM.EXCH_RATE_NUMER;
            _newPayment.FINAL_PMT = paymentVM.FINAL_PMT;
            _newPayment.gfc_authed = paymentVM.gfc_authed;
            _newPayment.HOME_CURNCY_AMT = paymentVM.HOME_CURNCY_AMT;
            _newPayment.HOME_CURNCY_ROUND_GAIN_LOSS = paymentVM.HOME_CURNCY_ROUND_GAIN_LOSS;
            _newPayment.PAY_COD_TYP = paymentVM.PAY_COD_TYP;
            _newPayment.PMT_LIN_TYP = paymentVM.PMT_LIN_TYP;
            _newPayment.PMT_SEQ_NO = paymentVM.PMT_SEQ_NO;
            _newPayment.ROUND_GAIN_LOSS = paymentVM.ROUND_GAIN_LOSS;
            _newPayment.SECURE_ECOMM_TRX = paymentVM.SECURE_ECOMM_TRX;
            _newPayment.SWIPED = paymentVM.SWIPED;
            _newPayment.TIP_AMT = paymentVM.TIP_AMT;
            _newPayment.TKT_NO = paymentVM.TKT_NO;
            _payService.AddPayment(_newPayment);
            _logger.LogInformation("Payment with doc_id " + _newPayment.DOC_ID.ToString() + "successfully added");

            return Ok(_newPayment);
        }

        [HttpPut("update-payment-details")]
        public ActionResult<PaymentVM> UpdatePayment([FromBody] PaymentVM paymentVM)
        {
            #region Validate data
            //validate payment info
            if (paymentVM.DOC_ID == 0)
            {
                _logger.LogError("DOC_ID info not passed.");
                return BadRequest();
            }
            if (!(ModelState.IsValid))
            {
                _logger.LogError("Required fields were not provided.");
                return BadRequest();
            }
            #endregion

            PaymentEntity _newPayment = new PaymentEntity();
            _newPayment.DOC_ID = paymentVM.DOC_ID;
            _newPayment.EXCH_LOSS = paymentVM.EXCH_LOSS;
            _newPayment.STA_ID = paymentVM.STA_ID;
            _newPayment.STR_ID = paymentVM.STR_ID;
            _newPayment.EXCH_RATE_DENOM = paymentVM.EXCH_RATE_DENOM;
            _newPayment.AMT = paymentVM.AMT;
            _newPayment.CARD_IS_NEW = paymentVM.CARD_IS_NEW;
            _newPayment.CURNCY_COD = paymentVM.CURNCY_COD;
            _newPayment.DEP_LIN_COPIED_TO_REL_DOC = paymentVM.DEP_LIN_COPIED_TO_REL_DOC;
            _newPayment.EDC_AUTH_FLG = paymentVM.EDC_AUTH_FLG;
            _newPayment.EXCH_RATE_DENOM = paymentVM.EXCH_RATE_DENOM;
            _newPayment.EXCH_RATE_NUMER = paymentVM.EXCH_RATE_NUMER;
            _newPayment.FINAL_PMT = paymentVM.FINAL_PMT;
            _newPayment.gfc_authed = paymentVM.gfc_authed;
            _newPayment.HOME_CURNCY_AMT = paymentVM.HOME_CURNCY_AMT;
            _newPayment.HOME_CURNCY_ROUND_GAIN_LOSS = paymentVM.HOME_CURNCY_ROUND_GAIN_LOSS;
            _newPayment.PAY_COD_TYP = paymentVM.PAY_COD_TYP;
            _newPayment.PMT_LIN_TYP = paymentVM.PMT_LIN_TYP;
            _newPayment.PMT_SEQ_NO = paymentVM.PMT_SEQ_NO;
            _newPayment.ROUND_GAIN_LOSS = paymentVM.ROUND_GAIN_LOSS;
            _newPayment.SECURE_ECOMM_TRX = paymentVM.SECURE_ECOMM_TRX;
            _newPayment.SWIPED = paymentVM.SWIPED;
            _newPayment.TIP_AMT = paymentVM.TIP_AMT;
            _newPayment.TKT_NO = paymentVM.TKT_NO;            

            _payService.UpdatePayment(_newPayment);
            _logger.LogInformation("Payment with doc_id " + _newPayment.DOC_ID.ToString() + "successfully updated");

            return Ok(_newPayment);
        }

        [HttpDelete]
        public ActionResult DeletePayment(PaymentEntity payment)
        {
            #region Validate data
            //validate payment info
            if (payment.DOC_ID == 0)
            {
                _logger.LogError("DOC_ID info not passed.");
                return BadRequest();
            }
            if (!(ModelState.IsValid))
            {
                _logger.LogError("Required fields were not provided.");
                return BadRequest();
            }
            #endregion


            return NoContent();
        }
    }
}
