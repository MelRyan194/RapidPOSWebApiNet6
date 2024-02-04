using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RapidPOSWebApiNet6.Data.Models
{
    public class SaleStoreEntity
    {
        [Key]
        [DisplayName("Store Id")]
        public string? STR_ID { get; set; }       


        //   [DESCR] [dbo].[T_LONG_DESCR]
        //       NOT NULL,
        [Required]
        [DisplayName("Description")]
        public string? DESCR { get; set; }

        //   [ADRS_1] [dbo].[T_ADRS] NULL,
        [DisplayName("Address 1")]
        public string? ADRS_1 { get; set; }

        //[ADRS_2][dbo].[T_ADRS] NULL,
        [DisplayName("Address 2")]
        public string? ADRS_2 { get; set;}

        //[ADRS_3][dbo].[T_ADRS] NULL,
        [DisplayName("Address 3")]
        public string? ADRS_3 { get; set;}

        //[CITY][dbo].[T_CITY] NULL,
        [DisplayName("City")]
        public string? CITY { get; set; }

        //[STATE][dbo].[T_STATE] NULL,
        [DisplayName("State")]
        public string? STATE { get; set;}

        //[ZIP_COD][dbo].[T_ZIP_COD] NULL,
        [DisplayName("Zip code")]
        public string? ZIP_COD { get; set;}

        //[CNTRY][dbo].[T_CNTRY] NULL,
        [DisplayName("Country")]
        public string? CNTRY { get; set; }

        //[PHONE][dbo].[T_PHONE] NULL,
        [DisplayName("Phone")]
        public string? PHONE { get; set; }

        //[CONTCT][dbo].[T_NAM] NULL,
        [DisplayName("Contact")]
        public string? CONTCT { get; set; }

        //[EMAIL_ADRS][dbo].[T_EMAIL_ADRS] NULL,
        [DisplayName("Email address")]
        public string EMAIL_ADRS { get; set; }

        //[LST_MAINT_DT][dbo].[T_DT] NULL,
        [DisplayName("Last date maintained")]
        public DateTime? LST_MAINT_DT { get; set; }

        //[LST_MAINT_USR_ID][dbo].[T_USR_ID] NULL,
        [DisplayName("Last User maintained")]
        public string? LST_MAINT_USR_ID { get; set; }

        //[STR_NO][dbo].[T_SMALLINT]
        //       NOT NULL,
        [DisplayName("Store no.")]
        public int STR_NO { get; set; }
    }
}
