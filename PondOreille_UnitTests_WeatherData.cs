using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFLuent;
using Weather;

namespace Tests_WeatherData
{
    [TestClass]
    public class Tests_WeatherData
    {
        //This variable is used in test 040
        private static string filename = @"c:\users\fakeFilePath\NotReal\YouNeedToUpdateIfYouWantItToRun.txt";

        #region Sample Data
        private static string sampleData =
@"date       time    	Air_Temp	Barometric_Pressure	Dew_Point	Relative_Humidity	Wind_Dir	Wind_Gust	Wind_Speed
2012_01_01 00:02:14	34.30	30.50	26.90	74.20	346.40	11.00	 3.60
2012_01_01 00:08:29	34.10	30.50	26.50	73.60	349.00	12.00	 8.00
2012_01_01 00:14:45	33.90	30.60	26.80	75.00	217.80	12.00	 9.20
2012_01_01 00:21:00	33.80	30.60	27.30	76.60	280.80	17.00	14.00";
        #endregion


        [TestMethod]
        public void Test_010_ParseLine()
        {
            var text = "2012_01_01 00:02:14 34.30   30.50   26.90   74.20   346.40  11.00   3.60";
            var wo = WeatherObservation.Parse(text);

            Check.That(wo.TimeStamp).IsEqualTo(new DateTime(2012, 01,01,00,02,14)); //This is a check from the NFluent library, just another unit testing library
            Check.That(wo.Barometric_Pressure).IsCloseTo(30.5, 0.01);
        }

        [TestMethod]
        public void Test_020_TryParseLine()
        {
            var text = "2012_01_01 00:02:14 34.30   30.50   26.90   74.20   346.40  11.00   3.60";
            var tryParseOutcome = WeatherObservation.TryParse(text, out WeatherObservation wo); 

            Check.That(tryParseOutcome).IsTrue();

            Check.That(wo.TimeStamp).IsEqualTo(new DateTime(2012, 01,01,00,02,14)); 
            Check.That(wo.Barometric_Pressure).IsCloseTo(30.5, 0.01);
        }

        [TestMethod]
        public void Test_030_ParseSampleText()
        {
            using (var text = new StringReader(sampleData))
            {
                text.ReadLine(); //ignore 1st line of text, it contains headers

                var data = WeatherData.ReadAll(text);
                
                Check.That(data.Count()).IsEqualTo(4); // We know there are 4 lines of data after the headers            
            }
        }

        [TestMethod]
        public void Test_040_ParseSampleFile()
        {
            using (var text = new StreamReader(filename))
            {
                text.ReadLine(); //ignore 1st line of text, it contains headers

                var data = WeatherData.ReadAll(text);
                
                Check.That(data.Count()).IsEqualTo(70675); //This is the number of lines we have in the data, so we expect that number to come back            
            }
        }

        [TestMethod]
        public void Test_050_ParseFilteredSampleFile()
        {
            var start = DateTime.Parse("2012-12-31 12:51:48");
            var end = DateTime.Parse("2012-12-31 22:43:13");

            using (var text = StreamReader(filename))
            {
                text.ReadLine(); //ignore 1st line of text, it contains headers 

                var data = WeatherData.ReadRange(text, start, end);

                Check.That(data.Count()).IsEqualTo(6); //With the start and end date we've given the test, we know there are only 6 results
            }
        }

        [TestMethod]
        public void Test_060_FitLineToFilteredSampleFile()
        {
            var start = DateTime.Parse("2012-01-02 00:00:00");
            var end = DateTime.Parse("2012-01-02 17:00:00");

            using (var text = StreamReader(filename))
            {
                text.ReadLine(); //ignore 1st line of text, it contains headers 

                //Extract 
                //Transform
                //Load

                var data = from wo in WeatherData.ReadRange(text, start, end) //Extract
                            select new //Transforming
                            {
                                Hours = (wo.TimeStamp - start).TotalHours,
                                wo.Barometric_Pressure
                            };

                var arrX = new List<double>();
                var arrY = new List<double>();

                foreach(var wo in data) //Load 
                {
                    arrX.Add(wo.Hours);
                    arrY.Add(wo.Barometric_Pressure);
                }

                //An example of a tuple in C#
                var (intersect, slope) = MathNet.Numerics.Fit.Line(arrX.ToArray(), arrY.ToArray()); //The line method takes an array for each the x and y axis, so we need to convert our list 

                Check.That(slope).IsLessThanZero(); //We could be more exact here, but this fits our purposes because it's a negative slope
            }
        }
    }
}




