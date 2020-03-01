using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace suney
{
    public class Interval
    {
        [JsonProperty("end_at")]
        public DateTime EndAt { get; set; }
        [JsonProperty("powr")]
        public int PowerW { get; set; }
        [JsonProperty("devices_reporting")]
        public int DevicesReporting { get; set; }
        [JsonProperty("enwh")]
        public int EnergyWh { get; set; }
    }

    public class Meta
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("last_report_at")]
        public DateTime LastReportAt { get; set; }
        [JsonProperty("last_energy_at")]
        public DateTime LastEnergyAt { get; set; }
        [JsonProperty("operational_at")]
        public DateTime OperationalAt { get; set; }
    }

    public class ConsumptionStats
    {
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
        [JsonProperty("total_devices")]
        public int TotalDevices { get; set; }
        [JsonProperty("intervals")]
        public List<Interval> Intervals { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class ProductionStats
    {
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
        [JsonProperty("total_devices")]
        public int TotalDevices { get; set; }
        [JsonProperty("intervals")]
        public List<Interval> Intervals { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}