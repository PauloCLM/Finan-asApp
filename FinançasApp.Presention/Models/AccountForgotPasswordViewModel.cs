using System.ComponentModel.DataAnnotations;

namespace FinancasApp.Presentation.Models
{
    
    public class AccountForgotPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o seu email.")]
        public string? Email { get; set; }
    }
}



