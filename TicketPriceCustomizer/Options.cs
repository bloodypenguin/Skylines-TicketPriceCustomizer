using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketPriceCustomizer.OptionsFramework.Attibutes;

namespace TicketPriceCustomizer
{
    [Options("TicketPriceCustomizer")]
    public class Options
    {
        private const string Prices = "Ticket prices, multiplied by 100. Enter 320 to set ticket price 3,20 for example.";

        [Textfield("Bus ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetBusPrice))]
        public ushort BusPrice { get; set; } = 100;
        
        [Textfield("Metro ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetMetroPrice))]
        public ushort MetroPrice { get; set; } = 200;
        
        [Textfield("Train ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetTrainPrice))]
        public ushort TrainPrice { get; set; } = 200;
        
        [Textfield("Ship ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetShipPrice))]
        public ushort ShipPrice { get; set; } = 500;
        
        [Textfield("Airplane ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetPlanePrice))]
        public ushort PlanePrice { get; set; } = 1000;
        
        [Textfield("Taxi price per kilometer", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetTaxiPrice))]
        public ushort TaxiPrice { get; set; } = 1000;
        
        [Textfield("Tram ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetTramPrice))]
        public ushort TramPrice { get; set; } = 80;
        
        [Textfield("Monorail ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetMonorailPrice))]
        public ushort MonorailPrice { get; set; } = 200;
        
        [Textfield("Cable car ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetCableCarPrice))]
        public ushort CableCarPrice { get; set; } = 120;
        
        [Textfield("Ferry ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetFerryPrice))]
        public ushort FerryPrice { get; set; } = 100;
        
        [Textfield("Blimp ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetBlimpPrice))]
        public ushort BlimpPrice { get; set; } = 115;
        
        [Textfield("Sightseeing bus ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetSightseeingBusPrice))]
        public ushort SightseeingBusPrice { get; set; } = 3000;
        
        [Textfield("Trolleybus ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetTrolleybusPrice))]
        public ushort TrolleybusPrice { get; set; } = 80;
        
        [Textfield("Helicopter ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetHelicopterPrice))]
        public ushort HelicopterPrice { get; set; } = 115;
        
        [Textfield("Intercity bus ticket price", Prices, typeof(PriceCustomization), nameof(PriceCustomization.SetIntercityBusPrice))]
        public ushort IntercityBusPrice { get; set; } = 100;
    }
}
