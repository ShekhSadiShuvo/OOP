﻿using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
   
        public class Shape
        {
            private Color _color;
            private double _x, _y;
            private int _width, _height;

            public Shape()
            {
                _color = Color.Green;
                _x = 0.0f;
                _y = 0.0f;
                _width = 100;
                _height = 100;
            }



            public Color Color
            {
                get { return _color; }
                set => _color = value;
            }

            public double X
            {
                get { return _x; }
                set => _x = value;
            }

            public double Y
            {
                get { return _y; }
                set => _y = value;
            }

            public int Width
            {
                get { return _width; }
                set => _width = value;
            }

            public int Height
            {
                get { return _height; }
                set => _height = value;
            }
            public void Draw()
            {
                SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            }

            public bool IsAt(Point2D pt)
            {
                return (pt.X >= _x && pt.X <= _x + _width && pt.Y >= _y && pt.Y <= _y + _height);
            }

        }
}
