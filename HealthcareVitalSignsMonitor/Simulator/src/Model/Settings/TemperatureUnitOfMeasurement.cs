namespace Simulator.src.Model.Settings
{
    public enum TemperatureUnitOfMeasurement
    {
        CELSIUS,
        FAHRENHEIT,
        KELVIN
    }

    public static class TemperatureUnitOfMeasurementExtension
    {
        public static string Label(this TemperatureUnitOfMeasurement unitOfMeasurement)
        {
            var uom = unitOfMeasurement switch
            {
                TemperatureUnitOfMeasurement.CELSIUS => "°C (Celsius)",
                TemperatureUnitOfMeasurement.FAHRENHEIT => "°F (Fahrenheit)",
                TemperatureUnitOfMeasurement.KELVIN => "K (Kelvin)",
                _ => string.Empty,
            };

            return uom;
        }

        public static string Symbol(this TemperatureUnitOfMeasurement unitOfMeasurement)
        {
            var uom = unitOfMeasurement switch
            {
                TemperatureUnitOfMeasurement.CELSIUS => "°C",
                TemperatureUnitOfMeasurement.FAHRENHEIT => "°F",
                TemperatureUnitOfMeasurement.KELVIN => "K",
                _ => string.Empty,
            };

            return uom;
        }
    }
}
