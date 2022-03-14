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

        public int Id { get; set; }


        public string Name { get; set; }
        public int Number { get; set; }
        public string City { get; set; }

    }
}
