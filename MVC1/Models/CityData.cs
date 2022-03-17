using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class CityData
    {

        public CityData(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 

    }
}
