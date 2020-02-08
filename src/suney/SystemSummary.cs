public class SystemSummary
{
    public int system_id { get; set; }
    public int modules { get; set; }
    public int size_w { get; set; }
    public int current_power { get; set; }
    public int energy_today { get; set; }
    public int energy_lifetime { get; set; }
    public string summary_date { get; set; }
    public string source { get; set; }
    public string status { get; set; }
    public int operational_at { get; set; }
    public int last_report_at { get; set; }
    public int last_interval_end_at { get; set; }
}