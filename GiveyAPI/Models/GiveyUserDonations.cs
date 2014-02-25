using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GiveyAPI.Models
{
    [DataContract]
    public class GiveyUserDonation
    {
        [DataMember]
        public Meta meta { get; set; }
        [DataMember]
        public List<Donation> donations { get; set; }
    }

    public class Meta
    {
        public int count { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }


    public class User
    {
        public int id { get; set; }
        public string givey_tag { get; set; }
        public string short_name { get; set; }
        public bool employee_match_exists { get; set; }
        public bool employee_target_match_exists { get; set; }
        public string twitter_nickname { get; set; }
        public bool business_confirmed { get; set; }
        public string avatar_thumb_url { get; set; }
        public string node_type { get; set; }
        public Business business { get; set; }
    }

    public class Charity
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

    public class Channel
    {
        public int id { get; set; }
        public string givey_tag { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string avatar_url { get; set; }
        public bool active { get; set; }
        public string avatar_thumb_url { get; set; }
        public string node_type { get; set; }
        public Charity charity { get; set; }
    }

    public class GiverTarget
    {
        public int id { get; set; }
        public string givey_tag { get; set; }
        public string short_name { get; set; }
        public bool employee_match_exists { get; set; }
        public bool employee_target_match_exists { get; set; }
        public string twitter_nickname { get; set; }
        public bool business_confirmed { get; set; }
        public string avatar_thumb_url { get; set; }
        public string node_type { get; set; }
        public Business business { get; set; }
    }

    public class Story
    {
        public object content_title { get; set; }
        public string content_text { get; set; }
        public string id { get; set; }
        public string created_at { get; set; }
        public string activity_asset_url { get; set; }
        public string activity_asset_square_url { get; set; }
        public string activity_asset_thumb_url { get; set; }
    }

    public class AppliedRule
    {
        public int amount { get; set; }
        public string business_id { get; set; }
        public string business_name { get; set; }
        public string business_thumb_url { get; set; }
    }

    public class Donation
    {
        public int id { get; set; }
        public string currency { get; set; }
        public object type { get; set; }
        public string donation_string_textile { get; set; }
        public string donation_string_share { get; set; }
        public string donation_string_plain_text { get; set; }
        public List<string> donation_images_textile { get; set; }
        public string activity_id { get; set; }
        public string canonical_url { get; set; }
        public int amount { get; set; }
        public string created_at { get; set; }

        public DateTime created_at_dt
        {
            get
            {
                return Convert.ToDateTime(created_at.Substring(0, 10));
            }
        }
        public string donated_at { get; set; }
        public string node_type { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_thumb_url { get; set; }
        public bool any_stories { get; set; }
        public string stream_thumb_url { get; set; }
        public string charity_name { get; set; }
        public string charity_id { get; set; }
        public GiveyUser user { get; set; }
        public Charity charity { get; set; }
        public Channel channel { get; set; }
        public GiverTarget giver_target { get; set; }
        public Story story { get; set; }
        public string giver_target_id { get; set; }
        public string giver_target_name { get; set; }
        public string giver_target_thumb_url { get; set; }
        public string channel_id { get; set; }
        public string channel_name { get; set; }
        public string channel_givey_tag { get; set; }
        public int? combined_amount { get; set; }
        public List<AppliedRule> applied_rules { get; set; }
    }
}