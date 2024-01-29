using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toptal_screening
{
    public partial class Order
    {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("order_number")]
        public long OrderNumber { get; set; }

        [JsonProperty("customer_id")]
        public long CustomerId { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("seller_id")]
        public long SellerId { get; set; }

        [JsonProperty("seller_name")]
        public string SellerName { get; set; }

        [JsonProperty("order_items")]
        public OrderItem[] OrderItems { get; set; }

        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        [JsonProperty("loyalty_points")]
        public long LoyaltyPoints { get; set; }

        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatus { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class OrderItem
    {
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_category")]
        public ProductCategory ProductCategory { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
    }

    public partial class ShippingAddress
    {
        [JsonProperty("line")]
        public string Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public enum ProductCategory { Electronics, Grocery, HomeAppliances, PowerTools };
}
