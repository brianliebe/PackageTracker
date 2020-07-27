using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace PackageTracker
{
    public class UPSTracker : ITracker
    {
        public PackageInformation PackageInfo { get; private set; }

        public UPSTracker(string trackingNumber)
        {
            PackageInfo = new PackageInformation(trackingNumber, "UPS");
            LocationInformation lastLocation = new LocationInformation();

            string location = @"C:\Users\brian\source\files\PackageTracker\ups_credentials.json";
            dynamic credentials = JsonConvert.DeserializeObject(File.ReadAllText(location));

            string json = @"
{
    ""Security"": {
        ""UsernameToken"": {
            ""Username"": """ + credentials.Username + @""",
            ""Password"": """ + credentials.Password + @"""
        },
        ""UPSServiceAccessToken"": {
            ""AccessLicenseNumber"": """ + credentials.AccessLicenseNumber + @"""
        }
    },
    ""TrackRequest"": {
        ""Request"": {
            ""RequestAction"": ""Track"",
            ""RequestOption"": ""activity""
        },
        ""InquiryNumber"": """ + trackingNumber + @"""
    }
}
";

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://onlinetools.ups.com/json/Track");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();


            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic obj = JsonConvert.DeserializeObject(result);

                dynamic lastActivity = obj.TrackResponse.Shipment.Package.Activity[0];
                dynamic lastActivityLocation = lastActivity.ActivityLocation;
                dynamic lastAddress = lastActivityLocation.Address;

                lastLocation.State = lastAddress.StateProvinceCode;
                lastLocation.City = lastAddress.City;
                lastLocation.ZipCode = lastAddress.PostalCode;
                lastLocation.Status = lastActivity.Status.Description;
                lastLocation.StatusDate = lastActivity.Date;
                lastLocation.StatusTime = lastActivity.Time;
            }

            PackageInfo.LastLocation = lastLocation;
        }
    }
}
