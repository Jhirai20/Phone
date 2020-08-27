using System;
using System.Collections.Generic;

namespace Phone
{
    public class Nokia : Phone, IRingable
    {
        public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) :base(versionNumber,batteryPercentage,carrier,ringTone){}
        public string Ring()
        {
            return "... Ringg ring ringgg ...";
        }
        public string Unlock()
        {
            return $"{this.VersionNumber} unlocked with passcode";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Version NUmber: {VersionNumber}");
            Console.WriteLine( $"Battery%: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone {RingTone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}