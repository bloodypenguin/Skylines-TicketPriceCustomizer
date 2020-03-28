using System;
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
            SetCableCarPrice(options.FerryPrice);
            SetMonorailPrice(options.MonorailPrice);
            SetSightseeingBusPrice(options.SightseeingBusPrice);
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
            info.m_ticketPrice = price;
            for (ushort i = 0; i < TransportManager.instance.m_lines.m_size; i++)
            {
                SetPrice(info, ref TransportManager.instance.m_lines.m_buffer[i], price);
            }
        }

        private static void SetPrice(TransportInfo info, ref TransportLine line, ushort price)
        {
            if (line.Info == info)
            {
                line.m_ticketPrice = price;
                //UnityEngine.Debug.Log("Transport line " + line.m_lineNumber + ", new price: " + line.m_ticketPrice);
            }
        }
    }
}