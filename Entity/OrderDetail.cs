using System;
using Newtonsoft.Json;

namespace NeoStore.Entity
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public int ProductId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "prod_name")]
        public string ProductName { get; set; }

        [JsonProperty(PropertyName = "prod_cat_name")]
        public int productCategoryName { get; set; }

        [JsonProperty(PropertyName = "prod_image")]
        public int ProductImage { get; set; }

    }
}
