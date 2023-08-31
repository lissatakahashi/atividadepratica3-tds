using System.ComponentModel.DataAnnotations;

namespace tpte03.RazorPages.Models {
    public class FeedbackModel {
        [Key]
        public int? IdFeedback { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public DateTime DataFeedback { get; set; }
        public string? Comentario { get; set; }
        public int? Avaliacao { get; set; }
    }
}