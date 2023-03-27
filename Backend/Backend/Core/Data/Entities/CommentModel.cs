using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Core.Data.Entities
{
    [Table("Comments")]
    public class CommentModel
    {
        [Key]
        public Guid CommentId { get; set; }
        public String UserId { get; set; }
        public String ContentId { get; set; }
        public String Comment { get; set; }

    }
}
