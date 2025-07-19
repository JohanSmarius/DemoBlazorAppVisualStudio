using BlazorApp.Models;
using BlazorApp.Services;
using Xunit;

namespace BlazorAppTests.Services
{
    public class ForecastServiceTests
    {
        [Fact]
        public void GetForecasts_ReturnsFiveForecasts()
        {
            // Arrange
            var service = new ForecastService();

            // Act
            var forecasts = service.GetForecasts();

            // Assert
            Assert.NotNull(forecasts);
            Assert.Equal(5, forecasts.Count);
        }

        [Fact]
        public void GetForecasts_ForecastsHaveValidProperties()
        {
            // Arrange
            var service = new ForecastService();

            // Act
            var forecasts = service.GetForecasts();

            // Assert
            foreach (var forecast in forecasts)
            {
                Assert.InRange(forecast.TemperatureC, -20, 54); // Random.Shared.Next is exclusive of upper bound
                Assert.False(string.IsNullOrWhiteSpace(forecast.Summary));
            }
        }
    }
}
