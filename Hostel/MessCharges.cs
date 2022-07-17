using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostel
{
    public class MessCharges
    {
        [Key]
        public int Id { get; set; }
        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public Member Member { get; set; }
        [Required]
        public int Charges { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
    }
}