using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class CountryData
    {
        public CountryData(int id, string name, List<CityData> CityList )
        {
            this.Id = id;
            this.Name = name;
            this.CityList = CityList;


        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public List<CityData> CityList { get; set; }
    }
}
