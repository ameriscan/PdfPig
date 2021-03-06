﻿namespace UglyToad.PdfPig.Tests.Integration
{
    using System;
    using Xunit;

    public class AcroFormsBasicFieldsTests
    {
        private static string GetFilename()
        {
            return IntegrationHelpers.GetDocumentPath("AcroFormsBasicFields");
        }

        [Fact]
        public void GetFormNotNull()
        {
            using (var document = PdfDocument.Open(GetFilename(), new ParsingOptions { UseLenientParsing = false }))
            {
                var form = document.GetForm();
                Assert.NotNull(form);
            }
        }

        [Fact]
        public void GetFormDisposedThrows()
        {
            var document = PdfDocument.Open(GetFilename());

            document.Dispose();

            Action action = () => document.GetForm();

            Assert.Throws<ObjectDisposedException>(action);
        }

        [Fact]
        public void GetsAllFormFields()
        {
            using (var document = PdfDocument.Open(GetFilename(), new ParsingOptions { UseLenientParsing = false }))
            {
                var form = document.GetForm();
                Assert.Equal(16, form.Fields.Count);
            }
        }
    }
}
