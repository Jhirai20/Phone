using System;
using System.Collections.Generic;

namespace Phone
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return "...Dooo do dooo dooo...";
        }
                    
        public string Unlock() 
        {
            return $"{this.VersionNumber} unlocked with fungerprint scanner";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("#####################");
            Console.WriteLine($"Version NUmber: {VersionNumber}");
            Console.WriteLine( $"Battery%: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone {RingTone}");
            Console.WriteLine("#####################");
        }
    }
}