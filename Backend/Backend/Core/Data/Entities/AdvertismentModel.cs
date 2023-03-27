using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Core.Data.Entities
{

    [Table("Advertisements")]       
    public class AdvertisementModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        public Guid AdvertisementId { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Please Enter The Title")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please Enter The Content")]
        public string Content { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [DefaultValue(false)]

        public bool IsDeleted { get; set; }
        [ForeignKey("Users")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserModel? User { get; set; }
    }
}
