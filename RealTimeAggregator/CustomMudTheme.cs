using MudBlazor;

namespace RealTimeAggregator
{
    public class CustomMudTheme : MudTheme
    {
        public CustomMudTheme()
        {
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontSize = "0.875rem",
                    LineHeight = 1.43
                },
                H6 = new H6()
                {
                    FontSize = "1rem",
                    FontWeight = 600
                }
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "4px"
            };

            Palette = new Palette()
            {
                Background = "#ffffff",
                TextPrimary = "#424242",
                Primary = "#1976d2",
                Secondary = "#0097a7",
                Tertiary = "#5d4037"
            };
        }
    }
}
