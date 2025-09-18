﻿using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            temperature = temp;
            sumTemperature += temp;
            countUpdated++;
            if (temp > maxTemp || countUpdated == 1)
            {
                maxTemp = temp;
            }
            if (temp < minTemp || countUpdated == 1)
            {
                minTemp = temp;
            }
            Display();

        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {sumTemperature / countUpdated}/{maxTemp}/{minTemp}");
        }
    }
}
