using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WetterApp.Models
{
    public class Realtime
    {
        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; set; } = string.Empty;

        [JsonPropertyName("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }

        [JsonPropertyName("temp_c")]
        public decimal TempC { get; set; }

        [JsonPropertyName("temp_f")]
        public decimal TempF { get; set; }

        [JsonPropertyName("feelslike_c")]
        public decimal FeelslikeC { get; set; }

        [JsonPropertyName("feelslike_f")]
        public decimal FeelslikeF { get; set; }

        [JsonPropertyName("windchill_c")]
        public decimal WindchillC { get; set; }

        [JsonPropertyName("windchill_f")]
        public decimal WindchillF { get; set; }

        [JsonPropertyName("heatindex_c")]
        public decimal HeatindexC { get; set; }

        [JsonPropertyName("heatindex_f")]
        public decimal HeatindexF { get; set; }

        [JsonPropertyName("dewpoint_c")]
        public decimal DewpointC { get; set; }

        [JsonPropertyName("dewpoint_f")]
        public decimal DewpointF { get; set; }

        [JsonPropertyName("condition:text")]
        public string ConditionText { get; set; } = string.Empty;

        [JsonPropertyName("condition:icon")]
        public string ConditionIcon { get; set; } = string.Empty;

        [JsonPropertyName("condition:code")]
        public int ConditionCode { get; set; }

        [JsonPropertyName("wind_mph")]
        public decimal WindMph { get; set; }

        [JsonPropertyName("wind_kph")]
        public decimal WindKph { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; } = string.Empty;

        [JsonPropertyName("pressure_mb")]
        public decimal PressureMb { get; set; }

        [JsonPropertyName("pressure_in")]
        public decimal PressureIn { get; set; }

        [JsonPropertyName("precip_mm")]
        public decimal PrecipMm { get; set; }

        [JsonPropertyName("precip_in")]
        public decimal PrecipIn { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloud")]
        public int Cloud { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("uv")]
        public decimal Uv { get; set; }

        [JsonPropertyName("gust_mph")]
        public decimal GustMph { get; set; }

        [JsonPropertyName("gust_kph")]
        public decimal GustKph { get; set; }

    }
}
