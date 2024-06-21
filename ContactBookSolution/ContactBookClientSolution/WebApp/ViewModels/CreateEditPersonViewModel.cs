using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class CreateEditPersonViewModel
    {
        
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
