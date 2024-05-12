using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class SearchClass
    {
        private List<Plant> plants;
        public void Load_Data_From_JSON(string fileJSON)
        {
            string jsondata = File.ReadAllText(fileJSON);
            plants = JsonConvert.DeserializeObject<List<Plant>>(jsondata);
        }

        public List<Plant> SearchInfo(string User_Name, string User_Type, string User_Maturation_Time, string User_Weight, string User_Hybridity, string User_Expiration_Date)
        {
            List<Plant> rightplants = new List<Plant>();

            foreach (var item in plants)
            {
                if (item.Name.Equals(User_Name, StringComparison.OrdinalIgnoreCase) && item.Type.Equals(User_Type, StringComparison.OrdinalIgnoreCase) && item.Maturation_Time.Equals(User_Maturation_Time, StringComparison.OrdinalIgnoreCase) && item.Weight.Equals(User_Weight, StringComparison.OrdinalIgnoreCase) && item.Hybridity.Equals(User_Hybridity, StringComparison.OrdinalIgnoreCase) && item.Expiration_Date.Equals(User_Expiration_Date, StringComparison.OrdinalIgnoreCase))
                {
                    rightplants.Add(item);
                }
            }
            return rightplants;
        }
    }
}
