using CSharpPortfolioNet7.Data.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace CSharpPortfolioNet7.Data.Services.Implementation
{
    public class PortfolioDataService : IPortfolioDataService
    {
        public Portfolio GetPortfolioData()
        {
            // Specify the name of the embedded resource
            string resourceName = "CSharpPortfolioNet7.Data.PortfolioData.json";

            try
            {
                // Get the assembly where the resource is embedded
                var assembly = Assembly.GetExecutingAssembly();

                // Read the content of the embedded resource
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null)
                    {
                        throw new InvalidOperationException("Resource not found.");
                    }

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        // Read the content of the resource (JSON file)
                        string jsonContent = reader.ReadToEnd();

                        // Deserialize the JSON content into a Portfolio object
                        return JsonConvert.DeserializeObject<Portfolio>(jsonContent)
                            ?? throw new InvalidOperationException("Invalid deserialization.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch any exceptions that occur during the process and throw a custom exception
                throw new InvalidOperationException($"Error fetching Portfolio data: {ex.Message}");
            }
        }

    }
}
