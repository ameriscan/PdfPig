﻿namespace UglyToad.PdfPig.Graphics.Operations
{
    using System.IO;

    /// <inheritdoc />
    /// <summary>
    /// Fill and then stroke the path, using the nonzero winding number rule to determine the region to fill.
    /// </summary>
    public class FillPathNonZeroWindingAndStroke : IGraphicsStateOperation
    {
        /// <summary>
        /// The symbol for this operation in a stream.
        /// </summary>
        public const string Symbol = "B";

        /// <summary>
        /// The instance of the <see cref="FillPathNonZeroWindingAndStroke"/> operation.
        /// </summary>
        public static readonly FillPathNonZeroWindingAndStroke Value = new FillPathNonZeroWindingAndStroke();

        /// <inheritdoc />
        public string Operator => Symbol;

        private FillPathNonZeroWindingAndStroke()
        {
        }

        /// <inheritdoc />
        public void Run(IOperationContext operationContext)
        {
        }

        /// <inheritdoc />
        public void Write(Stream stream)
        {
            stream.WriteText(Symbol);
            stream.WriteNewLine();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Symbol;
        }
    }
}