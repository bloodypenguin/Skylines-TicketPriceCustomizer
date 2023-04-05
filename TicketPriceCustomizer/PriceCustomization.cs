using System;
using ColossalFramework;
using ColossalFramework.IO;
using UnityEngine;

namespace TicketPriceCustomizer
{
    public class PriceCustomization
    {
        public static void SetPrices(Options options)
        {
            SetBusPrice(options.BusPrice);
            SetMetroPrice(options.MetroPrice);
            SetTrainPrice(options.TrainPrice);
            SetShipPrice(options.ShipPrice);
            SetPlanePrice(options.PlanePrice);
            SetTaxiPrice(options.TaxiPrice);
            SetTramPrice(options.TramPrice);
            SetBlimpPrice(options.BlimpPrice);
            SetFerryPrice(options.FerryPrice);
            SetCableCarPrice(options.CableCarPrice);
            SetMonorailPrice(options.MonorailPrice);
            SetSightseeingBusPrice(options.SightseeingBusPrice);
            SetIntercityBusPrice(options.IntercityBusPrice);
            SetHelicopterPrice(options.HelicopterPrice);
            SetTrolleybusPrice(options.TrolleybusPrice);
        }

        public static void SetSightseeingBusPrice(ushort price)
        {
            SetPrice(price, "Sightseeing Bus");
        }

        public static void SetMetroPrice(ushort price)
        {
            SetPrice(price, "Metro");
        }

        public static void SetTrainPrice(ushort price)
        {
            SetPrice(price, "Train");
        }

        public static void SetShipPrice(ushort price)
        {
            SetPrice(price, "Ship");
        }

        public static void SetPlanePrice(ushort price)
        {
            SetPrice(price, "Airplane");
        }

        public static void SetTramPrice(ushort price)
        {
            SetPrice(price, "Tram");
        }

        public static void SetBlimpPrice(ushort price)
        {
            SetPrice(price, "Blimp");
        }

        public static void SetFerryPrice(ushort price)
        {
            SetPrice(price, "Ferry");
        }

        public static void SetMonorailPrice(ushort price)
        {
            SetPrice(price, "Monorail");
        }

        public static void SetCableCarPrice(ushort price)
        {
            SetPrice(price, "CableCar");
        }

        public static void SetBusPrice(ushort price)
        {
            SetPrice(price, "Bus");
        }

        public static void SetTaxiPrice(ushort price)
        {
            SetPrice(price, "Taxi");
        }
        
        public static void SetTrolleybusPrice(ushort price)
        {
            SetPrice(price, "Trolleybus");
        }

        public static void SetHelicopterPrice(ushort price)
        {
            SetPrice(price, "Helicopter");
        }
        
        public static void SetIntercityBusPrice(ushort price)
        {
            SetPrice(price, "Intercity Bus");
        }

        private static void SetPrice(ushort price, string type)
        {
            if (!LoadingExtension.InGame)
            {
                return;
            }
            var info = PrefabCollection<TransportInfo>.FindLoaded(type);
            if (info == null)
            {
                return;
            }
            SetInfoPrice(info, price);
            for (ushort i = 0; i < TransportManager.instance.m_lines.m_size; i++)
            {
                SetLinePrice(i,info, ref TransportManager.instance.m_lines.m_buffer[i], price);
            }
        }

        private static void SetInfoPrice(TransportInfo info, ushort price)
        {
            if (info.m_ticketPrice == price)
            {
               return; 
            }
            UnityEngine.Debug.Log($"TicketPriceCustomizer: Transport info: {info.name}, was price: {info.m_ticketPrice}, new price: {price}");
            info.m_ticketPrice = price;
        }

        private static void SetLinePrice(ushort lineId, TransportInfo info, ref TransportLine line, ushort price)
        {
            if ((line.m_flags & TransportLine.Flags.Created) == TransportLine.Flags.None || line.Info != info ||
                price == line.m_ticketPrice)
            {
                return;
            }
            UnityEngine.Debug.Log($"TicketPriceCustomizer: Transport line id: {lineId}, #{line.m_lineNumber}, name: {Singleton<TransportManager>.instance.GetLineName(lineId)}, was price: {line.m_ticketPrice}, new price: {price}");
            line.m_ticketPrice = price;
        }
    }
}