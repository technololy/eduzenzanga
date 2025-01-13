using MudBlazor;

namespace EduZanga.Shared;

public static class CustomTheme
    {
        public static readonly MudTheme MyCustomTheme = new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#10B981",           // Green - Primary
                Secondary = "#D1FAE5",         // Light Green - Secondary
                AppbarBackground = "#065F46",  // Dark Green - Appbar
                Background = "#F0FDF4",        // Soft Green - Background
                Surface = "#FFFFFF",           // White for cards or surface
                TextPrimary = "#064E3B",       // Dark Green - Text
                TextSecondary = "#6B7280",     // Neutral Gray - Secondary Text
                ActionDefault = "#10B981",     // Green - Action Default
                ActionDisabled = "#D1D5DB",    // Disabled Actions - Light Gray
                ActionDisabledBackground = "#F3F4F6", // Disabled Actions Background
            },

            PaletteDark = new PaletteDark()
            {
                Primary = "#60A5FA",      // Lighter blue for better visibility in dark mode
                Secondary = "#6B7280",    // Mid-tone gray
                AppbarBackground = "#111827", // Very dark blue-gray
                Background = "#1F2937",   // Dark blue-gray
                BackgroundGray = "#374151", // Slightly lighter than Background for contrast
                Surface = "#1F2937",      // Same as Background
                DrawerBackground = "#1F2937", // Same as Background
                DrawerText = "#F9FAFB",   // Very light gray, almost white
                DrawerIcon = "#60A5FA",   // Same as Primary
                TextPrimary = "#F9FAFB",  // Very light gray, almost white
                TextSecondary = "#E5E7EB", // Light gray
                ActionDefault = "#E5E7EB", // Light gray
                ActionDisabled = "#4B5563", // Darker gray for disabled elements
                ActionDisabledBackground = "#374151", // Dark gray for disabled backgrounds
                Divider = "#374151",      // Dark gray for dividers
                DividerLight = "#4B5563", // Slightly lighter gray for some dividers
                TableLines = "#4B5563",   // Gray for table lines
                LinesDefault = "#4B5563", // Gray for default lines
                LinesInputs = "#60A5FA",  // Primary color for input lines
                TextDisabled = "#9CA3AF"  // Muted gray for disabled text
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "8px"
            },
            
            //PaletteDark = new PaletteDark() { }
        };
    }