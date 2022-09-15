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
            double current = 2.0;
            double voltage = 230.0;
            ElectricalCalculator ec = new(voltage);
            double expectedWattage = 460.0;

            // Act:
            double actualWattage = ec.Wattage(current);

            // Assert:
            Assert.Equal(expectedWattage, actualWattage);
        }

        [Fact]
        public void ExceptionOnIncorrectVoltage_Wattage()
        {
            // Arrange:
            double current = 2.0;
            double voltage = -230.0;
            ElectricalCalculator ec = new(voltage);

            // Actsert:
            Assert.Throws<ArgumentOutOfRangeException>(() => ec.Wattage( current));
        }
    }
}