using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GiveyAPI.Models
{
    [DataContract]
    public class GiveyUser
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string givey_tag { get; set; }
        [DataMember]
        public string first_name { get; set; }
        [DataMember]
        public string last_name { get; set; }
        [DataMember]
        public string short_name { get; set; }
        [DataMember]
        public string avatar_url { get; set; }
        [DataMember]
        public int givey_score { get; set; }
        [DataMember]
        public int money_total { get; set; }
        [DataMember]
        public int voice_total { get; set; }
        [DataMember]
        public int time_total { get; set; }
        [DataMember]
        public int stuff_total { get; set; }
        [DataMember]
        public string currency { get; set; }
        [DataMember]
        public string biography { get; set; }
        [DataMember]
        public string interests { get; set; }
        [DataMember]
        public string location { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string occupation { get; set; }
        [DataMember]
        public string website_url { get; set; }
        [DataMember]
        public bool employee_match_exists { get; set; }
        [DataMember]
        public bool employee_target_match_exists { get; set; }
        [DataMember]
        public int business_id { get; set; }
        [DataMember]
        public bool business_confirmed { get; set; }
        [DataMember]
        public string personal_message { get; set; }
        [DataMember]
        public string twitter_nickname { get; set; }
        [DataMember]
        public string avatar_thumb_url { get; set; }
        [DataMember]
        public string node_type { get; set; }
        [DataMember]
        public object channel { get; set; }
        [DataMember]
        public List<object> channels { get; set; }
        [DataMember]
        public SelectedCharity selected_charity { get; set; }
        [DataMember]
        public Business business { get; set; }
    }
    public class SelectedCharity
    {
        public int id { get; set; }
        public string givey_tag { get; set; }
        public string name { get; set; }
        public string info_description { get; set; }
        public string avatar_url { get; set; }
        public string description { get; set; }
        public string avatar_thumb_url { get; set; }
        public string node_type { get; set; }
    }

    public class Business
    {
        public int id { get; set; }
        public string givey_tag { get; set; }
        public string name { get; set; }
        public object about { get; set; }
        public string avatar_url { get; set; }
        public string avatar_thumb_url { get; set; }
        public string node_type { get; set; }
    }
}