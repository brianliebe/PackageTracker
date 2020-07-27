using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackageTracker
{
    public class FedExTracker : ITracker
    {
        public PackageInformation PackageInfo { get; set; }

        public FedExTracker(string trackingNumber)
        {
            PackageInfo = new PackageInformation(trackingNumber, "FedEx");
        }
    }
}
