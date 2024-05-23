using Microsoft.VisualBasic.ApplicationServices;
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

        public List<Plant> SearchInfo(string User_Name, string User_Type,
            string User_Author, string User_Maturation_Time, 
            string User_Weight, string User_Hybridity,
            string User_Frost_Resistance, string User_Expiration_Date,
            string User_Potential_Harvest, string User_Type_Pollution,
            string User_Cuboid, string User_Indeterminate,
            string User_Shape_of_Head, string User_Starch_Content)
        {
            List<Plant> rightplants = new List<Plant>();

            foreach (var item in plants)
            {
                bool extrafield_Name = string.IsNullOrEmpty(User_Name) 
                    || item.Name.Equals(User_Name, 
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Type = string.IsNullOrEmpty(User_Type)
                    || item.Type.Equals(User_Type,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Author = string.IsNullOrEmpty(User_Author)
                    || item.Author.Equals(User_Author,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_MaturationTime = string.IsNullOrEmpty(User_Maturation_Time) 
                    || item.Maturation_Time.Equals(User_Maturation_Time,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Weight = string.IsNullOrEmpty(User_Weight) 
                    || item.Weight.Equals(User_Weight,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Hybridity = string.IsNullOrEmpty(User_Hybridity) 
                    || item.Hybridity.Equals(User_Hybridity,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Frost_Resistance = string.IsNullOrEmpty(User_Frost_Resistance)
                    || item.Frost_Resistance.Equals(User_Frost_Resistance, 
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_ExpirationDate = string.IsNullOrEmpty(User_Expiration_Date) 
                    || item.Expiration_Date.Equals(User_Expiration_Date, 
                    StringComparison.OrdinalIgnoreCase);
                
                bool extrafield_Potential_Harvest = string.IsNullOrEmpty(User_Potential_Harvest) 
                    || string.Equals(item.Potential_Harvest, User_Potential_Harvest,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_TypePollution = string.IsNullOrEmpty(User_Type_Pollution) 
                    || string.Equals(item.Type_of_Pollution, User_Type_Pollution,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Cuboid = string.IsNullOrEmpty(User_Cuboid) 
                    || string.Equals(item.Is_Cuboid, User_Cuboid,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Indeterminate = string.IsNullOrEmpty(User_Indeterminate) 
                    || string.Equals(item.Is_Indeterminate, User_Indeterminate,
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_ShapeHead = string.IsNullOrEmpty(User_Shape_of_Head)
                    || string.Equals(item.Shape_of_Head, User_Shape_of_Head, 
                    StringComparison.OrdinalIgnoreCase);

                bool extrafield_Starch_Content = string.IsNullOrEmpty(User_Starch_Content) 
                    || string.Equals(item.Starch_Content, User_Starch_Content, 
                    StringComparison.OrdinalIgnoreCase);

                if (extrafield_Name && extrafield_Type && extrafield_Author
                    && extrafield_MaturationTime && extrafield_Weight && 
                    extrafield_Hybridity && extrafield_Frost_Resistance &&
                    extrafield_ExpirationDate && extrafield_Potential_Harvest 
                    && extrafield_TypePollution && extrafield_Cuboid &&
                    extrafield_Indeterminate && extrafield_ShapeHead &&
                    extrafield_Starch_Content)
                {
                    rightplants.Add(item);
                }
            }
            return rightplants;
        }
    }
}
