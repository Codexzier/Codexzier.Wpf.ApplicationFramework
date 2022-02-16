using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Codexzier.Wpf.ApplicationFramework.Styles
{
    public class ColorMonochromaticSetup
    {
        private static ResourceDictionary _resourceDictionary = new ResourceDictionary
        {
            Source = new Uri("/Codexzier.Wpf.ApplicationFramework;component/Styles/Colors.xaml")
        };

        public static Monochromatic ColorScheme { get; set; }


        public Color ColorMonochromaticA()
        {
            switch (ColorScheme)
            {
                case Monochromatic.BlueGray:
                    {
                        var c = _resourceDictionary["ColorMonochromaticBlueGrayA"] as Color?;

                        if(c is null)
                        {
                            c = Color.FromRgb(100, 0, 0);
                        }

                        return (Color) c; //ColorMonochromaticBlueGrayA;
}
            }

            return Color.FromRgb(100, 0, 0);
        }

        public static Color ColorMonochromaticB { get; set; }
        public static Color ColorMonochromaticC { get; set; }
        public static Color ColorMonochromaticD { get; set; }
        public static Color ColorMonochromaticE { get; set; }
    }

    public enum Monochromatic
    {
        BlueGray
    }
}
