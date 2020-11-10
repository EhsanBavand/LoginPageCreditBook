using LoginPageAspNetCorEF_SQL.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPageAspNetCorEF_SQL.Models
{
    public partial class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Thisa Filed isRequred.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }



        [ForeignKey("User"), Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        //public override string ToString()
        //{
        //    return string.Format("id {0} Make and Model {1}, Year of production {2}", ItemId, Title, Description);
        //}


    }
}
