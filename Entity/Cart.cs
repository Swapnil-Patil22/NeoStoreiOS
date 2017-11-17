using System;
using Newtonsoft.Json;

namespace NeoStore.Entity
{
    public class Cart
    {
        public Cart()
        {
        }

        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }

        [JsonProperty(PropertyName = "count")]
        public string Count { get; set; }

        [JsonProperty(PropertyName = "total")]
        public string Total { get; set; }

        public Product Product { get; set; }

    }
}
