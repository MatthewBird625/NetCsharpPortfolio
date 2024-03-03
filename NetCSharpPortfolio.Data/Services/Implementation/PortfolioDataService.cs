using NetCSharpPortfolio.Data.Models;
using Newtonsoft.Json;

namespace NetCSharpPortfolio.Data.Services.Implementation
{
    public class PortfolioDataService : IPortfolioDataService
    {
        public Portfolio GetPortfolioData()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PortfolioData.json");

            if (!File.Exists(jsonFilePath))
            {
                throw new InvalidOperationException("JSON file not found.");
            }

            try
            {
                // Read the JSON file content
                string jsonContent = File.ReadAllText(jsonFilePath);

                return JsonConvert.DeserializeObject<Portfolio>(jsonContent) 
                    ?? throw new InvalidOperationException("Invalid deserailisation.");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error fetching Portfolio data: {ex.Message}");
            }
        }
    }
}
