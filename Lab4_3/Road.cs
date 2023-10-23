using System;
using System.Collections.Generic;

namespace Lab4_3
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Lanes { get; set; }
        public double TrafficLevel { get; set; }

        public Road(double length, double width, int lanes)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            TrafficLevel = 0.0;
        }
    }

}
