using System;
using System.Device.Location;
using System.Diagnostics;
using System.Net;

namespace WhereAmI
{
    class MapImage
    {
        public static void Show(GeoCoordinate location)
        {
            //Notice here that we're making some formatting adjustments, and that the Horizontal accuracy is given to us in meters, so we'll capture that detail in the name
            string filename = $"{location.Latitude:##.000},{location.Longitude:##.000},{location.HorizontalAccuracy:####}m.jpg";

            DownloadMapImage(BuildURI(location), filename);

            OpenWithDefaultApp(filename);
        }

        private static void DownloadMapImage(Uri target, string filename)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(target, filename);
            }
        }

        /// <summary>
        /// Map Image REST API by HERE Location Services
        /// </summary>
        /// <remarks>
        /// https://developer.here.com/
        /// </remarks>

        //This function builds the one long URI we'll need to retrieve our Map from the API
        private static Uri BuildURI(GeoCoordinate location)
        {
            #region HERE App ID & App Code
            string HereApi_AppID = ""; //Remember to put your AppID and AppCode here or it won't work
            string HereApi_AppCode = "";
            #endregion

            var HereApi_DNS = "image.maps.cit.api.here.com"; //Server name we have to use to obtain the image, if you were in production you'd leave out the cit piece
            var HereApi_URL = $"https://{HereApi_DNS}/mia/1.6/mapview"; //The REST API structure outlined in the documentation
            var HereApi_Secrets = $"&app_id={HereApi_AppID}&app_code={HereApi_AppCode}"; //Here we're building the query string parameters that we'll need

            var latlon = $"&lat={location.Latitude}&lon={location.Longitude}";//Building the lat and long query string parameters

            return new Uri(HereApi_URL + $"?u={location.HorizontalAccuracy}" + HereApi_Secrets + latlon); //Then we return all of the pieces as a URI 
        }

        private static void OpenWithDefaultApp(string filename)
        {
            var si = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = $"/C start {filename}", //Here we're just saying open the default program for that file type
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(si);
        }
    }
}
