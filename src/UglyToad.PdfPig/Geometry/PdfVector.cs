﻿using System;

namespace UglyToad.PdfPig.Geometry
{
    internal struct PdfVector
    {
        public decimal X { get; }

        public decimal Y { get; }

        public PdfVector(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public PdfVector Scale(decimal scale)
        {
            return new PdfVector(X * scale, Y * scale);
        }

        public decimal GetMagnitude()
        {
            var doubleX = (double)X;
            var doubleY = (double)Y;

            return (decimal)Math.Sqrt(doubleX * doubleX + doubleY * doubleY);
        }

        public PdfVector Subtract(PdfVector vector)
        {
            return new PdfVector(X - vector.X, Y - vector.Y);
        }

        public PdfPoint ToPoint()
        {
            return new PdfPoint(X, Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
