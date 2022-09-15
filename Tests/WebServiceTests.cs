namespace Tests
{
    public class WebServiceTests
    {
        [Fact]
        public void ExchangeRatesApiWorks()
        {
            // Arrange:
            ExchangeRatesWebService ws = new();
            double actualExchangeRate;

            // Act:
            actualExchangeRate = ws.GetUsdInDkk();

            // Assert:
            Assert.InRange(actualExchangeRate, 7.0, 8.0);
        }
    }
}