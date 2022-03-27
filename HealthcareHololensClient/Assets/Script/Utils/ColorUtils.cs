namespace Assets.Script.Utils
{
    using System;
    using UnityEngine;

    class ColorUtils
    {
        public static Color GetColorByString(string colorString)
        {
            int channelR = Convert.ToInt32(colorString.Split(',')[0]);
            int channelG = Convert.ToInt32(colorString.Split(',')[1]);
            int channelB = Convert.ToInt32(colorString.Split(',')[2]);
            return new Color(channelR, channelG, channelB, 250f);
        }
    }
}
