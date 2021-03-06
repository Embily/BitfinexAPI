﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitfinexApi
{

    public class SummaryResponse
    {

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("trade_vol_30d")]
        public TradeVol30d[] TradeVol30d { get; set; }

        [JsonProperty("funding_profit_30d")]
        public FundingProfit30d[] FundingProfit30d { get; set; }

        [JsonProperty("maker_fee")]
        public double MakerFee { get; set; }

        [JsonProperty("taker_fee")]
        public double TakerFee { get; set; }
    }

}
