using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class PeopleData
    {

        public PeopleData(int id, string name, int number, string city)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.City = city;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string City { get; set; }

    }
}
