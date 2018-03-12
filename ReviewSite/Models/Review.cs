using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Title { get; set; }
        [Range(1,10)]// The rating can only be numbers 1 through 10
        public int Rating { get; set; }
        public string Author { get; set; }
        [Display(Name ="Date Published")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PublishedDate { get; set; }
        public string Content { get; set; }
        
        //Foreign Key and Navigation Property
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}