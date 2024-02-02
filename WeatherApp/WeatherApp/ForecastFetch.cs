using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class ForecastFetch
    {
        public class temp { 
            public double day { get; set; }
        }

        public class weather { 
            public string main { get; set; }
            public string descrition { get; set; }

        }

        public class daily { 
            public double dt { get; set; }
            public temp temp { get; set; }
            public List<weather> weather { get; set; }
        }

        public class forecastinfo { 
            public List<daily>daily { get; set; }
        }
    }
}
