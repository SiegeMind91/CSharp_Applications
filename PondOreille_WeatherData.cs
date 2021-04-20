using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Weather
{
    public class WeatherData
    {
        public static IEnumerable<WeatherObservation> ReadRange(TextReader text, DateTime? start = null, DateTime? end = null, Action<string> errorHandler = null)
            {
                return 
                    ReadAll(text, errorHandler)
                        .SkipWhile((wo) => wo.TimeStamp < (start ?? DateTime.MinValue))
                        .TakeWhile((wo) => wo.TimeStamp <= (end ?? DateTime.MaxValue));
                //Here is where we're using LINQ to sort throught the data and only return (or "Take") values that meet our parameters 
            }

        public static IEnumerable<WeatherObservation> ReadAll(TextReader text, Action<string> errorHandler)
        {
            // Using the yield return keyword allows us to return the data as it becomes available and not wait for the whole file to be processed
            string line = null;
            while((line = text.ReadLine()) != null)
            {
                if(WeatherObservation.TryParse(line, out WeatherObservation wo))
                {
                    yield return wo;
                }
                else 
                {
                    try 
                    {
                        errorHandler?.Invoke(line);
                    }
                    catch
                    {
                        //We'll leave this empty, but you can add handling here
                    }
                    
                }
            }
        }
    
        
    }
}