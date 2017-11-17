using System;
using Newtonsoft.Json;

namespace NeoStore.Entity
{
    public class Order
    {
        public Order()
        {
        }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int   Id { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        public OrderDetail OrderDetails { get; set; }

    }
}
