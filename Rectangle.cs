using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeleson
{
    class Rectangle
    {
        public int left;

        public int top;

        private int width;

        private int height;




        public Rectangle(int left, int top, int width, int height)
        {
            this.left = left;
            this.top = top;

            if (width <= 0)
                throw new AggregateException(nameof(width));

            if (height <= 0)
                throw new AggregateException(nameof(height));

            this.width = width;
            this.height = height;





        }

        public int Widht
        {
            get { return width; }

            set
            {
                if (value > 0)
                    width = value;
            
            
            
            }

        }
        public int Height
        {
            get { return height; }

            set 
            
            {

                if (value > 0)
                    height = value;




            
            
            
            }
        
        
        
        }



    }
}
