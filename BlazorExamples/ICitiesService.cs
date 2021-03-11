using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples
{
    public interface ICitiesService
    {
        public Task<IEnumerable<City>> GetCitiesAsync();
    }
}
