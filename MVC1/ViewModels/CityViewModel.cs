using MVC1.Models;
using System.Collections.Generic;
namespace MVC1.ViewModels
{
    public class CityViewModel
    {

        public CityViewModel(List<CityData> CityDataList)
        {
            this.CityDataList = CityDataList;
        }

        public List<CityData> CityDataList { get; set; }

    }
}
