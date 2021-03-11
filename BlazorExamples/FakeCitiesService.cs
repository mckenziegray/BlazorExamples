using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples
{
    public class FakeCitiesService : ICitiesService
    {
        private Random random = new Random();

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            if (random.Next(4) == 0)
                return null;

            await Task.Delay(2000);

            return new List<City>
            {
                new City { Name = "Seattle", StateOrProvince = "Washington", Country = "United States" },
                new City { Name = "Portland", StateOrProvince = "Oregon", Country = "United States" },
                new City { Name = "Vancouver", StateOrProvince = "British Columbia", Country = "Canada" },
                new City { Name = "Boise", StateOrProvince = "Idaho", Country = "United States" }
            };
        }
    }
}
