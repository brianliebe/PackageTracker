using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PackageTracker
{
    public class PackageInformation
    {
        public string TrackingNumber { get; private set; }
        public LocationInformation LastLocation { get; set; }
        public string Service { get; set; }

        public PackageInformation(string trackingNumber, string service)
        {
            TrackingNumber = trackingNumber;
            Service = service;
        }
    }

    public class LocationInformation
    {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Status { get; set; }
        public string StatusDate { get; set; }
        public string StatusTime { get; set; }

        public string GetLastLocation()
        {
            return $"{City} {State}, {ZipCode}";
        }

        public string GetStatus()
        {
            DateTime dateTime = DateTime.ParseExact($"{StatusTime} {StatusDate}", "hhmmss yyyyMMdd", new CultureInfo("en-US"));
            string date = dateTime.ToString("f");
            return $"{Status} on {date}";
        }
    }
}
