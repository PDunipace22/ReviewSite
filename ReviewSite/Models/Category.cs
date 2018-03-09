using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name ="Category")]
        public string Name { get; set; }
        //Navigation Property
        public virtual ICollection<Review> Reviews { get; set; }
    }
}