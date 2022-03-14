using MVC1.Models;
using System.Collections.Generic;
namespace MVC1.ViewModels
{
    public class PersonViewModel
    {

        public PersonViewModel(List<PeopleData> PeopleDataList) {
            this.PeopleDataList = PeopleDataList;
        }

        public List<PeopleData> PeopleDataList{ get; set; }
        
    }
}
