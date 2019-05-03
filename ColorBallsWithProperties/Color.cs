using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Color
    {
        private byte Red { get; set; }
        private byte Green { get; set; }
        private byte Blue { get; set; }
        private byte Alpha { get; set; }
        public byte GrayScale => (byte)((Red + Green + Blue) / 3);

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        

        /* Código antigo, versão sem propriedades
        public byte GetRedValue() => this.red; o

        public byte GetGreenValue() => this.green; o

        public byte GetBlueValue() => this.blue; o

        public byte Getalphaue() => this.alpha; o

        public byte GetGrayscaleValue() => (byte)((red + green + blue) / 3); o

        public void SetRedValue(byte red) => this.red = red; o

        public void SetGreenValue(byte green) => this.green = green; o

        public void SetBlueValue(byte blue) => this.blue = blue; 0

        public void Setalphaue(byte alpha) => this.alpha = alpha; o
        */

    }
}
