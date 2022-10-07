using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PTSD.minigame.data;

namespace PTSD.minigame.data
{
    public static class ElementColor
    {

        public static Color Actinoids_Color { get; private set; }
        public static Color Alkaline_Earth_Metals_Color { get; private set; }
        public static Color Alkali_Metals_Color { get; private set; }
        public static Color Halogens_Color { get; private set; }
        public static Color Lantanoids_Color { get; private set; }
        public static Color Noble_gases_Color { get; private set; }
        public static Color Non_Metals_Color { get; private set; }
        public static Color Post_Transition_Metals_Color { get; private set; }
        public static Color Semi_Metals_Color { get; private set; }
        public static Color Transition_Metals_Color { get; private set; }

        private static KeyValuePair<ElementType, Color>[] TypeColor; 

        static ElementColor()
        {
            Actinoids_Color = new Color((139f / 255f), (162f / 255f), (174f / 255f));
            Alkaline_Earth_Metals_Color = new Color((255f / 255f), (237f / 255f), (188f / 255f));
            Alkali_Metals_Color = new Color((202f / 255f), (107f / 255f), (24f / 255f));
            Halogens_Color = new Color((188f / 255f), (184f / 255f), (145f / 255f));
            Lantanoids_Color = new Color((232f / 255f), (181f / 255f), (33f / 255f));
            Noble_gases_Color = new Color((173f / 255f), (204f / 255f), (220f / 255f));
            Non_Metals_Color = new Color((173f / 255f), (178f / 255f), (147f / 255f));
            Post_Transition_Metals_Color = new Color((125f / 255f), (147f / 255f), (58f / 255f));
            Semi_Metals_Color = new Color((144f / 255f), (170f / 255f), (36f / 255f));
            Transition_Metals_Color = new Color((225f / 255f), (202f / 255f), (200f / 255f));
            
            TypeColor = new KeyValuePair<ElementType, Color>[10];
            TypeColor[0] = new KeyValuePair<ElementType, Color>(ElementType.Actinoids, Actinoids_Color);
            TypeColor[1] = new KeyValuePair<ElementType, Color>(ElementType.Alkali_Metals, Alkali_Metals_Color);
            TypeColor[2] = new KeyValuePair<ElementType, Color>(ElementType.Alkaline_Earth_Metals, Alkaline_Earth_Metals_Color);
            TypeColor[3] = new KeyValuePair<ElementType, Color>(ElementType.Halogens, Halogens_Color);
            TypeColor[4] = new KeyValuePair<ElementType, Color>(ElementType.Lantanoids, Lantanoids_Color);
            TypeColor[5] = new KeyValuePair<ElementType, Color>(ElementType.Noble_gases, Noble_gases_Color);
            TypeColor[6] = new KeyValuePair<ElementType, Color>(ElementType.Non_Metals, Non_Metals_Color);
            TypeColor[7] = new KeyValuePair<ElementType, Color>(ElementType.Post_Transition_Metals, Post_Transition_Metals_Color);
            TypeColor[8] = new KeyValuePair<ElementType, Color>(ElementType.Semi_Metals, Semi_Metals_Color);
            TypeColor[9] = new KeyValuePair<ElementType, Color>(ElementType.Transition_Metals, Transition_Metals_Color);
            
        }
        public static Color getColorByType(ElementType type)
        {
            for(int i = 0; i < TypeColor.Length; i++)
            {
                if (type == TypeColor[i].Key)
                    return TypeColor[i].Value;
            }

            return Color.clear;
        }

    }
}

