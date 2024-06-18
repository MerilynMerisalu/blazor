using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class CreateEditPersonViewModel
    {
        [Required]
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
