using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PackageTracker
{
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }

        private void BtnAddTrackingNumber_Click(object sender, EventArgs e)
        {
            if (!textTrackingNumber.Text.Trim().Equals(""))
            {
                foreach (string trackingNumber in textTrackingNumber.Text.Trim().Split(' '))
                {
                    PackageInformation info;

                    switch (trackingNumber.Length)
                    {
                        case 18:
                            // UPS
                            info = new UPSTracker(trackingNumber).PackageInfo;
                            break;
                        case 12:
                            // FedEx
                            info = new FedExTracker(trackingNumber).PackageInfo;
                            break;
                        default:
                            info = null;
                            break;
                    }
                    if (info != null)
                    {
                        grid.Rows.Add(info.TrackingNumber, info.Service, info.LastLocation.GetLastLocation(), info.LastLocation.GetStatus());
                    }
                }
                textTrackingNumber.Clear();
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }
    }
}
