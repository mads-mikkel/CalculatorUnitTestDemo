namespace Calculator
{
    /// <summary>
    /// A calculator for eletrics.
    /// </summary>
    public class ElectricalCalculator
    {
        /// <summary>
        /// Calculates the energy consumption (wattage) in Watts, using the provided voltage (V) and current (A).
        /// </summary>
        /// <param name="voltage">A non negative number, representing the voltage.</param>
        /// <param name="current">A non negative number, representing the current.</param>
        /// <returns>The energy consumption in Watts</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double Wattage(double voltage, double current)
        {
            if (voltage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(voltage), "voltage must be a non negative mumber.");
            }
            else if (current < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(current), "current must be a non negative mumber.");
            }
            else
            {
                return voltage * current;
            }
        }
    }
}