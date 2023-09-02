using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpte03.RazorPages.Models {
    public class FeedbackModel {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdFeedback { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        [Required(ErrorMessage = "Data é obrigatória")]
        [DisplayFormat(DataFormatString ="{0:dd MMM yyyy}")]
        public DateTime? DataFeedback { get; set; }
        [Required(ErrorMessage = "Comentário é obrigatório")]
        public string? Comentario { get; set; }
        [Required(ErrorMessage = "Avaliação é obrigatória")]
        public int? Avaliacao { get; set; }
    }
}