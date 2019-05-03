using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    class Ball
    {
        // Instance Variables
        private Color Color;
        public float size;
        private int throwCount;

        public Ball(byte red, byte green, byte blue, float size)
        {
            this.Color = new Color(red, green, blue);
            this.size = size;
            this.throwCount = 0;
        }

        public Ball(Color Color, float size)
        {
            this.Color = Color;
            this.size = size;
            ThrowCount = 0;
        }
        
        public float Size
        {
            get => this.size;
            set
            {
                this.size = value;
            }
        }
        
        public int ThrowCount { get; private set; }

        public void Throw()
        {
            if (size > 0) ThrowCount++;
        }

        public float Pop() => this.size = 0;

        /* Código antigo, versão sem propriedades
        public int Throw()
        {
            if (size > 0) this.throwCount++;
            return this.throwCount;
        }

        public int GetThrowCount() => this.throwCount;
        */
    }
}
