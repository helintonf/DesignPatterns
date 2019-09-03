using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace DesignPatterns.csharp
{
    class WeatherData : IObservable<WeatherData>
    {
        private double Temperature { get; set; }
        private double Humidity { get; set; }
        private double Pressure { get; set; }

        public WeatherData() { }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            throw new NotImplementedException();
        }
    }
}

