﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitfinexApi
{

    public class Fee
    {

        [JsonProperty("pairs")]
        public string Pairs { get; set; }

        [JsonProperty("maker_fees")]
        public string MakerFees { get; set; }

        [JsonProperty("taker_fees")]
        public string TakerFees { get; set; }
    }

}