using Microsoft.Extensions.Configuration;

namespace TestFramework.Config
{
    public  class ConfigReader
    {
        public TestSettings GetTestSettings()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("testSettings.json", optional: false);

            IConfiguration config = builder.Build();

            return config.GetRequiredSection(nameof(TestSettings)).Get<TestSettings>();
        }
    }
}
