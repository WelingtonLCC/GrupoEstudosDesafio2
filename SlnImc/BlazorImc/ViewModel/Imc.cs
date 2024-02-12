using System.ComponentModel.DataAnnotations;

namespace BlazorImc.ViewModel
{
    public class Imc
    {
        [Required]
        [Range(0.0001, double.MaxValue, ErrorMessage = "a altura deve ser maior que zero.")]
        public double Altura { get; set; }
        [Required]
        [Range(0.0001, double.MaxValue, ErrorMessage = "o peso deve ser maior que zero.")]
        public double Peso { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "O Sexo deve ter pelo menos 8 caracteres.")]
        [MaxLength(9, ErrorMessage = "O Sexo deve ter no máximo 19 caracteres.")]
        public string Sexo { get; set; } = string.Empty;
        public bool Idoso { get; set; }
    }
}
