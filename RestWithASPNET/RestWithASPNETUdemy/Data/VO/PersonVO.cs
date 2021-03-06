using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{

    public class PersonVO : ISupportsHyperMedia
    {

        [JsonPropertyName("code")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string FirstName { get; set; }

        [JsonPropertyName("Last_name")]
        public string LastName { get; set; }

 
        public string Address { get; set; }

        [JsonPropertyName("sex")]
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
