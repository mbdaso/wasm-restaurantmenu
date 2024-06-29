﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace site.Components.Menu
{
    public class MenuContent
    {
        public static Menu Create()
        {
            var result =  JsonConvert.DeserializeObject<Menu>(
                @"
{
  ""categories"": [
    {
      ""name"": ""Hamburguesas"",
      ""priceCategories"": [ ""pequeño"", ""mediano"", ""grande"" ],
      ""items"": [
        {
          ""name"": ""Normal"",
          ""description"": ""Carne de vaca, queso, tomate, lechuga, cebolla y 3 salsas"",
          ""prices"": {
            ""pequeño"": ""2.50"",
            ""mediano"": ""3.00"",
            ""grande"": ""3.50""
          }
        },
        {
          ""name"": ""Completa"",
          ""description"": ""Carne de vaca, queso, tomate, lechuga, cebolla, fritas y 3 salsas"",
          ""prices"": {
            ""pequeño"": ""3.50"",
            ""mediano"": ""4.00"",
            ""grande"": ""4.50""
          }
        }
      ]
    },
    {
      ""name"": ""Hamburguesas Vegetales Caseras"",
      ""priceCategories"": [ ""unica"" ],
      ""items"": [
        {
          ""name"": ""Soja"",
          ""description"": ""Tomate, lechuga, pepino, cebolla y 3 salsas"",
          ""prices"": {
            ""unica"": ""3.00""
          }
        },
        {
          ""name"": ""Espinacas"",
          ""description"": ""Tomate, lechuga, cebolla y 3 salsas"",
          ""prices"": {
            ""unica"": ""3.00""
          }
        }
      ]
    },
    {
      ""name"": ""Perritos Calientes"",
      ""priceCategories"": [ ""normal"", ""pollo"", ""mechada"" ],
      ""items"": [
        {
          ""name"": ""Normal"",
          ""description"": ""Salchicha, cebolla y 3 salsas"",
          ""prices"": {
            ""normal"": ""2.50"",
            ""frito"": ""2.50"",
            ""mechado"": ""2.50""
          }
        },
        {
          ""name"": ""Frito"",
          ""description"": ""Salchicha, queso, cebolla frita y 3 salsas"",
          ""prices"": {
            ""frito"": ""3.00""
          }
        },
        {
          ""name"": ""Mechado"",
          ""description"": ""Salchicha, cebolla y 3 salsas"",
          ""prices"": {
            ""mechado"": ""3.50""
          }
        }
      ]
    },
    {
      ""name"": ""Sandwiches"",
      ""priceCategories"": [ ""mixto"", ""elegir"" ],
      ""items"": [
        {
          ""name"": ""Mixto"",
          ""description"": ""Jamón y queso"",
          ""prices"": {
            ""mixto"": ""2.50""
          }
        },
        {
          ""name"": ""Para Elegir (Instruir)"",
          ""description"": ""Pavo, lomo, ternera, pechuga, bacon, jamón york, queso, tomate, lechuga, cebolla y salsas al gusto"",
          ""prices"": {
            ""elegir"": ""4.00""
          }
        }
      ]
    },
    {
      ""name"": ""Zumos, Batidos y Milkshakes"",
      ""priceCategories"": [ ""pequeño"", ""mediano"", ""grande"" ],
      ""items"": [
        {
          ""name"": ""Zumo"",
          ""description"": ""Naranja pequeño, mediano, grande"",
          ""prices"": {
            ""pequeño"": ""2.50"",
            ""mediano"": ""2.80"",
            ""grande"": ""3.00""
          }
        },
        {
          ""name"": ""Milkshake"",
          ""description"": ""Vainilla, chocolate, fresa"",
          ""prices"": {
            ""pequeño"": ""3.50"",
            ""mediano"": ""4.00"",
            ""grande"": ""4.50""
          }
        }
      ]
    }
  ]
}

"
                ) ?? throw new JsonReaderException();
            return result;
        }
    }
}
