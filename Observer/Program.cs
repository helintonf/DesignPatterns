using DesignPatterns.ms;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Location");

            Tracker tracker = new Tracker();

            Reporter reporter = new Reporter("Teste");

            reporter.Subscribe(tracker);

            var location = new Location(47.6456, -122.1312);

            tracker.Track(location);


            location.Latitude = 47.6677;
            location.Longitude = -122.1199;

            //Console.WriteLine("Wheather Station!");

            //WeatherData weatherData = new WeatherData();

            //CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            //weatherData.SetMeasurements(80, 65, 30.4f);
            //weatherData.SetMeasurements(100, 28, 22.6f);
        }

        // Define other methods and classes here

        public interface Subject
        {
            void RegisterObserver(Observer ob);

            void RemoveObserver(Observer ob);

            void NotifyObservers();
        }

        public interface Observer
        {
            void Update(double temp, double humidity, double pressure);
        }

        public interface DisplayElement
        {
            void Display();
        }

        // classes

        public class WeatherData : Subject
        {
            private List<Observer> observers { get; set; }
            private double temperature { get; set; }
            private double humidity { get; set; }
            private double pressure { get; set; }

            public WeatherData()
            {
                observers = new List<Observer>();
            }

            public void RegisterObserver(Observer o)
            {
                observers.Add(o);
            }

            public void RemoveObserver(Observer o)
            {
                observers.Remove(o);
            }

            public void NotifyObservers()
            {
                foreach (var observer in observers)
                {
                    observer.Update(temperature, humidity, pressure);
                }
            }

            public void MeasurementsChanged()
            {
                NotifyObservers();
            }

            public void SetMeasurements(double temperature, double humidity, double pressure)
            {
                this.temperature = temperature;
                this.humidity = humidity;
                this.pressure = pressure;
                MeasurementsChanged();
            }
        }

        public class CurrentConditionsDisplay : Observer, DisplayElement
        {
            private double temperature { get; set; }
            private double humidity { get; set; }
            private Subject WeatherData { get; set; }

            public CurrentConditionsDisplay(Subject weatherData)
            {
                WeatherData = weatherData;
                WeatherData.RegisterObserver(this);
            }

            public void Display()
            {
                Console.WriteLine($@"Current conditions: {temperature} F degrees and {humidity} humidity");
            }

            public void Update(double temperature, double humidity, double pressure)
            {
                this.temperature = temperature;
                this.humidity = humidity;
                Display();
            }
        }
    }
}