using System;
using Newtonsoft.Json;

namespace NeoStore.Entity
{
    public class Product
    {
        public Product()
        {
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "product_category_id")]
        public int ProductCategoryId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "producer")]
        public string Producer { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }

        [JsonProperty(PropertyName = "view_count")]
        public int ViewCount { get; set; }

        [JsonProperty(PropertyName = "product_images")]
        public string ProductImages { get; set; }

        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public int Modified { get; set; }
    }
}
