using System;
using TailBlazor.Table;

namespace TailBlazor.TabsServer.Data
{
    public class WeatherForecast : ITailBlazorTableModel
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string RowClass => "";

        public string ChildRowClass => "";

        public bool ShowChildTemplate => false;
    }
}
