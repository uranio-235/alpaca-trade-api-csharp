﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionSide
    {
        [EnumMember(Value = "long")]
        Long,

        [EnumMember(Value = "short")]
        Short
    }
}