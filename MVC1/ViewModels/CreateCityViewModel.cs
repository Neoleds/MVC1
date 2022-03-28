using System.ComponentModel.DataAnnotations;

namespace MVC1.ViewModels
{
    public class CreateCityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
