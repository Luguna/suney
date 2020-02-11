using System;
using Newtonsoft.Json;
public class SystemSummary
{
    [JsonProperty("system_id")]
    public int SystemId { get; set; }
    [JsonProperty("modules")]
    public int Modules { get; set; }
    [JsonProperty("size_w")]
    public int SizeW { get; set; }
    [JsonProperty("current_power")]
    public int CurrentPower { get; set; }
    [JsonProperty("energy_today")]
    public int EnergyToday { get; set; }
    [JsonProperty("energy_lifetime")]
    public int EnergyLifetime { get; set; }
    [JsonProperty("summary_date")]
    public DateTime SummaryDate { get; set; }
    [JsonProperty("source")]
    public string Source { get; set; }
    [JsonProperty("status")]
    public string Status { get; set; }
    [JsonProperty("operational_at")]
    public DateTime OperationalAt { get; set; }
    [JsonProperty("last_report_at")]
    public DateTime LastReportAt { get; set; }
    [JsonProperty("last_interval_end_at")]
    public DateTime LastIntervalEndAt { get; set; }
}