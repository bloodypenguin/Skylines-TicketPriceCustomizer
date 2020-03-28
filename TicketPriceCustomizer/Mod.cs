using ICities;
using TicketPriceCustomizer.OptionsFramework.Extensions;

namespace TicketPriceCustomizer
{
    public class Mod : IUserMod
    {
        public string Name => "Ticket Price Customizer";

        public string Description => "Allows to customize ticket prices";

        public void OnSettingsUI(UIHelperBase helper)
        {
            helper.AddOptionsGroup<Options>();
        }
    }
}