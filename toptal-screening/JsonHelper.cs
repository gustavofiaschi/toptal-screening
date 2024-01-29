﻿// <auto-generated />
// https://app.quicktype.io/
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var jsonModel = JsonModel.FromJson(jsonString);

namespace toptal_screening
{
    using System;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Order
    {
        public static Order[] FromJson(string json) => JsonConvert.DeserializeObject<Order[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Order[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ProductCategoryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ProductCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProductCategory) || t == typeof(ProductCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Electronics":
                    return ProductCategory.Electronics;
                case "Grocery":
                    return ProductCategory.Grocery;
                case "Home Appliances":
                    return ProductCategory.HomeAppliances;
                case "Power Tools":
                    return ProductCategory.PowerTools;
            }
            throw new Exception("Cannot unmarshal type ProductCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProductCategory)untypedValue;
            switch (value)
            {
                case ProductCategory.Electronics:
                    serializer.Serialize(writer, "Electronics");
                    return;
                case ProductCategory.Grocery:
                    serializer.Serialize(writer, "Grocery");
                    return;
                case ProductCategory.HomeAppliances:
                    serializer.Serialize(writer, "Home Appliances");
                    return;
                case ProductCategory.PowerTools:
                    serializer.Serialize(writer, "Power Tools");
                    return;
            }
            throw new Exception("Cannot marshal type ProductCategory");
        }

        public static readonly ProductCategoryConverter Singleton = new ProductCategoryConverter();
    }
}
