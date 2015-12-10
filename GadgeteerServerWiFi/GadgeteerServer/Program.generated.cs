//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GadgeteerServer {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The WiFi RS21 module using socket 6 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.WiFiRS21 wifiRS21;
        
        /// <summary>The Relay X1 module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.RelayX1 relayX1;
        
        /// <summary>The USB Client SP module using socket 1 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.USBClientSP usbClientSP;
        
        /// <summary>The LightSense module using socket 10 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.LightSense lightSense;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZSpider Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZSpider)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.wifiRS21 = new GTM.GHIElectronics.WiFiRS21(6);
            this.relayX1 = new GTM.GHIElectronics.RelayX1(4);
            this.usbClientSP = new GTM.GHIElectronics.USBClientSP(1);
            this.lightSense = new GTM.GHIElectronics.LightSense(10);
        }
    }
}
