using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RapidPOSWebApiNet6.Data.Models
{
    public class CustomerEntity
    {
        [Key]
        public string? CUST_NO { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        public string? NAM { get; set; }
        [DisplayName("First Name")]
        public string? FST_NAM { get; set; }
        [DisplayName("Last Name")]
        public string? LST_NAM { get; set; }
        [DisplayName("Address 1")]
        public string? ADRS_1 { get; set; }
        [DisplayName("Address 2")]
        public string? ADRS_2 { get; set; }
        [DisplayName("Address 3")]
        public string? ADRS_3 { get; set; }
        [DisplayName("City")]
        public string? CITY { get; set; }
        [DisplayName("State")]
        public string? STATE { get; set; }
        [DisplayName("Zip Code")]
        public string? ZIP_COD { get; set; }
        [DisplayName("Country")]
        public string? CNTRY { get; set; }
        [DisplayName("Phone")]
        public string? PHONE { get; set; }
        [DisplayName("Contact")]
        public string? CONTCT { get; set; }
        [DisplayName("Email Address")]
        public string? EMAIL_ADRS { get; set; }
        [Required]
        [DisplayName("Store Id")]
        public string? STR_ID { get; set; }
        [DisplayName("Comment")]
        public string? COMMNT { get; set; }
        [Required]
        [DisplayName("No. of Transactions")]
        public int NO_OF_TRANSACTIONS { get; set; }
        [DisplayName("First Sale Date")]
        public DateTime? FST_SAL_DAT { get; set; }
        [DisplayName("Last Sale Date")]
        public DateTime? LST_SAL_DAT { get; set; }
        [DisplayName("Last Sale Amount")]
        public decimal? LST_SAL_AMT { get; set; }
        public DateTime? LST_MAINT_DT { get; set; }
        public string? LST_MAINT_USR_ID { get; set; }
    }
}
