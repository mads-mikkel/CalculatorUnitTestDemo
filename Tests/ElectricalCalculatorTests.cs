namespace Tests
{
    public class ElectricalCalculatorTests
    {
        /// <summary>
        /// Tests whether or not to Wattage metod returns the correct result, when provided with correct inputs.
        /// </summary>
        [Fact]
        public void CorrectWattage()
        {
            // Arrange:
            ElectricalCalculator ec = new();
            double current = 2.0;
            double voltage = 230.0;
            double expectedWattage = 460.0;

            // Act:
            double actualWattage = ec.Wattage(voltage, current);

            // Assert:
            Assert.Equal(expectedWattage, actualWattage);
        }

        [Fact]
        public void ExceptionOnIncorrectVoltage_Wattage()
        {
            // Arrange:
            ElectricalCalculator ec = new();
            double current = 2.0;
            double voltage = -230.0;

            // Actsert:
            Assert.Throws<ArgumentOutOfRangeException>(() => ec.Wattage(voltage, current));
        }
    }
}