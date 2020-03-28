using ICities;
using TicketPriceCustomizer.OptionsFramework;

namespace TicketPriceCustomizer
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public static bool InGame = false;

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            InGame = true;
            PriceCustomization.SetPrices(OptionsWrapper<Options>.Options);
        }

        public override void OnLevelUnloading()
        {
            base.OnLevelUnloading();
            try
            {
                PriceCustomization.SetPrices(new Options());
            }
            finally
            {
                InGame = false;
            }
        }
    }
}