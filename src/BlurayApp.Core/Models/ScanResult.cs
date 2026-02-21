using System;
using System.Collections.Generic;

namespace BlurayApp.Core.Models
{
    public enum BarcodeFormat
    {
        Unknown,
        EAN13,
        QRCode,
        UPC,
        ISBN,
    }

    public class ScanResult
    {
        public string Barcode { get; set; }
        public BarcodeFormat Format { get; set; }
        public DateTime ScanTime { get; set; }
        public string ProductName { get; set; }
        public string AdditionalInfo { get; set; }

        public ScanResult(string barcode, BarcodeFormat format, string productName, string additionalInfo)
        {
            Barcode = barcode;
            Format = format;
            ProductName = productName;
            AdditionalInfo = additionalInfo;
            ScanTime = DateTime.UtcNow;
        }
    }
}