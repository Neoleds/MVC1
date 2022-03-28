using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class CityData
    {

        //public CityData(int id, string name, int countryId, CountryData countryData)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Country = countryData;
        //}

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public int CountryId { get; set; }
        [Required]
        public CountryData Country { get; set; }

    }
}
