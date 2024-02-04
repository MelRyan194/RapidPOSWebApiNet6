using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RapidPOSWebApiNet6.Data.ViewModels
{
    public class PaymentVM
    {
        [Key]
        [DisplayName("Doc Id")]
        public Int64 DOC_ID { get; set; }

        [Key]
        [DisplayName("Payment secq no.")]
        public int PMT_SEQ_NO { get; set; }

        //[DisplayName("Card no.")]
        //public string? CARD_NO { get; set; }

        [Required]
        [DisplayName("Payment code type")]
        public string? PAY_COD_TYP { get; set; }

        [Required]
        [DisplayName("Payment amount")]
        public decimal AMT { get; set; }

        [Required]
        [DisplayName("Store Id")]
        public string? STR_ID { get; set; }

        [Required]
        [DisplayName("Is final payment?")]
        public string? FINAL_PMT { get; set; }

        [Required]
        [DisplayName("Store area Id")]
        public string? STA_ID { get; set; }

        [Required]
        [DisplayName("Is new card?")]
        public string? CARD_IS_NEW { get; set; }

        [Required]
        [DisplayName("Ticket no.")]
        public string? TKT_NO { get; set; }

        [Required]
        [DisplayName("Is E-comm secure?")]
        public string? SECURE_ECOMM_TRX { get; set; }

        [Required]
        [DisplayName("Payment line type")]
        public string? PMT_LIN_TYP { get; set; }

        //[DisplayName("Payment code")]
        //public string? PAY_COD { get; set; }

        //[DisplayName("Payment date")]
        //public DateTime? PAY_DAT { get; set; }

        [Required]
        [DisplayName("Is dept Line copied")]
        public string? DEP_LIN_COPIED_TO_REL_DOC { get; set; }

        [Required]
        [DisplayName("Home currency amount")]
        public decimal HOME_CURNCY_AMT { get; set; }

        [Required]
        [DisplayName("Exchange loss")]
        public decimal EXCH_LOSS { get; set; }

        [Required]
        [DisplayName("Is swiped?")]
        public string? SWIPED { get; set; }

        //[DisplayName("EDC authentication dode")]
        //public string? EDC_AUTH_COD { get; set; }

        //[DisplayName("Description")]
        //public string? DESCR { get; set; }

        [Required]
        [DisplayName("EDC authentication flag")]
        public string? EDC_AUTH_FLG { get; set; }

        [Required]
        [DisplayName("Currency code")]
        public string? CURNCY_COD { get; set; }

        //[DisplayName("EBT balance remaining")]
        //public decimal? EBT_BAL_REMAIN { get; set; }

        [Required]
        [DisplayName("Exchange rate")]
        public decimal EXCH_RATE_NUMER { get; set; }

        [Required]
        [DisplayName("Exchange rate denomination")]
        public decimal EXCH_RATE_DENOM { get; set; }

        //[DisplayName("Loyalty points redeemable")]
        //public int? loy_pts_rdm { get; set; }

        //[DisplayName("Service balance remaining")]
        //public decimal? SVC_BAL_REMAIN { get; set; }

        //[DisplayName("Service reference no.")]
        //public string? SVC_REF_NO { get; set; }

        //[DisplayName("EDC authentication response")]
        //public string? EDC_AUTH_RESP { get; set; }

        [Required]
        [DisplayName("Round gain/loss")]
        public decimal? ROUND_GAIN_LOSS { get; set; }

        [Required]
        [DisplayName("Home currency round gain/loss")]
        public decimal? HOME_CURNCY_ROUND_GAIN_LOSS { get; set; }

        [Required]
        [DisplayName("Tip amount Id")]
        public decimal? TIP_AMT { get; set; }

        [Required]
        [DisplayName("Is GFC authenticated?")]
        public string? gfc_authed { get; set; }
    }
}
