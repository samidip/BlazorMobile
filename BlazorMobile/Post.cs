using System;
using Newtonsoft.Json;

namespace BlazorMobile
{
    public class Post
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserID { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        public Post() { }
    }
}
