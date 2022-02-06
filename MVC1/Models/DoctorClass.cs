namespace MVC1.Models
{
    public class DoctorClass
    {
        public static string checkTemp(int temp)
        {

            if (temp >= 38)
            {
                return "Du har feber.";
            }
            else if (temp < 28)
            {
                return "Du har hypotermi.";
            }
            else
            {
                return "Du har inte feber.";
            }
        }
    }
}
