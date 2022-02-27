using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Enums;

namespace VSharp.Entities.User
{
    public class UserPersonalViews
    {
        [JsonProperty("political")]
        public PoliticalView? PoliticalView { get; set; }
        
        [JsonProperty("langs")]
        public List<string>? Languages { get; set; }
        
        [JsonProperty("religion")]
        public string? Religion { get; set; }
        
        [JsonProperty("inspired_by")]
        public string? InspiredBy { get; set; }
        
        [JsonProperty("people_main")]
        public PersonMainQualities? PeopleMainQualities { get; set; }
        
        [JsonProperty("life_main")]
        public PersonalPriority? MainLifePriority { get; set; }
        
        [JsonProperty("smoking")]
        public ViewOnSmoking? ViewOnSmoking { get; set; }
        
        [JsonProperty("alcohol")]
        public ViewOnAlcohol? ViewOnAlcohol { get; set; }
    }
}