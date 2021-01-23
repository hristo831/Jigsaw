using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace TestConfiguration
{
    /// <summary>
    /// Configurator.
    /// </summary>
    public static class Configurator
    {
        /// <summary>
        /// Gets or sets Test Settings.
        /// </summary>
        public static TestSettings Settings { get; set; }

        /// <summary>
        /// Create Test Settings.
        /// </summary>
        /// <returns></returns>
        public static TestSettings Create()
        {
            var path = TryGetSolutionDirectoryInfo().FullName;
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("testsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();


            Settings = new TestSettings()
            {
                Browser = configurationRoot.GetSection("testSettings").GetSection("Browser").Value,
                BaseUrl = configurationRoot.GetSection("testSettings").GetSection("BaseUrl").Value
            };

            return Settings;
        }

        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }
    }
}
