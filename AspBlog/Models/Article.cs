using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vyplňte obsah")]

        [DisplayName("Kontent")]
        public string Content { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte titulek")]
        [StringLength(100, ErrorMessage = "Titulek je příliš dlouhý")]

        [DisplayName("Titulek")]
        public string Title { get; set; } = "";
        [Required(ErrorMessage = "Vyplňte popisek")]

        [DisplayName("Popis")]
        public string Description { get; set; } = "";
    }
}
