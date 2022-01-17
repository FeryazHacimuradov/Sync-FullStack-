using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_FullStack_.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string MainTitle { get; set; }
        [MaxLength(500)]
        public string MainContent { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(250)]
        public string FooterTitle { get; set; }
        [MaxLength(250)]
        public string FooterContent { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
    }
}
