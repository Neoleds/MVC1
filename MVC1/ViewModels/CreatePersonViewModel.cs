using System.ComponentModel.DataAnnotations;

namespace MVC1.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull= false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Number { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string City { get; set; }
    }
}
