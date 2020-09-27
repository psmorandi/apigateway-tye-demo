namespace Frontend.DTO
{
    using System;

    public class WeatherDto
    {
        public DateTime Date { get; set; }

        public string Summary { get; set; }

        public int TemperatureC { get; set; }
    }
}