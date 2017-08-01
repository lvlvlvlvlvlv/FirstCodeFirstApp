using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{

    //[Table("Donator")]
    //public class Donator
    //{
    //    [Key]
    //    [Column("Id")]
    //    public int DonatorId { get; set; }
    //    [StringLength(10,MinimumLength =2)]
    //    public string Name { get; set; }
    //    public decimal Amount { get; set; }
    //    public DateTime DonateDate { get; set; }
    //}
   
    public class Donator
    {
       
        public int DonatorId { get; set; }
       
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
    }
}
