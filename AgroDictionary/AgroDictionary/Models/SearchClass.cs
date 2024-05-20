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
                
                bool extrafield_MaturationTime = string.IsNullOrEmpty(User_Maturation_Time) || item.Maturation_Time.Equals(User_Maturation_Time, StringComparison.OrdinalIgnoreCase);
                bool extrafield_Weight = string.IsNullOrEmpty(User_Weight) || item.Weight.Equals(User_Weight, StringComparison.OrdinalIgnoreCase);
                bool extrafield_Hybridity = string.IsNullOrEmpty(User_Hybridity) || item.Hybridity.Equals(User_Hybridity, StringComparison.OrdinalIgnoreCase);
                bool extrafield_ExpirationDate = string.IsNullOrEmpty(User_Expiration_Date) || item.Expiration_Date.Equals(User_Expiration_Date, StringComparison.OrdinalIgnoreCase);

                if (item.Name.Equals(User_Name, StringComparison.OrdinalIgnoreCase) && item.Type.Equals(User_Type, StringComparison.OrdinalIgnoreCase) && extrafield_MaturationTime && extrafield_Weight && extrafield_Hybridity && extrafield_ExpirationDate)
                {
                    rightplants.Add(item);
                }
            }
            return rightplants;
        }
    }
}
