namespace MVC1.Models
{
    public class PeopleData
    {
        public PeopleData(string name, int number, string city)
        {
            Name = name;
            Number = number;
            City = city;
            
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public string City { get; set; }

    }
}
