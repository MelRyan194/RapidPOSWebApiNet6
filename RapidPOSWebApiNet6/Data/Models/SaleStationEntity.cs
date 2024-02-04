using System.ComponentModel.DataAnnotations;

namespace RapidPOSWebApiNet6.Data.Models
{
    public class SaleStationEntity
    {
        [Key]
        public int STR_ID { get; set; }
        //       [STR_ID][dbo].[T_COD]
        //       NOT NULL,

        [Key]
        public string? STA_ID { get; set; }
        //    [STA_ID] [dbo].[T_COD]
        //       NOT NULL,

        [Required]
        public int DESCR { get; set; }
        //    [DESCR] [dbo].[T_DESCR]
        //       NOT NULL,

        public DateTime? LST_MAINT_DT { get; set; }
        //    [LST_MAINT_DT] [dbo].[T_DT] NULL,

        public string? LST_MAINT_USR_ID { get; set; }
        //[LST_MAINT_USR_ID][dbo].[T_USR_ID] NULL,

        [Required]
        public int STA_NO { get; set; }
        //[STA_NO][dbo].[T_SMALLINT]
        //       NOT NULL,
    }
}
